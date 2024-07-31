namespace Supermarket_Management_System
{
    partial class Login
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Login_cmb = new ComboBox();
            Login_btn = new Button();
            Clear_lbl = new Label();
            Close_lbl = new Label();
            Username_tb = new TextBox();
            Password_tb = new TextBox();
            ShowPass_chk = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 250);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(48, 101);
            label7.Name = "label7";
            label7.Size = new Size(116, 19);
            label7.TabIndex = 11;
            label7.Text = "APPLICATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 82);
            label6.Name = "label6";
            label6.Size = new Size(135, 19);
            label6.TabIndex = 10;
            label6.Text = "SUPERMARKET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 63);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 9;
            label5.Text = "WELCOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 128);
            label1.Location = new Point(362, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(206, 111);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(206, 147);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // Login_cmb
            // 
            Login_cmb.ForeColor = Color.FromArgb(255, 192, 128);
            Login_cmb.FormattingEnabled = true;
            Login_cmb.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            Login_cmb.Location = new Point(329, 59);
            Login_cmb.Name = "Login_cmb";
            Login_cmb.Size = new Size(135, 23);
            Login_cmb.TabIndex = 6;
            Login_cmb.Text = "SELECT ROLE";
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.FromArgb(255, 192, 128);
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.Location = new Point(362, 197);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(75, 23);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "LOGIN";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // Clear_lbl
            // 
            Clear_lbl.AutoSize = true;
            Clear_lbl.Font = new Font("Arial", 10F, FontStyle.Underline);
            Clear_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Clear_lbl.Location = new Point(378, 223);
            Clear_lbl.Name = "Clear_lbl";
            Clear_lbl.Size = new Size(41, 16);
            Clear_lbl.TabIndex = 8;
            Clear_lbl.Text = "Clear";
            Clear_lbl.Click += Clear_lbl_Click;
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Close_lbl.Location = new Point(548, 9);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 9;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // Username_tb
            // 
            Username_tb.Font = new Font("Arial", 11F);
            Username_tb.Location = new Point(314, 109);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new Size(175, 24);
            Username_tb.TabIndex = 32;
            // 
            // Password_tb
            // 
            Password_tb.Font = new Font("Arial", 11F);
            Password_tb.Location = new Point(314, 145);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(175, 24);
            Password_tb.TabIndex = 33;
            // 
            // ShowPass_chk
            // 
            ShowPass_chk.AutoSize = true;
            ShowPass_chk.Font = new Font("Arial", 7F);
            ShowPass_chk.ForeColor = Color.FromArgb(255, 192, 128);
            ShowPass_chk.Location = new Point(450, 175);
            ShowPass_chk.Name = "ShowPass_chk";
            ShowPass_chk.Size = new Size(118, 17);
            ShowPass_chk.TabIndex = 34;
            ShowPass_chk.Text = "SHOW PASSWORD";
            ShowPass_chk.UseVisualStyleBackColor = true;
            ShowPass_chk.CheckedChanged += ShowPass_chk_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(580, 250);
            Controls.Add(ShowPass_chk);
            Controls.Add(Password_tb);
            Controls.Add(Username_tb);
            Controls.Add(Close_lbl);
            Controls.Add(Clear_lbl);
            Controls.Add(Login_btn);
            Controls.Add(Login_cmb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox Login_cmb;
        private Button Login_btn;
        private Label Clear_lbl;
        private Label Close_lbl;
        private TextBox Username_tb;
        private TextBox Password_tb;
        private CheckBox ShowPass_chk;
    }
}