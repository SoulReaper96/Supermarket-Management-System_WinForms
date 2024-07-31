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
    public partial class Categories : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Supermarket_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Categories()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM CategoryTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Categories_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            CategoryId_tb.Text = string.Empty;
            CategoryName_tb.Text = string.Empty;
            CategoryDesc_tb.Text = string.Empty;
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
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTable VALUES('" + CategoryId_tb.Text + "','" + CategoryName_tb.Text + "','" + CategoryDesc_tb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully.");
                Con.Close();
                Clear();
                ShowData();
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
                SqlCommand cmd = new SqlCommand("UPDATE CategoryTable SET CategoryName = '" + CategoryName_tb.Text + "', CategoryDesc = '" + CategoryDesc_tb.Text + "' WHERE CategoryId = '" + CategoryId_tb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category edited successfully.");
                Con.Close();
                Clear();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (CategoryId_tb.Text == "")
            {
                MessageBox.Show("Enter a valid seller ID.");
            }
            else
            {
                Con.Open();
                string Query = "DELETE FROM CategoryTable WHERE CategoryId = '" + CategoryId_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully.");
                Con.Close();
                Clear();
                ShowData();
            }
        }

        private void Categories_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CategoryId_tb.Text = Categories_dgv.SelectedRows[0].Cells[0].Value.ToString();
                CategoryName_tb.Text = Categories_dgv.SelectedRows[0].Cells[1].Value.ToString();
                CategoryDesc_tb.Text = Categories_dgv.SelectedRows[0].Cells[2].Value.ToString();
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
