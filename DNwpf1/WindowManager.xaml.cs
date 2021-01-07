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
    /// Логика взаимодействия для WindowManager.xaml
    /// </summary>
    public partial class WindowManager : Window
    {
        public WindowManager()
        {
            InitializeComponent();
            MainManager.Navigate(new PageManagerMain());
        }

        private void Button_Click_ManagerGlav(object sender, RoutedEventArgs e)
        {
            MainManager.Content = new PageManagerMain();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
