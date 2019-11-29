using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace testTT
{
    public partial class LoginForm : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            this.ActiveControl = label1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Text = string.Empty;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                txtUserName.Text = "UserName";
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "PassWord")
            {
                txtPassWord.PasswordChar = '*';

                txtPassWord.Text = string.Empty;
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (txtPassWord.Text == string.Empty)
            {
                txtPassWord.PasswordChar = '\0';

                txtPassWord.Text = "PassWord";
            }
        }

        public static string userName;
        public string passWord;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            passWord = txtPassWord.Text;
            txtUserName.Clear();
            txtPassWord.Clear();
            if (Login(userName, passWord))
            {
                MainForm f = new MainForm();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
        bool Login(string userName, string passWord)
        {
            return DataProvider.Instance.Login(userName, passWord);
        }

        public void Change(string userName, string passWord)
        {
            string query = "DELETE FROM dbo.Account";
            DataProvider.Instance.Control_Data(query);
            string query1 = "INSERT INTO dbo.Account(UserName , DisplayName , PassWord , Type)  VALUES ( N'" + userName + "' , N'" + userName + "' , N'" + passWord + "', 1 )";
            DataProvider.Instance.Control_Data(query1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Exit_lb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePW_lb_Click(object sender, EventArgs e)
        {
            ChangePW_pnl.BringToFront();
            ChangePW_pnl.Visible = true;
        }

        private void NewUserName_txt_Enter(object sender, EventArgs e)
        {
            if (NewUserName_txt.Text == "New UserName")
            {
                NewUserName_txt.Text = string.Empty;
            }
        }

        private void NewUserName_txt_Leave(object sender, EventArgs e)
        {
            if (NewUserName_txt.Text == string.Empty)
            {
                NewUserName_txt.Text = "New UserName";
            }
        }

        private void OldPW_txt_Enter(object sender, EventArgs e)
        {
            if (OldPW_txt.Text == "Old PassWord")
            {
                OldPW_txt.PasswordChar = '*';

                OldPW_txt.Text = string.Empty;
            }
        }

        private void OldPW_txt_Leave(object sender, EventArgs e)
        {
            if (OldPW_txt.Text == string.Empty)
            {
                OldPW_txt.PasswordChar = '\0';

                OldPW_txt.Text = "Old PassWord";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "New PassWord")
            {
                textBox3.PasswordChar = '*';

                textBox3.Text = string.Empty;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.PasswordChar = '\0';

                textBox3.Text = "New PassWord";
            }
        }

        private void Return_lb_Click(object sender, EventArgs e)
        {
            ChangePW_pnl.SendToBack();
            ChangePW_pnl.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Return_lb_Click(sender, e);
        }

        private void OldUserName_txt_Enter(object sender, EventArgs e)
        {
            if (OldUserName_txt.Text == "Old UserName")
            {
                OldUserName_txt.Text = string.Empty;
            }
        }

        private void OldUserName_txt_Leave(object sender, EventArgs e)
        {
            if (OldUserName_txt.Text == string.Empty)
            {
                OldUserName_txt.Text = "Old UserName";
            }
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {   
            string P1 = OldUserName_txt.Text;
            string P2 = OldPW_txt.Text;
            string P3 = NewUserName_txt.Text;
            string P4 = textBox3.Text;
            if ((P1 != null) && (P2 != null) && (P3 != null) && (P4 != null))
            {
                if (Login(P1, P2))
                {
                    Change(P3, P4);
                    Return_lb_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

