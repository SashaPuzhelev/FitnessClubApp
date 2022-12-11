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
    /// Логика взаимодействия для PageHome.xaml
    /// </summary>
    public partial class PageHome : Page
    {
        public PageHome()
        {
            InitializeComponent();
            Loaded += PageHome_Loaded;
        }

        private void PageHome_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new UserViewModel();
        }
    }
}
