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
using GroupViewWPF.ViewModel;

namespace GroupViewWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainViewModel = new MainWindowViewModel();
        }

        //private void showButton_Click(object sender, RoutedEventArgs e)
        //{
        //    (DataContext as MainWindowViewModel).Display();
        //}

    }
}
