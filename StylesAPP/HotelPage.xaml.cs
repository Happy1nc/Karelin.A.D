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


namespace StylesAPP
{
    /// <summary>
    /// Логика взаимодействия для HotelPage.xaml
    /// </summary>
    public partial class HotelPage : Page
    {
        public string password;
        public string login;
        string loginAdmin = "Админ";
        string passwordAdmin = "Админ";
        string loginManager = "Менеджер";
        string passwordManager = "Менеджер";

        public HotelPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Loginbox.Text == loginAdmin && Passwordbox.Password == passwordAdmin)
            {
                password = Passwordbox.Password;
                Manager.MainFrame.Navigate(new AdminPage());
                MessageBox.Show("Добро пожаловать, администратор");
            }

            else if (Loginbox.Text == loginManager && Passwordbox.Password == passwordManager)
            {
                password = Passwordbox.Password;
                Manager.MainFrame.Navigate(new ManagerPage());
                MessageBox.Show("Добро пожаловать, менеджер");
            }
            else
            {
                MessageBox.Show("Неверные данные, повторите попытку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            if (ShowPassword.IsChecked == true)
            {
                Passwordbox.Visibility = Visibility.Hidden;
                PasswordUnmask.Visibility = Visibility.Visible;
                PasswordUnmask.Text = Passwordbox.Password;
            }
            else
            {
                Passwordbox.Visibility = Visibility.Visible;
                PasswordUnmask.Visibility = Visibility.Hidden;
                Passwordbox.Password = PasswordUnmask.Text;
            }
        }
    }
}
