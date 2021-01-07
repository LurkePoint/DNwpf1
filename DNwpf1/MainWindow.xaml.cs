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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            MainAvt.Navigate(new PageAvtMain(this));

           
        }

        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DN_wpf1;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

       
        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
