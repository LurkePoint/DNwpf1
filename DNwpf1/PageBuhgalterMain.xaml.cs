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
using System.Data;
using System.Data.SqlClient;

namespace DNwpf1
{
    /// <summary>
    /// Логика взаимодействия для PageBuhgalterMain.xaml
    /// </summary>
    public partial class PageBuhgalterMain : Page
    {
        public PageBuhgalterMain()
        {
            InitializeComponent();
            DataTable dt_user = Select("SELECT * FROM [dbo].[users]"); // получаем данные из таблицы

            nameLastnameBuhgalter.Text = dt_user.Rows[2][3] + " " + dt_user.Rows[2][4] + ", Вы находитесь на главной странице.";
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
    }
}
