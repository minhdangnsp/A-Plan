using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTT
{
    public class EventManager
    {
        private static EventManager instance;

        public static EventManager Instance
        {
            get { if (instance == null) instance = new EventManager(); return EventManager.instance; }
            private set { EventManager.instance = value; }
        }

        private EventManager() { }

        public DataTable GetTable()
        {
            DataTable data_table_1;
            string query = "SELECT * FROM dbo.EventManager";
            data_table_1 = DataProvider.Instance.GetDataTable(query);
            return data_table_1;
        }

        public DataTable GetTableImportant()
        {
            DataTable data_table_1;
            string query = "SELECT * FROM dbo.EventManager WHERE Event_Type = 'Important'";
            data_table_1 = DataProvider.Instance.GetDataTable(query);
            return data_table_1;
        }

        public void AddEvent(string query)
        { 
                DataProvider.Instance.Control_Data(query);
            
        }
    }
}
