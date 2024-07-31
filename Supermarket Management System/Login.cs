using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Supermarket_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
            Password_tb.UseSystemPasswordChar = true;
            ShowPass_chk.Checked = false;
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM SellerTable WHERE SellerName = '" + Username_tb.Text + "' AND SellerPass = '" + Password_tb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Mainmenu mainMenu = new Mainmenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }

        private void Clear_lbl_Click(object sender, EventArgs e)
        {
            Username_tb.Text = string.Empty;
            Password_tb.Text = string.Empty;
        }

        private void ShowPass_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass_chk.Checked == false)
            {
                Password_tb.UseSystemPasswordChar = true;
            }
            else
            {
                Password_tb.UseSystemPasswordChar = false;
            }
        }
    }
}
