using System;
using System.Collections;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows;
using System.Windows.Controls;

namespace StatToExcel
{
    public class OracleWorker:IDbWorker
    {
        private static OracleConnectionStringBuilder _connectionString;

        public OracleWorker(string ip, string user, string password)
        {
            _connectionString = new OracleConnectionStringBuilder
            {
                UserID=user,
                Password = password,
                DataSource = $"{ip}:1521/ora10",
                MinPoolSize = 1,
                ValidateConnection = true,
                MaxPoolSize = 1
            };
        }

        private static OracleConnection GetConnetion(string connectionString)
        {
            return new OracleConnection(connectionString);
        }

        public virtual void ExecuteProcedure(string procedureName, Parametrs parametrs)
        {
            try
            {
                using (var connection = GetConnetion(_connectionString.ToString()))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                
                    command.Parameters.Add("DetenID", OracleDbType.Varchar2, parametrs.DepartmentId,
                        ParameterDirection.Input);

                    command.Parameters.Add("Date_beg", OracleDbType.Date, parametrs.BeginDate,
                        ParameterDirection.Input);

                    command.Parameters.Add("Date_end", OracleDbType.Date, parametrs.EndDate,
                        ParameterDirection.Input);

                    command.CommandText = procedureName;

                    command.ExecuteNonQuery();
                
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,$"Ошибка выполнения {procedureName}");
            }
        }

        public virtual ArrayList SelectData(string commandText)
        {
            var result = new ArrayList();
            try
            {
                using (var connection = GetConnetion(_connectionString.ToString()))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = commandText;

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows) return null;

                    //Создаём заголовок таблицы
                    var header = new string[reader.FieldCount];
                    for (var i = 0; i <= reader.FieldCount - 1; i++)
                    {
                        header[i] = reader.GetName(i);
                    }

                    result.Add(header);

                    //Создаём саму таблицу
                    while (reader.Read())
                    {
                        var data = new string[reader.FieldCount];
                        for (var i = 0; i <= reader.FieldCount - 1; i++)
                        {
                            data[i] = reader[i].ToString();
                        }
                        result.Add(data);
                    }

                    reader.Dispose();
                    command.Dispose();
                }

                return result;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}; select: {commandText}", "Ошибка селекта...");
                return null;
            }
        }
    }
}