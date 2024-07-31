using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void Close_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProdMenu_btn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        private void BrandMenu_btn_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.Show();
            this.Hide();
        }

        private void CatMenu_btn_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }

        private void SellersMenu_btn_Click(object sender, EventArgs e)
        {
            Sellers sellers = new Sellers();
            sellers.Show();
            this.Hide();
        }

        private void LogoutMenu_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
