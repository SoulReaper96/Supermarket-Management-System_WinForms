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
    public partial class Sales : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\Supermarket_db.mdf;Integrated Security=True;Connect Timeout=30");

        private DataTable OrderTable;
        private int Num = 0;
        private int Flag = 0;
        private int Stock = 0;
        private decimal Uprice = 10.95m;
        private string Product = "Sample Product";

        public Sales()
        {
            InitializeComponent();
            InitializeOrderTable();
            ShowProductsData();
            ShowBillsData();
            FillCategory();
        }

        private void InitializeOrderTable()
        {
            OrderTable = new DataTable("OrderTable");

            // Define columns
            OrderTable.Columns.Add("ItemNumber", typeof(int));
            OrderTable.Columns.Add("Product", typeof(string));
            OrderTable.Columns.Add("Quantity", typeof(int));
            OrderTable.Columns.Add("UnitPrice", typeof(decimal));
            OrderTable.Columns.Add("TotalPrice", typeof(decimal));
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            DateTime_tmr.Start();
        }

        private void ShowProductsData()
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

        private void ShowBillsData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM BillTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SalesList_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                string Query = "SELECT * FROM ProductTable WHERE ProdCat = '" + ProdCat_cmb.SelectedIndex.ToString() + "'";
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

        private void UpdateProduct()
        {
            int ID = Convert.ToInt32(Products_dgv.SelectedRows[0].Cells[0].Value.ToString());
            int NewQty = Stock - Convert.ToInt32(ProdQty_tb.Text);
            if (NewQty < 0)
            {
                MessageBox.Show("There is no available stock. Operation failed.");
            }
            else
            {
                Con.Open();
                string Query = "UPDATE ProductTable SET ProdQty = " + NewQty + " WHERE ProdId = " + ID + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                ShowProductsData();
            }
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
            DateTime_tmr.Stop();
        }

        private void DateTime_tmr_Tick(object sender, EventArgs e)
        {
            DateVw_lbl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            TimeVw_lbl.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            if (ProdQty_tb.Text == string.Empty)
            {
                MessageBox.Show("Enter the quantity of products.");
            }
            else if (Flag == 0)
            {
                MessageBox.Show("Select the product.");
            }
            else if (Convert.ToInt32(ProdQty_tb.Text) > Stock)
            {
                MessageBox.Show("Not enough available stock.");
            }
            else
            {
                Num = Num + 1;
                int Quantity;
                try
                {
                    Quantity = Convert.ToInt32(ProdQty_tb.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid number for quantity.");
                    return;
                }

                decimal Totalprice = Quantity * Uprice;
                OrderTable.Rows.Add(Num, Product, Quantity, Uprice, Totalprice);
                Invoice_dgv.DataSource = OrderTable;
                Invoice_dgv.Refresh();
                TotalAmount_lbl.Text = Totalprice.ToString();
                Flag = 0;
                UpdateProduct();
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ShowProductsData();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BillTable VALUES('" + BillingId_tb.Text + "','" + Seller_lbl.Text + "','" + DateVw_lbl.Text + "','" + TimeVw_lbl.Text + "','" + TotalAmount_lbl.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully.");
                Con.Close();
                ShowBillsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void Products_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProdName_tb.Text = Products_dgv.SelectedRows[0].Cells[1].Value.ToString();
                Product = Products_dgv.SelectedRows[0].Cells[1].Value.ToString();
                ProdPrice_tb.Text = Products_dgv.SelectedRows[0].Cells[3].Value.ToString();
                Uprice = Convert.ToInt32(Products_dgv.SelectedRows[0].Cells[3].Value.ToString());
                Stock = Convert.ToInt32(Products_dgv.SelectedRows[0].Cells[2].Value.ToString());
                Flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalesList_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProdCat_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM ProductTable WHERE ProdCat = '" + ProdCat_cmb.SelectedIndex.ToString() + "'";
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

        private void Brands_btn_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.Show();
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
