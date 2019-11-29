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
    public class StudentManager
    {
        private static StudentManager instance;

        public static StudentManager Instance
        {
            get { if (instance == null) instance = new StudentManager(); return StudentManager.instance; }
            private set { StudentManager.instance = value; }
        }

        private StudentManager() { }

        public DataTable GetStudentTable()
        {
            DataTable data_table_1;
            string query = "SELECT id,Name,Id_Number,University,Gender FROM dbo.Student";
            data_table_1 = DataProvider.Instance.GetDataTable(query);
            return data_table_1;
        }
        
        public int CheckRoom(string room, string building)
        {
            int test = 0, test1 = 0;
            string query = "SELECT TenToa FROM Phong";
            DataTable data = DataProvider.Instance.GetDataTable(query);
           
            int row = data.Rows.Count;
            for( int i =0; i< row; i++)
            {
                string aa = (data.Rows[i][0].ToString()).Replace(" ", String.Empty);
                if (building == aa)
                {
                    test = 1;  
                }
              
            }
           

            string query1 = "SELECT TenPhong FROM Phong";
            DataTable data1 = DataProvider.Instance.GetDataTable(query1);
            int row1 = data1.Rows.Count;

            for (int i = 0; i < row1; i++)
            {
                if ( room == (data1.Rows[i][0].ToString().Replace(" ", String.Empty)))
                {
                    test1 = 1;            
                }
               
            }
           

            if (test == 1 && test1 == 1)
                return 1;
            return 0;
        }

        public DataTable GetStudentTable2()
        {
            DataTable data_table_1;
            string query = "SELECT id,Name,Id_Number,University,Gender,Room FROM dbo.Student";
            data_table_1 = DataProvider.Instance.GetDataTable(query);
            return data_table_1;
        }

    }
}
