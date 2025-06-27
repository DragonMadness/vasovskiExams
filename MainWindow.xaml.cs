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
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Calculate(object sender, RoutedEventArgs e)
        {
            double Input = 0;
            try
            {
                Input = double.Parse(UserInput.Text);
            } catch
            {
                UserInput.BorderBrush = Brushes.Red;
                return;
            }
            UserInput.BorderBrush = Brushes.DarkGray;
            AnswerBlock.Text = "Результат: " + (100D / Input);
        }
    }
}
