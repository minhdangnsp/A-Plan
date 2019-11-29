using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace testTT
{
    public partial class MainForm : Form
    {

        int TogMove;
        int MValX;
        int MValY;
        string imgLo = "";
        Timer t = new Timer();
        public MainForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True");
        SqlCommand cmd;

        #region tab_button
        private void Home_btn_Click(object sender, EventArgs e)
        {
            panelPos.Height = Home_btn.Height - 5;
            panelPos.Top = Home_btn.Top + 2;
            Home_pnl.Visible = true;
            Event_pnl.Visible = false;
            About_Us_pnl.Visible = false;
            Student_pnl.Visible = false;
            Buidling_pnl.Visible = false;
            Statistics_pnl.Visible = false;

        }

        private void Event_btn_Click(object sender, EventArgs e)
        {
            panelPos.Height = Event_btn.Height - 5;
            panelPos.Top = Event_btn.Top + 2;
            Home_pnl.Visible = false;
            Event_pnl.Visible = true;
            About_Us_pnl.Visible = false;
            Student_pnl.Visible = false;
            Buidling_pnl.Visible = false;
            Statistics_pnl.Visible = false;
            Data_Table.Visible = true;
            Data_Table_Important.Visible = false;
            GoBack_pic.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;

        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            panelPos.Height = About_btn.Height - 5;
            panelPos.Top = About_btn.Top + 2;
            Home_pnl.Visible = false;
            Event_pnl.Visible = false;
            About_Us_pnl.Visible = true;
            Student_pnl.Visible = false;
            Buidling_pnl.Visible = false;
            Statistics_pnl.Visible = false;
            Answer_pnl.Visible = false;
        }

        private void Student_btn_Click(object sender, EventArgs e)
        {
            panelPos.Height = Student_btn.Height - 5;
            panelPos.Top = Student_btn.Top + 2;
            Home_pnl.Visible = false;
            Event_pnl.Visible = false;
            About_Us_pnl.Visible = false;
            Buidling_pnl.Visible = false;
            Student_pnl.Visible = true;
            Statistics_pnl.Visible = false;
            Student_Present_pnl.BringToFront();
            Student_Present_pnl.Visible = true;
            Student_In_Room_Back_Pic.Visible = false;
            

        }

        private void Statistics_btn_Click(object sender, EventArgs e)
        {
           
            panelPos.Height = Statistics_btn.Height - 5;
            panelPos.Top = Statistics_btn.Top + 2;
            Home_pnl.Visible = false;
            Event_pnl.Visible = false;
            About_Us_pnl.Visible = false;
            Student_pnl.Visible = false;
            Buidling_pnl.Visible = false;
            Statistics_pnl.Visible = true;

            Rooms_lb.Text = Statistic_Manager.Instance.Total_Room().ToString();
            Buildings_lb.Text = Statistic_Manager.Instance.Total_Building().ToString();
            Students_lb.Text = Statistic_Manager.Instance.Total_Student().ToString();
            Events_lb.Text = Statistic_Manager.Instance.Total_Event().ToString();

            Statistic_Present_pnl.Visible = true;
            GenderChart.Visible = false;
            Stat_Back_Pic.Visible = false;
            


        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            Home_btn_Click(sender, e);

            //Data_Table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 241, 246);
            Data_Table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Data_Table.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 246, 246);
            Data_Table.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 100, 100);
            Data_Table.BackgroundColor = Color.White;
            Data_Table.DefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70);
            Data_Table.EnableHeadersVisualStyles = false;
            Data_Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Data_Table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(254, 100, 100);
            Data_Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 72, 92);
            Data_Table.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Bold);
            Data_Table.RowTemplate.Height = 30;
            Data_Table.ColumnHeadersHeight = 30;
            // Font replacementFont = new Font(Roboto,9,Condensed Bold);


            //Data_Table.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 241, 246);
            Data_Table_Important.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Data_Table_Important.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 246, 246);
            Data_Table_Important.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 100, 100);
            Data_Table_Important.BackgroundColor = Color.White;
            Data_Table_Important.DefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70);
            Data_Table_Important.EnableHeadersVisualStyles = false;
            Data_Table_Important.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Data_Table_Important.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(254, 100, 100);
            Data_Table_Important.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 72, 92);
            Data_Table_Important.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Bold);
            Data_Table_Important.RowTemplate.Height = 30;
            Data_Table_Important.ColumnHeadersHeight = 30;



            Data_Table.DataSource = EventManager.Instance.GetTable();
            GoBack_pic.Visible = false;
            panel5.Visible = false;



            Student_List.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Student_List.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 246, 246);
            Student_List.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 100, 100);
            Student_List.BackgroundColor = Color.White;
            Student_List.DefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70);
            Student_List.EnableHeadersVisualStyles = false;
            Student_List.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Student_List.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(254, 100, 100);
            Student_List.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 72, 92);
            Student_List.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Bold);
            Student_List.RowTemplate.Height = 30;
            Student_List.ColumnHeadersHeight = 30;
            
            //Student_List.Columns[0].Width = 10;
            Student_List.DataSource = StudentManager.Instance.GetStudentTable();




            Student_In_Room.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Student_In_Room.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 246, 246);
            Student_In_Room.DefaultCellStyle.SelectionForeColor = Color.FromArgb(254, 100, 100);
            Student_In_Room.BackgroundColor = Color.White;
            Student_In_Room.DefaultCellStyle.ForeColor = Color.FromArgb(70, 70, 70);
            Student_In_Room.EnableHeadersVisualStyles = false;
            Student_In_Room.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Student_In_Room.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            // Data_Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(254, 100, 100);
            Student_In_Room.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 72, 92);
            Student_In_Room.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Bold);
            Student_In_Room.RowTemplate.Height = 30;
            Student_In_Room.ColumnHeadersHeight = 30;

            //========================================================

            t.Interval = 1000;  //in milliseconds
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            //Account_lb.Text = LoginForm.userName;

        }

       
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10) { time += "0" + hh;}
            else { time += hh; }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            Time_lb.Text = time;
        }

        #region ChartData
        //CHART========================================================

        private void LoadData()
        {
            GenderChart.DataSource = Statistic_Manager.Instance.getData("gender_chart");
            GenderChart.Series["Series1"].XValueMember = "Gender";
            GenderChart.Series["Series1"].YValueMembers = "Total";
            GenderChart.Titles[0].Visible = true;
            GenderChart.Titles[1].Visible = false;
            GenderChart.Titles[2].Visible = false;
            GenderChart.DataBind();
        }

        private void LoadDataBuidling()
        {
            GenderChart.DataSource = Statistic_Manager.Instance.getData("chart_building");
            GenderChart.Series["Series1"].XValueMember = "Building";
            GenderChart.Series["Series1"].YValueMembers = "Total";
            GenderChart.Titles[0].Visible = false;
            GenderChart.Titles[1].Visible = true;
            GenderChart.Titles[2].Visible = false;
            GenderChart.DataBind();
        }

        private void LoadAcademicYear()
        {
            GenderChart.DataSource = Statistic_Manager.Instance.getData("chart_AcademicYear");
            GenderChart.Series["Series1"].XValueMember = "Academic_Year";
            GenderChart.Series["Series1"].YValueMembers = "Total";
            GenderChart.Titles[0].Visible = false;
            GenderChart.Titles[1].Visible = false;
            GenderChart.Titles[2].Visible = true;
            GenderChart.DataBind();
        }
        //============================================================

        #endregion

        #region EventMangaer
        private void pictureBox4_Click(object sender, EventArgs e)
        {
         
            Data_Table.Visible = false;
            Data_Table_Important.Visible = true;
            Add_pic.Visible = false;
            Search_pic.Visible = false;
            Important_pic.Visible = false;
            GoBack_pic.Visible = true;
            panel5.Visible = false;

            Data_Table.DataSource = EventManager.Instance.GetTable();
            Data_Table_Important.DataSource = EventManager.Instance.GetTableImportant();
        }

        private void GoBack_pic_Click(object sender, EventArgs e)
        {
            Data_Table.Visible = true;
            Data_Table_Important.Visible = false;
            Add_pic.Visible = true;
            Search_pic.Visible = true;
            Important_pic.Visible = true;
            GoBack_pic.Visible = false;
        }

        private void txtEventName_Enter(object sender, EventArgs e)
        {
            if (txtEventName.Text == "Event's Name")
            {
                txtEventName.Text = string.Empty;
            }
        }

        private void txtEventName_Leave(object sender, EventArgs e)
        {
            if (txtEventName.Text == string.Empty)
            {
                txtEventName.Text = "Event's Name";
            }
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            
            if ((this.comboBox_Type.SelectedIndex > -1) && (this.comboBox_Time.SelectedIndex > -1) && (this.txtEventName.Text is string) )
            {
                string date = comboBox_Day.SelectedItem.ToString() + "/" + comboBox_Month.SelectedItem.ToString() + "/" + comboBox_Year.SelectedItem.ToString();
                string query = "INSERT INTO dbo.EventManager(Event_Name, Event_Type, Start_Time, Start_Day) VALUES('" + this.txtEventName.Text + "', '" + this.comboBox_Type.SelectedItem + "', '" + this.comboBox_Time.SelectedItem + "', '" + date + "')  ;";
                float f;
                EventManager.Instance.AddEvent(query);
                Data_Table.DataSource = EventManager.Instance.GetTable();
                Data_Table_Important.DataSource = EventManager.Instance.GetTableImportant();
                panel5.Visible = false;
            }
        }

        private void Add_pic_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void Searching_pic_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Data_Table.DataSource;
            bs.Filter = "Event_Name like '%" + Searching_txt.Text + "%'";
            Data_Table.DataSource = bs;
        }

        private void Searching_txt_Enter(object sender, EventArgs e)
        {
            if (Searching_txt.Text == "Type Your Search")
            {
                Searching_txt.Text = string.Empty;
            }
        }

        private void Searching_txt_Leave(object sender, EventArgs e)
        {
            if (Searching_txt.Text == string.Empty)
            {
                Searching_txt.Text = "Type Your Search";
            }
        }

        private void Search_pic_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            Data_Table.Visible = true;
            panel5.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e) // search_go_back
        {
            panel7.Visible = false;
            Data_Table.Visible = true;
            Data_Table_Important.Visible = false;
            Data_Table.DataSource = EventManager.Instance.GetTable();
        }
        #endregion

        #region StudentManager
        private void Search_Student_txt_Enter(object sender, EventArgs e)
        {

            Student_List.DataSource = StudentManager.Instance.GetStudentTable();
            if (Search_Student_txt.Text == "Type Student Name")
            {
                Search_Student_txt.Text = string.Empty;
            }
        }

        private void Search_Student_txt_Leave(object sender, EventArgs e)
        {
            if (Search_Student_txt.Text == string.Empty)
            {
                Search_Student_txt.Text = "Type Student Name";
            }
        }

        private void Student_Search_Pic_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Student_List.DataSource;
            bs.Filter = "Name like '%" + Search_Student_txt.Text + "%'";
            Student_List.DataSource = bs;
        }

        private void Student_Back_Pic_Click(object sender, EventArgs e)
        {
            
            Student_Present_pnl.Visible = true;
            Student_List_pnl.Visible = false;
            Add_Student_pnl.Visible = false;
            Student_Info_pnl.Visible = false;
        }

        private void Add_Student_btn_Click(object sender, EventArgs e)
        {
            Add_Student_pnl.Visible = true;
            Student_Present_pnl.Visible = false;
            Student_List_pnl.Visible = false;
            Student_Info_pnl.Visible = false;
        }

        private void Student_List_btn_Click(object sender, EventArgs e)
        {
            Student_List.DataSource = StudentManager.Instance.GetStudentTable();
            if (Search_Student_txt.Text != "Type Student Name")
            {
                Search_Student_txt.Text = "Type Student Name";
            }
            Student_Present_pnl.Visible = false;
            Student_List_pnl.Visible = true;
            Add_Student_pnl.Visible = false;
            Student_Info_pnl.Visible = false;
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|.png|jpg files(*.jpg)|.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLo = dialog.FileName.ToString();
                Student_PicBox.ImageLocation = imgLo;
            }
        }

        private void Save_Student_btn_Click(object sender, EventArgs e)
        {
            int test = StudentManager.Instance.CheckRoom(Room_txt.Text, Building_txt.Text);
            if (TenSinhVien_txt.Text != null && TenTruong_txt.Text != null && Room_txt.Text != null && ID_number_txt.Text != null && Building_txt.Text != null && GenderBox.SelectedIndex > -1 && AcademicYear_Box.SelectedIndex > -1  && test == 1 && Student_PicBox.ImageLocation != null)
            {
                byte[] images = null;
                FileStream Streem = new FileStream(imgLo, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);

                connection.Open();
                string query = "INSERT INTO dbo.Student(Name, University, Id_Number, Academic_Year, Gender, Room, Building, Picture) VALUES('" + this.TenSinhVien_txt.Text + "','" + this.TenTruong_txt.Text + "','" + this.ID_number_txt.Text + "','" + this.AcademicYear_Box.SelectedItem.ToString() + "','" + this.GenderBox.SelectedItem.ToString() + "','" + this.Room_txt.Text + "','" + this.Building_txt.Text + "', @images)";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();
                connection.Close();

                Student_List.DataSource = StudentManager.Instance.GetStudentTable();
                Student_Present_pnl.BringToFront();
                Student_Present_pnl.Visible = true;
            }

            else
            {
                MessageBox.Show("Error");
            }
        }

        private void TenSinhVien_txt_Enter(object sender, EventArgs e)
        {
            if (TenSinhVien_txt.Text == "Enter Student Name")
            {
                TenSinhVien_txt.Text = string.Empty;
            }
        }

        private void TenSinhVien_txt_Leave(object sender, EventArgs e)
        {
            if (TenSinhVien_txt.Text == string.Empty)
            {
                TenSinhVien_txt.Text = "Enter Student Name";
            }
        }

        private void TenTruong_txt_Enter(object sender, EventArgs e)
        {
            if (TenTruong_txt.Text == "Enter University Name")
            {
                TenTruong_txt.Text = string.Empty;
            }
        }

        private void TenTruong_txt_Leave(object sender, EventArgs e)
        {
            if (TenTruong_txt.Text == string.Empty)
            {
                TenTruong_txt.Text = "Enter University Name";
            }
        }

        private void ID_number_txt_Enter(object sender, EventArgs e)
        {
            if (ID_number_txt.Text == "ID_Number")
            {
                ID_number_txt.Text = string.Empty;
            }
        }

        private void ID_number_txt_Leave(object sender, EventArgs e)
        {
            if (ID_number_txt.Text == string.Empty)
            {
                ID_number_txt.Text = "ID_Number";
            }
        }

        private void Room_txt_Enter(object sender, EventArgs e)
        {
            if (Room_txt.Text == "Room")
            {
                Room_txt.Text = string.Empty;
            }
        }

        private void Room_txt_Leave(object sender, EventArgs e)
        {
            if (Room_txt.Text == string.Empty)
            {
                Room_txt.Text = "Room";
            }
        }

        private void Building_txt_Enter(object sender, EventArgs e)
        {
            if (Building_txt.Text == "Building")
            {
                Building_txt.Text = string.Empty;
            }
        }

        private void Building_txt_Leave(object sender, EventArgs e)
        {
            if (Building_txt.Text == string.Empty)
            {
                Building_txt.Text = "Building";
            }
        }

        private void Student_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Student_List.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (Student_List.CurrentCell != null && Student_List.CurrentCell.Value != null)
                {
                    connection.Open();
                    string query = "SELECT Name, University, Id_Number, Academic_Year, Gender, Room, Building,Picture FROM dbo.Student WHERE Name='" + this.Student_List.CurrentCell.Value.ToString() + "'";
                    cmd = new SqlCommand(query, connection);
                    SqlDataReader dataR = cmd.ExecuteReader();
                    dataR.Read();
                    if (dataR.HasRows)
                    {
                        Student_Name_lb.Text = dataR[0].ToString();
                        University_lb.Text = dataR[1].ToString();
                        ID_lb.Text = dataR[2].ToString();
                        Year_lb.Text = dataR[3].ToString();
                        Gender_lb.Text = dataR[4].ToString();
                        Room_lb.Text = dataR[5].ToString();
                        Building_lb.Text = dataR[6].ToString();

                        
                        byte[] images = ((byte[])dataR[7]);

                        if (images == null)
                        {
                            StudentPicture_Box.Image = null;
                        }
                        else
                        {
                            MemoryStream mstreem = new MemoryStream(images);
                            StudentPicture_Box.Image = Image.FromStream(mstreem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }

                    connection.Close();
                    Student_Info_pnl.BringToFront();
                    Student_Info_pnl.Visible = true;
                }
            }
        }

        private void Profile_Back_Pic_Click(object sender, EventArgs e)
        {
            Student_Present_pnl.Visible = false;
            Student_List_pnl.Visible = true;
            Add_Student_pnl.Visible = false;
            Student_Info_pnl.Visible = false;
        }

        private void Add_Back_Pic_Click(object sender, EventArgs e)
        {
            Student_Present_pnl.BringToFront();
            Student_Present_pnl.Visible = true;
           
        }
        #endregion

        //=============================================================================

        #region BuildingManager
        Label addLale(string str, int start, int end)
        {
            Label l = new Label();
            l.Name = str;
            l.Text = str;
            l.ForeColor = Color.White;
            l.BackColor = Color.Green;
            l.Font = new Font("Serif", 24, FontStyle.Bold);
            l.Width = 170;
            l.Height = 80;
            //l.Location = new Point(start, end);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(5);

            return l;
        }

        private void Building_btn_Click(object sender, EventArgs e)
        {
            Building_Present_pnl.Visible = true;
            Building_Present_pnl.BringToFront();
            panelPos.Height = Building_btn.Height - 5;
            panelPos.Top = Building_btn.Top + 2;
            Home_pnl.Visible = false;
            Event_pnl.Visible = false;
            About_Us_pnl.Visible = false;
            Student_pnl.Visible = false;
            Statistics_pnl.Visible = false;
            Student_Present_pnl.BringToFront();
            Student_Present_pnl.Visible = true;
            Buidling_pnl.Visible = true;
            Add_Edit_pnl.Visible = false;
            //===================================
            flowLayoutPanel1.Visible = true;           

            flowLayoutPanel1.Controls.Clear();

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from ToaNha";
            /*
            if (conn == null)
            {
                conn = new SqlConnection(strconnection);
                conn.Open();
            }*/
            connection.Open();
            sqlcommand.Connection = connection;

            SqlDataReader sqlReader = sqlcommand.ExecuteReader();

            while (sqlReader.Read())
            {
                Label l = addLale1(sqlReader.GetString(0));
                flowLayoutPanel1.Controls.Add(l);
                l.DoubleClick += new System.EventHandler(this.labelDoubleClick);

            }
            sqlReader.Close();
            connection.Close();
        }

        public Label addLale1(string str)
        {
            Label l = new Label();
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Name = str.Replace(" ", String.Empty);
            l.Text = str.Replace(" ", String.Empty);
            l.ForeColor = Color.DimGray;
            l.BackColor = Color.White;
            l.BorderStyle = BorderStyle.None;
            
            l.Font = new Font("Roboto", 15, FontStyle.Regular);
            l.Width = 97;
            l.Height = 97;
           // l.AutoSize = false;
            l.Margin = new Padding(6);

            return l;
        }

        void labelDoubleClick(object sender, EventArgs e)
        {
            /*
            Label currentLabel = (Label)sender;
            string a = sender.ToString();
            string[] b = a.Split(':');
            String c = b[1];
            MessageBox.Show("dang"+b[1]);
            */
            Label b = sender as Label;
            HienThiDsPhong(flowLayoutPanel1, b.Name.ToString());
        }

        public void HienThiDsPhong(FlowLayoutPanel flpnl, string str)
        {
            flpnl.Controls.Clear();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = System.Data.CommandType.Text;
            sqlcommand.CommandText = "select * from Phong where TenToa=@tentoa";

            connection.Open();
            sqlcommand.Connection = connection;

            SqlParameter parToa = new SqlParameter("@tentoa", SqlDbType.NVarChar);
            parToa.Value = str;
            sqlcommand.Parameters.Add(parToa);


            SqlDataReader sqlReader = sqlcommand.ExecuteReader();
            while (sqlReader.Read())
            {
                Label l = addLale1(sqlReader.GetString(0));
                flpnl.Controls.Add(l);
                l.DoubleClick += new System.EventHandler(this.labelDoubleClickPhong);

            }
            sqlReader.Close();
            connection.Close();
        }

        void labelDoubleClickPhong(object sender, EventArgs e)
        {
            Label l = sender as Label;
            //MessageBox.Show("Cửa số mởi");
            pnlDisplayRoom.Visible = true;
            Student_In_Room.DataSource = StudentManager.Instance.GetStudentTable2();
            BindingSource bsr = new BindingSource();
            bsr.DataSource = Student_In_Room.DataSource;
            bsr.Filter = "Room like '%" + l.Text.Replace(" ", String.Empty) + "%'";
            Student_In_Room.DataSource = bsr;

            connection.Open();

            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.CommandType = CommandType.Text;


            sqlcommand.CommandText = "select * from Phong where TenPhong= '"+l.Text+"'";
            sqlcommand.Connection = connection;

            SqlDataReader reader = sqlcommand.ExecuteReader();
            if(reader.Read())
            {
                Buliding_Number_lb.Text = reader.GetString(1).Replace(" ",String.Empty);
                Room_Number_lb.Text = reader.GetString(0).Replace(" ", String.Empty);
            }
            reader.Close();

            connection.Close();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            Buidling_Control_pnl.Visible = true;
            Building_Present_pnl.Visible = false;
            pnlDisplayRoom.Visible = false;
        }

        private void Student_In_Room_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student_pnl.Visible = true;
            Buidling_pnl.Visible = false;
            Student_List_btn_Click(sender, e);

            if (Student_In_Room.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (Student_In_Room.CurrentCell != null && Student_In_Room.CurrentCell.Value != null)
                {
                    connection.Open();
                    string query = "SELECT Name, University, Id_Number, Academic_Year, Gender, Room, Building,Picture FROM dbo.Student WHERE Name='" + this.Student_In_Room.CurrentCell.Value.ToString() + "'";
                    cmd = new SqlCommand(query, connection);
                    SqlDataReader dataR = cmd.ExecuteReader();
                    dataR.Read();
                    if (dataR.HasRows)
                    {
                        Student_Name_lb.Text = dataR[0].ToString();
                        University_lb.Text = dataR[1].ToString();
                        ID_lb.Text = dataR[2].ToString();
                        Year_lb.Text = dataR[3].ToString();
                        Gender_lb.Text = dataR[4].ToString();
                        Room_lb.Text = dataR[5].ToString();
                        Building_lb.Text = dataR[6].ToString();


                        byte[] images = ((byte[])dataR[7]);

                        if (images == null)
                        {
                            StudentPicture_Box.Image = null;
                        }
                        else
                        {
                            MemoryStream mstreem = new MemoryStream(images);
                            StudentPicture_Box.Image = Image.FromStream(mstreem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }

                    connection.Close();
                    Student_Info_pnl.BringToFront();
                    Student_Info_pnl.Visible = true;
                    Profile_Back_Pic.Visible = false;
                    Student_In_Room_Back_Pic.Visible = true;
                }
            }

        }

        private void Student_In_Room_Back_Pic_Click(object sender, EventArgs e)
        {
            Student_Info_pnl.Visible = false;
            Student_pnl.Visible = false;
            Buidling_pnl.Visible = true;
            pnlDisplayRoom.Visible = true;
            Profile_Back_Pic.Visible = true;
        }

        private void Add_Building_Back_Click(object sender, EventArgs e)
        {
            Building_btn_Click(sender, e);
            Building_Name_txt.Clear();
            Room_Name_txt.Clear();
            From_Building_txt.Clear();
        }

        private void Add_Building_btn_Click(object sender, EventArgs e)
        {
            if ((Building_Name_txt.Text.ToString() != null) && BuildingManager.Instance.checkbuilding(Building_Name_txt.Text.ToString()))
            {
                string query = "INSERT INTO dbo.ToaNha(TenToa) VALUES ('" + Building_Name_txt.Text.ToString() + "')";
                DataProvider.Instance.ExecuteNonQuery(query);
                Add_Building_Back_Click(sender, e);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Add_Edit_pnl.BringToFront();
            Add_Edit_pnl.Visible = true;
        }

        private void Add_Room_btn_Click(object sender, EventArgs e)
        {
            string N1 = Room_Name_txt.Text.ToString();
            string N2 = From_Building_txt.Text.ToString();
            if ((N1 != null) && (N2 != null) && (BuildingManager.Instance.checkroom(N1, N2)))
            {
                string query = "INSERT INTO dbo.Phong(TenPhong, TenToa) VALUES ('" + N1 + "','" + N2 + "')";
                DataProvider.Instance.ExecuteNonQuery(query);
                Add_Building_Back_Click(sender, e);
            }
        }
        #endregion
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Statistics
        private void Stat_Back_Pic_Click(object sender, EventArgs e)
        {
            Statistic_Present_pnl.Visible = true;
            GenderChart.Visible = false;
            Stat_Back_Pic.Visible = false;

        }

        private void Gender_Pic_btn_Click(object sender, EventArgs e)
        {
            Statistic_Present_pnl.Visible = false;
            GenderChart.Visible = true;
            Stat_Back_Pic.Visible = true;

            LoadData();
            //LoadDataBuidling();
            //LoadAcademicYear();
        }

        private void Year_Pic_btn_Click(object sender, EventArgs e)
        {
            Statistic_Present_pnl.Visible = false;
            GenderChart.Visible = true;
            Stat_Back_Pic.Visible = true;

            //LoadData();
            //LoadDataBuidling();
            LoadAcademicYear();
        }

        private void Building_Pic_btn_Click(object sender, EventArgs e)
        {
            Statistic_Present_pnl.Visible = false;
            GenderChart.Visible = true;
            Stat_Back_Pic.Visible = true;

            //LoadData();
            LoadDataBuidling();
            //LoadAcademicYear();
        }
        #endregion

        #region About_Us
        private void Q1_lb_Click(object sender, EventArgs e)
        {
            Answer_pnl.Visible = true;
            Question_lb.Text = "1. What is A - Plan ?"; 
            Answer_lb.Text = "A - Plan is a application helps you get just about everything \nmanaged. A smart, easy-to-use app that allows you to track, \ncategorize and control things in your dormitory, create \nbenefits for you as a manager.";
        }

        private void Q2_lb_Click(object sender, EventArgs e)
        {
            Answer_pnl.Visible = true;
            Question_lb.Text = "2. How to use this app ?";
            Answer_lb.Text = "Easy, here's a few things you need to know:\nYou can choose the suitable tab for your purpose.\n \n+Event: Focus on your all of your Events. Always keep track! \n+Statistics: Control your things with diagram. Just try it! \n+Students: Showing information of stundents in your dormitory. \n+Building: Know your block of buildings, rooms & and students.";
        }

        private void Q3_lb_Click(object sender, EventArgs e)
        {
            Answer_pnl.Visible = true;
            Question_lb.Text = "What is A - Plan's benefit ?";
            Answer_lb.Text = "By using this app, you can:\n \n1) Control your information anytime from anywhere \n2) Securely store all your information \n3) Managing things with awesome diagram \n4) And so on, find out for your self !";

        }

        private void Q4_lb_Click(object sender, EventArgs e)
        {
            Answer_pnl.Visible = true;
            Question_lb.Text = "Why does A - Plan only have a few features ?";
            Answer_lb.Text = "A - Plan is still in Beta test, everything will be \nreleased soon. \n \nYou can try out our beta features to see if you enjoy it.";
        }

        private void Q5_lb_Click(object sender, EventArgs e)
        {
            Answer_pnl.Visible = true;
            Question_lb.Text = "Is this software completely done ? ";
            Answer_lb.Text = "No, it is not. This is our Beta test, all the functions \nwill be update soon and we'll release other new features \nsoon in the future.";
            
        }

        private void About_Back_Pic_Click(object sender, EventArgs e)
        {
            Answer_pnl.Visible = false;
            Question_lb.Text = string.Empty;
            Answer_lb.Text = string.Empty;
        }

        #endregion     

        #region HOME
        private void Stat_pnl_Click(object sender, EventArgs e)
        {
            Statistics_btn_Click(sender, e);
        }

        private void Stat_Pic_Click(object sender, EventArgs e)
        {
            Statistics_btn_Click(sender, e);
        }

        private void Eve_Pic_Click(object sender, EventArgs e)
        {
            Event_btn_Click(sender, e);
        }

        private void Room_and_Bui_Pic_Click(object sender, EventArgs e)
        {
            Building_btn_Click(sender, e);
        }

        private void Log_Out_lb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Move_Tool
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        #endregion
    }

}
