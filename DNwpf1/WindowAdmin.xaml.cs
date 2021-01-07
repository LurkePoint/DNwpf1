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
using System.Windows.Shapes;

namespace DNwpf1
{
    /// <summary>
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
            MainAdmin.Navigate(new PageAdminMain());
        }


        private void Button_Click_AdminGlav(object sender, RoutedEventArgs e)
        {
            MainAdmin.Content = new PageAdminMain();
        }

       
        private void Button_Click_AdminPage1(object sender, RoutedEventArgs e)
        {
            MainAdmin.Content = new Page1Admin();
        }

        
        private void Button_Click_AdminPage2(object sender, RoutedEventArgs e)
        {
            MainAdmin.Content = new Page2Admin();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
