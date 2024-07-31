namespace Supermarket_Management_System
{
    partial class Sales
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
            components = new System.ComponentModel.Container();
            Mainmenu_btn = new Button();
            BillingId_tb = new TextBox();
            ProdName_tb = new TextBox();
            ProdQty_tb = new TextBox();
            Refresh_btn = new Button();
            Invoice_dgv = new DataGridView();
            Delete_btn = new Button();
            Print_btn = new Button();
            Brands_btn = new Button();
            Categories_btn = new Button();
            Sellers_btn = new Button();
            Add_btn = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            Close_lbl = new Label();
            panel1 = new Panel();
            label4 = new Label();
            SalesList_dgv = new DataGridView();
            TotalAmount_lbl = new Label();
            Amount_lbl = new Label();
            Seller_lbl = new Label();
            TimeVw_lbl = new Label();
            AddProduct_btn = new Button();
            DateVw_lbl = new Label();
            ProdCat_cmb = new ComboBox();
            Products_dgv = new DataGridView();
            ProdPrice_tb = new TextBox();
            label7 = new Label();
            Update_btn = new Button();
            DateTime_tmr = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Invoice_dgv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesList_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).BeginInit();
            SuspendLayout();
            // 
            // Mainmenu_btn
            // 
            Mainmenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            Mainmenu_btn.FlatStyle = FlatStyle.Flat;
            Mainmenu_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mainmenu_btn.Location = new Point(12, 149);
            Mainmenu_btn.Name = "Mainmenu_btn";
            Mainmenu_btn.Size = new Size(132, 30);
            Mainmenu_btn.TabIndex = 18;
            Mainmenu_btn.Text = "MAIN MENU";
            Mainmenu_btn.UseVisualStyleBackColor = false;
            Mainmenu_btn.Click += Mainmenu_btn_Click;
            // 
            // BillingId_tb
            // 
            BillingId_tb.Location = new Point(111, 53);
            BillingId_tb.Name = "BillingId_tb";
            BillingId_tb.Size = new Size(175, 25);
            BillingId_tb.TabIndex = 31;
            // 
            // ProdName_tb
            // 
            ProdName_tb.Location = new Point(111, 84);
            ProdName_tb.Name = "ProdName_tb";
            ProdName_tb.Size = new Size(175, 25);
            ProdName_tb.TabIndex = 30;
            // 
            // ProdQty_tb
            // 
            ProdQty_tb.Location = new Point(111, 146);
            ProdQty_tb.Name = "ProdQty_tb";
            ProdQty_tb.Size = new Size(175, 25);
            ProdQty_tb.TabIndex = 29;
            // 
            // Refresh_btn
            // 
            Refresh_btn.BackColor = Color.FromArgb(255, 192, 128);
            Refresh_btn.FlatStyle = FlatStyle.Flat;
            Refresh_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            Refresh_btn.Location = new Point(255, 213);
            Refresh_btn.Name = "Refresh_btn";
            Refresh_btn.Size = new Size(63, 25);
            Refresh_btn.TabIndex = 27;
            Refresh_btn.Text = "REFRESH";
            Refresh_btn.TextAlign = ContentAlignment.BottomCenter;
            Refresh_btn.UseVisualStyleBackColor = false;
            Refresh_btn.Click += Refresh_btn_Click;
            // 
            // Invoice_dgv
            // 
            Invoice_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Invoice_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Invoice_dgv.BackgroundColor = Color.White;
            Invoice_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Invoice_dgv.Location = new Point(353, 68);
            Invoice_dgv.Name = "Invoice_dgv";
            Invoice_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Invoice_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Invoice_dgv.Size = new Size(481, 170);
            Invoice_dgv.TabIndex = 25;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.FromArgb(255, 192, 128);
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_btn.Location = new Point(654, 475);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(90, 30);
            Delete_btn.TabIndex = 24;
            Delete_btn.Text = "DELETE";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Print_btn
            // 
            Print_btn.BackColor = Color.FromArgb(255, 192, 128);
            Print_btn.FlatStyle = FlatStyle.Flat;
            Print_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Print_btn.Location = new Point(558, 475);
            Print_btn.Name = "Print_btn";
            Print_btn.Size = new Size(90, 30);
            Print_btn.TabIndex = 23;
            Print_btn.Text = "PRINT";
            Print_btn.UseVisualStyleBackColor = false;
            Print_btn.Click += Print_btn_Click;
            // 
            // Brands_btn
            // 
            Brands_btn.BackColor = Color.FromArgb(255, 192, 128);
            Brands_btn.FlatStyle = FlatStyle.Flat;
            Brands_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Brands_btn.Location = new Point(12, 113);
            Brands_btn.Name = "Brands_btn";
            Brands_btn.Size = new Size(132, 30);
            Brands_btn.TabIndex = 16;
            Brands_btn.Text = "BRANDS";
            Brands_btn.UseVisualStyleBackColor = false;
            Brands_btn.Click += Brands_btn_Click;
            // 
            // Categories_btn
            // 
            Categories_btn.BackColor = Color.FromArgb(255, 192, 128);
            Categories_btn.FlatStyle = FlatStyle.Flat;
            Categories_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Categories_btn.Location = new Point(12, 41);
            Categories_btn.Name = "Categories_btn";
            Categories_btn.Size = new Size(132, 30);
            Categories_btn.TabIndex = 15;
            Categories_btn.Text = "CATEGORIES";
            Categories_btn.UseVisualStyleBackColor = false;
            Categories_btn.Click += Categories_btn_Click;
            // 
            // Sellers_btn
            // 
            Sellers_btn.BackColor = Color.FromArgb(255, 192, 128);
            Sellers_btn.FlatStyle = FlatStyle.Flat;
            Sellers_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sellers_btn.Location = new Point(12, 77);
            Sellers_btn.Name = "Sellers_btn";
            Sellers_btn.Size = new Size(132, 30);
            Sellers_btn.TabIndex = 14;
            Sellers_btn.Text = "SELLERS";
            Sellers_btn.UseVisualStyleBackColor = false;
            Sellers_btn.Click += Sellers_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.FromArgb(255, 192, 128);
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.Location = new Point(462, 475);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(90, 30);
            Add_btn.TabIndex = 12;
            Add_btn.Text = "ADD";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 150);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 17;
            label3.Text = "QUANTITY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 88);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 15;
            label1.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 13;
            label2.Text = "BILLING ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(324, 6);
            label6.Name = "label6";
            label6.Size = new Size(207, 29);
            label6.TabIndex = 12;
            label6.Text = "MANAGE SALES";
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Close_lbl.Location = new Point(975, 11);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 17;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SalesList_dgv);
            panel1.Controls.Add(TotalAmount_lbl);
            panel1.Controls.Add(Amount_lbl);
            panel1.Controls.Add(Seller_lbl);
            panel1.Controls.Add(TimeVw_lbl);
            panel1.Controls.Add(AddProduct_btn);
            panel1.Controls.Add(DateVw_lbl);
            panel1.Controls.Add(ProdCat_cmb);
            panel1.Controls.Add(Products_dgv);
            panel1.Controls.Add(ProdPrice_tb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Update_btn);
            panel1.Controls.Add(BillingId_tb);
            panel1.Controls.Add(ProdName_tb);
            panel1.Controls.Add(ProdQty_tb);
            panel1.Controls.Add(Refresh_btn);
            panel1.Controls.Add(Invoice_dgv);
            panel1.Controls.Add(Delete_btn);
            panel1.Controls.Add(Print_btn);
            panel1.Controls.Add(Add_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(150, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 517);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(526, 284);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 45;
            label4.Text = "SALES LIST";
            // 
            // SalesList_dgv
            // 
            SalesList_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesList_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            SalesList_dgv.BackgroundColor = Color.White;
            SalesList_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesList_dgv.Location = new Point(353, 309);
            SalesList_dgv.Name = "SalesList_dgv";
            SalesList_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            SalesList_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalesList_dgv.Size = new Size(481, 160);
            SalesList_dgv.TabIndex = 44;
            SalesList_dgv.CellContentClick += SalesList_dgv_CellContentClick;
            // 
            // TotalAmount_lbl
            // 
            TotalAmount_lbl.AutoSize = true;
            TotalAmount_lbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            TotalAmount_lbl.ForeColor = Color.Black;
            TotalAmount_lbl.Location = new Point(596, 244);
            TotalAmount_lbl.Name = "TotalAmount_lbl";
            TotalAmount_lbl.Size = new Size(40, 19);
            TotalAmount_lbl.TabIndex = 43;
            TotalAmount_lbl.Text = "0.00";
            // 
            // Amount_lbl
            // 
            Amount_lbl.AutoSize = true;
            Amount_lbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            Amount_lbl.ForeColor = Color.Black;
            Amount_lbl.Location = new Point(486, 244);
            Amount_lbl.Name = "Amount_lbl";
            Amount_lbl.Size = new Size(104, 19);
            Amount_lbl.TabIndex = 42;
            Amount_lbl.Text = "AMOUNT - R";
            // 
            // Seller_lbl
            // 
            Seller_lbl.AutoSize = true;
            Seller_lbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            Seller_lbl.ForeColor = Color.Black;
            Seller_lbl.Location = new Point(28, 6);
            Seller_lbl.Name = "Seller_lbl";
            Seller_lbl.Size = new Size(74, 19);
            Seller_lbl.TabIndex = 41;
            Seller_lbl.Text = "SELLER";
            // 
            // TimeVw_lbl
            // 
            TimeVw_lbl.AutoSize = true;
            TimeVw_lbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            TimeVw_lbl.ForeColor = Color.Black;
            TimeVw_lbl.Location = new Point(671, 36);
            TimeVw_lbl.Name = "TimeVw_lbl";
            TimeVw_lbl.Size = new Size(47, 19);
            TimeVw_lbl.TabIndex = 40;
            TimeVw_lbl.Text = "TIME";
            // 
            // AddProduct_btn
            // 
            AddProduct_btn.BackColor = Color.FromArgb(255, 192, 128);
            AddProduct_btn.FlatStyle = FlatStyle.Flat;
            AddProduct_btn.Font = new Font("Arial", 9F);
            AddProduct_btn.Location = new Point(111, 177);
            AddProduct_btn.Name = "AddProduct_btn";
            AddProduct_btn.Size = new Size(112, 30);
            AddProduct_btn.TabIndex = 39;
            AddProduct_btn.Text = "ADD PRODUCT";
            AddProduct_btn.UseVisualStyleBackColor = false;
            AddProduct_btn.Click += AddProduct_btn_Click;
            // 
            // DateVw_lbl
            // 
            DateVw_lbl.AutoSize = true;
            DateVw_lbl.Font = new Font("Arial", 12F, FontStyle.Bold);
            DateVw_lbl.ForeColor = Color.Black;
            DateVw_lbl.Location = new Point(671, 6);
            DateVw_lbl.Name = "DateVw_lbl";
            DateVw_lbl.Size = new Size(52, 19);
            DateVw_lbl.TabIndex = 38;
            DateVw_lbl.Text = "DATE";
            // 
            // ProdCat_cmb
            // 
            ProdCat_cmb.ForeColor = Color.FromArgb(255, 192, 128);
            ProdCat_cmb.FormattingEnabled = true;
            ProdCat_cmb.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            ProdCat_cmb.Location = new Point(11, 213);
            ProdCat_cmb.Name = "ProdCat_cmb";
            ProdCat_cmb.Size = new Size(169, 25);
            ProdCat_cmb.TabIndex = 37;
            ProdCat_cmb.Text = "SELECT CATEGORY";
            ProdCat_cmb.SelectionChangeCommitted += ProdCat_cmb_SelectionChangeCommitted;
            // 
            // Products_dgv
            // 
            Products_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Products_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Products_dgv.BackgroundColor = Color.White;
            Products_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Products_dgv.Location = new Point(11, 244);
            Products_dgv.Name = "Products_dgv";
            Products_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Products_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Products_dgv.Size = new Size(307, 261);
            Products_dgv.TabIndex = 36;
            Products_dgv.CellContentClick += Products_dgv_CellContentClick;
            // 
            // ProdPrice_tb
            // 
            ProdPrice_tb.Location = new Point(111, 115);
            ProdPrice_tb.Name = "ProdPrice_tb";
            ProdPrice_tb.Size = new Size(175, 25);
            ProdPrice_tb.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(2, 119);
            label7.Name = "label7";
            label7.Size = new Size(49, 16);
            label7.TabIndex = 34;
            label7.Text = "PRICE";
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.FromArgb(255, 192, 128);
            Update_btn.FlatStyle = FlatStyle.Flat;
            Update_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            Update_btn.Location = new Point(186, 213);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(63, 25);
            Update_btn.TabIndex = 33;
            Update_btn.Text = "UPDATE";
            Update_btn.TextAlign = ContentAlignment.BottomCenter;
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // DateTime_tmr
            // 
            DateTime_tmr.Tick += DateTime_tmr_Tick;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 570);
            Controls.Add(Mainmenu_btn);
            Controls.Add(Brands_btn);
            Controls.Add(Categories_btn);
            Controls.Add(Sellers_btn);
            Controls.Add(Close_lbl);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            ((System.ComponentModel.ISupportInitialize)Invoice_dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalesList_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Mainmenu_btn;
        private TextBox BillingId_tb;
        private TextBox ProdName_tb;
        private TextBox ProdQty_tb;
        private Button Refresh_btn;
        private DataGridView Invoice_dgv;
        private Button Delete_btn;
        private Button Print_btn;
        private Button Brands_btn;
        private Button Categories_btn;
        private Button Sellers_btn;
        private Button Add_btn;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label Close_lbl;
        private Panel panel1;
        private TextBox ProdPrice_tb;
        private Label label7;
        private Button Update_btn;
        private DataGridView Products_dgv;
        private ComboBox ProdCat_cmb;
        private Label DateVw_lbl;
        private Button AddProduct_btn;
        private Label TimeVw_lbl;
        private Label Seller_lbl;
        private Label TotalAmount_lbl;
        private Label Amount_lbl;
        private System.Windows.Forms.Timer DateTime_tmr;
        private Label label4;
        private DataGridView SalesList_dgv;
    }
}