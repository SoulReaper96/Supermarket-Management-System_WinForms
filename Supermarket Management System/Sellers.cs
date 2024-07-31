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
    public partial class Sellers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Supermarket_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Sellers()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM SellerTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Sellers_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            SellerId_tb.Text = string.Empty;
            SellerName_tb.Text = string.Empty;
            SellerAge_tb.Text = string.Empty;
            SellerPhone_tb.Text = string.Empty;
            SellerPass_tb.Text = string.Empty;
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SellerTable VALUES('" + SellerId_tb.Text + "','" + SellerName_tb.Text + "','" + SellerAge_tb.Text + "','" + SellerPhone_tb.Text + "','" + SellerPass_tb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SellerTable SET SellerName = '" + SellerName_tb.Text + "', SellerAge = '" + SellerAge_tb.Text + "', SellerPhone = '" + SellerPhone_tb.Text + "', SellerPass = '" + SellerPass_tb.Text + "' WHERE SellerId = '" + SellerId_tb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller info updated successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (SellerId_tb.Text == "")
            {
                MessageBox.Show("Enter a valid seller ID.");
            }
            else
            {
                Con.Open();
                string Query = "DELETE FROM SellerTable where SellerId = '" + SellerId_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller deleted successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
        }

        private void Sellers_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SellerId_tb.Text = Sellers_dgv.SelectedRows[0].Cells[0].Value.ToString();
                SellerName_tb.Text = Sellers_dgv.SelectedRows[0].Cells[1].Value.ToString();
                SellerAge_tb.Text = Sellers_dgv.SelectedRows[0].Cells[2].Value.ToString();
                SellerPhone_tb.Text = Sellers_dgv.SelectedRows[0].Cells[3].Value.ToString();
                SellerPass_tb.Text = Sellers_dgv.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        private void Categories_btn_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }

        private void Mainmenu_btn_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            mainmenu.Show();
            this.Hide();
        }
    }
}
