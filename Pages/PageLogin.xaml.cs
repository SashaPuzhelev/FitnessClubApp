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

namespace FitnessClubApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEntrance.xaml
    /// </summary>
    
    public partial class PageLogin : Page
    {
        private static int countTry;
        public PageLogin()
        {
            InitializeComponent();
        }
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            countTry++;
            for (int i = 0; i< User.GetUsers().Length; i++)
            {
                if (TextBoxLogin.Text == User.GetUsers()[i].Login)
                {
                    if (PasswordBox.Password == User.GetUsers()[i].Password)
                    {
                        NavigationService.Navigate(new PageHome());
                    }
                    else
                    {
                        MessageBox.Show("Вы неверно ввели пароль! Повторите попытку", "Ошибка");
                    }
                }
            }
            
        }
        private void CheckBoxPassword_Checked(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = PasswordBox.Password;
        }
        private void CheckBoxPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = TextBoxPassword.Text;
        }
    }
}
