using Linq.Core;
using Linq.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Linq
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            UserReader reader = new UserReader();
            var result = await reader.UserWork(loginTextBox.Text, passwordTextBox.Text);
            if (loginTextBox.Text != "" && passwordTextBox.Text != "")
            {
                if (result == true)
                {
                    MessageBox.Show("Вход выполнен");
                }
                else MessageBox.Show("Неверный логин или пароль");
            }
            else MessageBox.Show("Не все поля заполнены");
        }
    }
}
