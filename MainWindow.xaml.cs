using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void Click(object sender, RoutedEventArgs e)
        {
            data.Add();
        }
    }

    public class MainWindowData : INotifyPropertyChanged
    {
        private int _Count = 0;
        public int Count {
            get {
                return _Count;
            }
            private set
            {
                _Count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add()
        {
            Count++;
        }
    }
}
