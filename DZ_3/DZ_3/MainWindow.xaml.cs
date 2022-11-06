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

namespace DZ_3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (login != "" && password != "")
            {
                var a = new ValidateUser().Validate(User.GetUser(), password, login);
                if (a == true) MessageBox.Show("Добро пожаловать!");
                else MessageBox.Show("Пользователь не найден", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop);
        }
    }
}
