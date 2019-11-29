using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testTT
{
    public class Statistic_Manager
    {
        private static Statistic_Manager instance; // Ctrl + R + E

        public static Statistic_Manager Instance
        {
            get { if (instance == null) instance = new Statistic_Manager(); return Statistic_Manager.instance; }
            private set { Statistic_Manager.instance = value; }
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        
        public DataTable getData(string query)
        {
            DataTable dtChartData = new DataTable();

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);

            // SqlCommand cmd = new SqlCommand("usp_chart", connection);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            dtChartData.Load(reader);

            connection.Close();

            return dtChartData;

        }

        public int Total_Student()
        {   
            string query = "SELECT * FROM dbo.Student";
            DataTable table = DataProvider.Instance.GetDataTable(query);
            int total = table.Rows.Count;
            return total;
        }

        public int Total_Event()
        {
            string query = "SELECT * FROM dbo.EventManager";
            DataTable table = DataProvider.Instance.GetDataTable(query);
            int total = table.Rows.Count;
            return total;
        }

        public int Total_Building()
        {
            string query = "SELECT * FROM dbo.ToaNha";
            DataTable table = DataProvider.Instance.GetDataTable(query);
            int total = table.Rows.Count;
            return total;
        }

        public int Total_Room()
        {
            string query = "SELECT * FROM dbo.Phong";
            DataTable table = DataProvider.Instance.GetDataTable(query);
            int total = table.Rows.Count;
            return total;
        }
    }
}
