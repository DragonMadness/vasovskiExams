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

        private void Solve(object sender, RoutedEventArgs e)
        {
            int solution = 0;
            int arg1 = int.Parse(Arg1.Text);
            int arg2 = int.Parse(Arg2.Text);
            switch (Selector.Text)
            {
                case "+":
                    {
                        solution = arg1 + arg2;
                        break;
                    }
                case "-":
                    {
                        solution = arg1 - arg2;
                        break;
                    }
                case "*":
                    {
                        solution = arg1 * arg2;
                        break;
                    }
                case "/":
                    {
                        solution = arg1 / arg2;
                        break;
                    }
                default:
                    {
                        solution = 0;
                        break;
                    }
            }

            Answer.Text = "Результат: " + solution.ToString();
        }
    }
}
