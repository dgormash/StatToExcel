using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StatToExcel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static Parametrs _parametrs;
        private DateTime _startDate;
        private DateTime _endDate;
        private ProcedureExceptions _procExceptions = new ProcedureExceptions();


        public string Department { get;  set; }
        public string Procedure { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _parametrs = new Parametrs();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            _startDate = beginDatePicker.DisplayDate;
            _endDate = endDatePicker.DisplayDate;
            var task = new Thread(ExecuteAction) {IsBackground = true};


            if (!chbNs42.IsChecked == true)
            {
                _procExceptions.SetException(0);
            }
            else
            {
                _procExceptions.RemoveException(0);
            }

            if (!chbNs32.IsChecked == true)
            {
                _procExceptions.SetException(1);
            }
            else
            {
                _procExceptions.RemoveException(1);
            }

            if (!chb1207.IsChecked == true)
            {
                _procExceptions.SetException(2);
            }
            else
            {
                _procExceptions.RemoveException(2);
            }

            if (!chb264.IsChecked == true)
            {
                _procExceptions.SetException(3);
            }
            else
            {
                _procExceptions.RemoveException(3);
            }

            if (!chb2025.IsChecked == true)
            {
                _procExceptions.SetException(4);
            }
            else
            {
                _procExceptions.RemoveException(4);
            }

            if (!chbNotPay.IsChecked == true)
            {
                _procExceptions.SetException(5);
            }
            else
            {
                _procExceptions.RemoveException(5);
            }

            if (!chbFssp.IsChecked == true)
            {
                _procExceptions.SetException(6);
            }
            else
            {
                _procExceptions.RemoveException(6);
            }

            if (!chbPovt.IsChecked == true)
            {
                _procExceptions.SetException(7);
            }
            else
            {
                _procExceptions.RemoveException(7);
            }

            if (!chb1717.IsChecked == true)
            {
                _procExceptions.SetException(8);
            }
            else
            {
                _procExceptions.RemoveException(8);
            }

            if (!chbRoz.IsChecked == true)
            {
                _procExceptions.SetException(9);
            }
            else
            {
                _procExceptions.RemoveException(9);
            }

            task.Start();
        }

        private  void ExecuteAction()
        {
            var logic = new ReportLogic();
            logic.Start(_startDate, _endDate, _procExceptions);
        }

        public void UpdateLabels(Label label, string message)
        {
            Action action = () => label.Content = message;
            Dispatcher.BeginInvoke(action);
        }

        private void chbNs42_Checked(object sender, RoutedEventArgs e)
        {

        }
    }


}
