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
            task.Start();
        }

        private  void ExecuteAction()
        {
            var logic = new ReportLogic();
            logic.Start(_startDate, _endDate);
        }

        public void UpdateLabels(Label label, string message)
        {
            Action action = () => label.Content = message;
            Dispatcher.BeginInvoke(action);
        }
    }


}
