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
using System.Data.SqlClient;
using System.Data;

namespace DNwpf1
{
    /// <summary>
    /// Логика взаимодействия для PageAvtMain.xaml
    /// </summary>
    public partial class PageAvtMain : Page
    {
        public MainWindow mainWindow;
        public PageAvtMain(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void Button_Click_Avt(object sender, RoutedEventArgs e)
        {
            DataTable dt_user = mainWindow.Select("SELECT * FROM [dbo].[Users] WHERE [login] = '" + login.Text + "' AND [password] = '" + password.Password + "'");
            DataTable dt_id = mainWindow.Select("SELECT * FROM [dbo].[Users]");
            
            string idAdmin = dt_id.Rows[0][0] + "";
            string idManager = dt_id.Rows[1][0] + "";
            string idBuhgalter = dt_id.Rows[2][0] + "";

            if (dt_user.Rows.Count > 0)
            {

                if (login.Text == dt_id.Rows[0][1] + "" && idAdmin == "1")
                {
                    Button_Click_Admin();
                } 
                else
                if (login.Text == dt_id.Rows[1][1] + "" && idManager == "2")
                {
                    Button_Click_Manager();
                } 
                else
                if (login.Text == dt_id.Rows[2][1] + "" && idBuhgalter == "3")
                {
                    Button_Click_Buh();
                }
                else
                {
                    MessageBox.Show("Что-то введено некорректно");
                }
                

            } else
            {
                MessageBox.Show("Что-то введено некорректно");
            }
        }
        private void Button_Click_Admin()
        {
            WindowAdmin windowAdmin = new WindowAdmin();
            windowAdmin.ShowDialog();
        }
        private void Button_Click_Buh()
        {
            WindowBuhgalter windowBuhgalter= new WindowBuhgalter();
            windowBuhgalter.ShowDialog();
        }
        private void Button_Click_Manager()
        {
            WindowManager windowManager = new WindowManager();
            windowManager.ShowDialog();
        }
    }
}
