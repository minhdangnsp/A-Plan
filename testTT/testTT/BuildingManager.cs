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
    public class BuildingManager
    {
        private static BuildingManager instance;

        public static BuildingManager Instance
        {
            get { if (instance == null) instance = new BuildingManager(); return BuildingManager.instance; }
            private set { BuildingManager.instance = value; }
        }

        private BuildingManager() { }


        public bool checkbuilding(string BuildingName)
        {
            bool test = true;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from ToaNha";
            conn.Open();
            sqlcommand.Connection = conn;

            SqlDataReader reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {
                string temp = reader.GetString(0).Replace(" ", String.Empty);
                if (temp == BuildingName)
                {
                    test = false;
                }
            }
            reader.Close();
            conn.Close();
            return test;
        }

        public bool checkroom(string RoomName, string BuildingName)
        {
            bool testBuilding = false, testRoom = true;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;

            //Test xem có tồn tại tòa không
            sqlcommand.CommandText = "select * from ToaNha";
            conn.Open();
            sqlcommand.Connection = conn;

            SqlDataReader reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {
                string temp = reader.GetString(0).Replace(" ", String.Empty);
                if (temp == BuildingName)
                {
                    testBuilding = true;
                }
            }
            reader.Close();

            //Test xem có trùng phòng không
            sqlcommand.CommandText = "select * from Phong";
            sqlcommand.Connection = conn;

            SqlDataReader reader1 = sqlcommand.ExecuteReader();

            while (reader1.Read())
            {
                string temp = reader1.GetString(0).Replace(" ", String.Empty);
                if (temp == RoomName)
                {
                    testRoom = false;
                }
            }
            reader1.Close();
            conn.Close();
            if (testBuilding && testRoom)
                return true;
            return false;
        }

    }
}
