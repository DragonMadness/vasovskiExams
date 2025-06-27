using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace DurkaApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowData data;

        public MainWindow()
        {
            InitializeComponent();
            data = this.DataContext as MainWindowData;
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            ResultBlock.Text = data.GetMontlyPayment().ToString();
        }
    }

    public class MainWindowData
    {
        public int Sum { get; set; }
        public int InterestRate { get; set; }
        public int MonthCount { get; set; }
        public double Result { get; set; }
        public MainWindowData() { }

        public double GetMontlyPayment()
        {
            return (Sum + Sum * InterestRate / 100) / MonthCount;
        }
    }
}
