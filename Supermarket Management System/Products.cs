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
    public partial class Products : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Supermarket_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Products()
        {
            InitializeComponent();
            ShowData();
            FillCategory();
        }

        private void ShowData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM ProductTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Products_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            ProdId_tb.Text = string.Empty;
            ProdName_tb.Text = string.Empty;
            ProdQty_tb.Text = string.Empty;
            ProdPrice_tb.Text = string.Empty;
        }

        private void FillCategory()
        {
            string Query = "SELECT * FROM CategoryTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                ProdCat_cmb.ValueMember = "CategoryName";
                ProdCat_cmb.DataSource = dt;
                ProdCat1_cmb.ValueMember = "CategoryName";
                ProdCat1_cmb.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilterByCategory()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM ProductTable WHERE ProdCat = '" + ProdCat1_cmb.SelectedIndex.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Products_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductTable VALUES('" + ProdId_tb.Text + "','" + ProdName_tb.Text + "','" + ProdQty_tb.Text + "','" + ProdPrice_tb.Text + "','" + ProdCat_cmb.SelectedIndex.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
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
                SqlCommand cmd = new SqlCommand("UPDATE ProductTable SET ProdName = '" + ProdName_tb.Text + "', ProdQty = '" + ProdQty_tb.Text + "', ProdPrice = '" + ProdPrice_tb.Text + "', ProdCat = '" + ProdCat_cmb.SelectedIndex.ToString() + "' WHERE ProdId = '" + ProdId_tb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product info updated successfully.");
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
            if (ProdId_tb.Text == "")
            {
                MessageBox.Show("Enter a valid Product ID.");
            }
            else
            {
                Con.Open();
                string Query = "DELETE FROM ProductTable WHERE ProdId = '" + ProdId_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void Products_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProdId_tb.Text = Products_dgv.SelectedRows[0].Cells[0].Value.ToString();
                ProdName_tb.Text = Products_dgv.SelectedRows[0].Cells[1].Value.ToString();
                ProdQty_tb.Text = Products_dgv.SelectedRows[0].Cells[2].Value.ToString();
                ProdPrice_tb.Text = Products_dgv.SelectedRows[0].Cells[3].Value.ToString();
                ProdCat_cmb.SelectedValue = Products_dgv.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Categories_btn_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }

        private void Sellers_btn_Click(object sender, EventArgs e)
        {
            Sellers sellers = new Sellers();
            sellers.Show();
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
