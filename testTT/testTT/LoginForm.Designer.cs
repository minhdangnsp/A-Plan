namespace testTT
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.ChangePW_lb = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Exit_lb = new System.Windows.Forms.Label();
            this.ChangePW_pnl = new System.Windows.Forms.Panel();
            this.OldUserName_txt = new System.Windows.Forms.TextBox();
            this.Return_lb = new System.Windows.Forms.Label();
            this.Change_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OldPW_txt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewUserName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ChangePW_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testTT.Properties.Resources.nen;
            this.pictureBox1.Location = new System.Drawing.Point(-47, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(59, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(34, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1);
            this.panel1.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(34, 136);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 18);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "UserName";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(34, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 1);
            this.panel2.TabIndex = 2;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.txtPassWord.ForeColor = System.Drawing.Color.Gray;
            this.txtPassWord.Location = new System.Drawing.Point(34, 195);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(227, 18);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Text = "PassWord";
            this.txtPassWord.Enter += new System.EventHandler(this.txtPassWord_Enter);
            this.txtPassWord.Leave += new System.EventHandler(this.txtPassWord_Leave);
            // 
            // ChangePW_lb
            // 
            this.ChangePW_lb.AutoSize = true;
            this.ChangePW_lb.BackColor = System.Drawing.Color.White;
            this.ChangePW_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePW_lb.Font = new System.Drawing.Font("Roboto Condensed", 8F);
            this.ChangePW_lb.ForeColor = System.Drawing.Color.Gray;
            this.ChangePW_lb.Location = new System.Drawing.Point(72, 309);
            this.ChangePW_lb.Name = "ChangePW_lb";
            this.ChangePW_lb.Size = new System.Drawing.Size(134, 18);
            this.ChangePW_lb.TabIndex = 4;
            this.ChangePW_lb.Text = "Change The PassWord";
            this.ChangePW_lb.Click += new System.EventHandler(this.ChangePW_lb_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Location = new System.Drawing.Point(83, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Exit_lb
            // 
            this.Exit_lb.AutoSize = true;
            this.Exit_lb.BackColor = System.Drawing.Color.White;
            this.Exit_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Exit_lb.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Exit_lb.Location = new System.Drawing.Point(9, 4);
            this.Exit_lb.Name = "Exit_lb";
            this.Exit_lb.Size = new System.Drawing.Size(20, 24);
            this.Exit_lb.TabIndex = 6;
            this.Exit_lb.Text = "x";
            this.Exit_lb.Click += new System.EventHandler(this.Exit_lb_Click);
            // 
            // ChangePW_pnl
            // 
            this.ChangePW_pnl.BackColor = System.Drawing.SystemColors.Window;
            this.ChangePW_pnl.Controls.Add(this.OldUserName_txt);
            this.ChangePW_pnl.Controls.Add(this.Return_lb);
            this.ChangePW_pnl.Controls.Add(this.Change_btn);
            this.ChangePW_pnl.Controls.Add(this.panel5);
            this.ChangePW_pnl.Controls.Add(this.textBox3);
            this.ChangePW_pnl.Controls.Add(this.panel4);
            this.ChangePW_pnl.Controls.Add(this.OldPW_txt);
            this.ChangePW_pnl.Controls.Add(this.panel6);
            this.ChangePW_pnl.Controls.Add(this.panel3);
            this.ChangePW_pnl.Controls.Add(this.NewUserName_txt);
            this.ChangePW_pnl.Controls.Add(this.label2);
            this.ChangePW_pnl.Location = new System.Drawing.Point(25, 12);
            this.ChangePW_pnl.Name = "ChangePW_pnl";
            this.ChangePW_pnl.Size = new System.Drawing.Size(273, 340);
            this.ChangePW_pnl.TabIndex = 7;
            // 
            // OldUserName_txt
            // 
            this.OldUserName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldUserName_txt.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.OldUserName_txt.ForeColor = System.Drawing.Color.Gray;
            this.OldUserName_txt.Location = new System.Drawing.Point(20, 75);
            this.OldUserName_txt.Name = "OldUserName_txt";
            this.OldUserName_txt.Size = new System.Drawing.Size(227, 18);
            this.OldUserName_txt.TabIndex = 7;
            this.OldUserName_txt.Text = "Old UserName";
            this.OldUserName_txt.Enter += new System.EventHandler(this.OldUserName_txt_Enter);
            this.OldUserName_txt.Leave += new System.EventHandler(this.OldUserName_txt_Leave);
            // 
            // Return_lb
            // 
            this.Return_lb.AutoSize = true;
            this.Return_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_lb.Font = new System.Drawing.Font("Roboto Condensed", 8F);
            this.Return_lb.ForeColor = System.Drawing.Color.Gray;
            this.Return_lb.Location = new System.Drawing.Point(92, 317);
            this.Return_lb.Name = "Return_lb";
            this.Return_lb.Size = new System.Drawing.Size(78, 18);
            this.Return_lb.TabIndex = 6;
            this.Return_lb.Text = "Return Login";
            this.Return_lb.Click += new System.EventHandler(this.Return_lb_Click);
            // 
            // Change_btn
            // 
            this.Change_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Change_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Change_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_btn.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Change_btn.Location = new System.Drawing.Point(76, 279);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(114, 28);
            this.Change_btn.TabIndex = 5;
            this.Change_btn.Text = "Change";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(20, 256);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 1);
            this.panel5.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(20, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 18);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "New PassWord";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(20, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 1);
            this.panel4.TabIndex = 4;
            // 
            // OldPW_txt
            // 
            this.OldPW_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldPW_txt.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.OldPW_txt.ForeColor = System.Drawing.Color.Gray;
            this.OldPW_txt.Location = new System.Drawing.Point(20, 179);
            this.OldPW_txt.Name = "OldPW_txt";
            this.OldPW_txt.Size = new System.Drawing.Size(227, 18);
            this.OldPW_txt.TabIndex = 3;
            this.OldPW_txt.Text = "Old PassWord";
            this.OldPW_txt.Enter += new System.EventHandler(this.OldPW_txt_Enter);
            this.OldPW_txt.Leave += new System.EventHandler(this.OldPW_txt_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(20, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 1);
            this.panel6.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(20, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 1);
            this.panel3.TabIndex = 4;
            // 
            // NewUserName_txt
            // 
            this.NewUserName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewUserName_txt.Font = new System.Drawing.Font("Roboto", 8.5F);
            this.NewUserName_txt.ForeColor = System.Drawing.Color.Gray;
            this.NewUserName_txt.Location = new System.Drawing.Point(20, 127);
            this.NewUserName_txt.Name = "NewUserName_txt";
            this.NewUserName_txt.Size = new System.Drawing.Size(227, 18);
            this.NewUserName_txt.TabIndex = 3;
            this.NewUserName_txt.Text = "New UserName";
            this.NewUserName_txt.Enter += new System.EventHandler(this.NewUserName_txt_Enter);
            this.NewUserName_txt.Leave += new System.EventHandler(this.NewUserName_txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change PassWord";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 369);
            this.Controls.Add(this.Exit_lb);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ChangePW_lb);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChangePW_pnl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ChangePW_pnl.ResumeLayout(false);
            this.ChangePW_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label ChangePW_lb;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Exit_lb;
        private System.Windows.Forms.Panel ChangePW_pnl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox OldPW_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NewUserName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Return_lb;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox OldUserName_txt;
    }
}

