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
    /// Логика взаимодействия для WindowBuhgalter.xaml
    /// </summary>
    public partial class WindowBuhgalter : Window
    {
        public WindowBuhgalter()
        {
            InitializeComponent();
            MainBuh.Navigate(new PageBuhgalterMain());
        }

        

       
        

        private void Button_Click_BuhGlav(object sender, RoutedEventArgs e)
        {
            MainBuh.Content = new PageBuhgalterMain();
        }

        
        private void Button_Click_Buh1(object sender, RoutedEventArgs e)
        {
            MainBuh.Content = new Page1Buhgalter();
        }

        private void Button_Click_Buh2(object sender, RoutedEventArgs e)
        {
            MainBuh.Content = new Page2Buhgalter();
        }

        

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
