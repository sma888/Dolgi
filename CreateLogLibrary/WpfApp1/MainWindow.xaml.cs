using CreateLogLibrary;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Class1 _class1;

        public MainWindow()
        {
            InitializeComponent();
            _class1 = new Class1();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = 0;
                int b = 1;

                int res = b / a;
            }

            catch (Exception ex)
            {
                await _class1.Create(ex.Message);
            }

        }
    }
}
