namespace Supermarket_Management_System
{
    partial class Products
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
            Update_btn = new Button();
            ProdPrice_tb = new TextBox();
            ProdId_tb = new TextBox();
            ProdName_tb = new TextBox();
            ProdQty_tb = new TextBox();
            Refresh_btn = new Button();
            ProdCat1_cmb = new ComboBox();
            Products_dgv = new DataGridView();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            ProdCat_cmb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            Sellers_btn = new Button();
            Categories_btn = new Button();
            Brands_btn = new Button();
            Close_lbl = new Label();
            Mainmenu_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(Update_btn);
            panel1.Controls.Add(ProdPrice_tb);
            panel1.Controls.Add(ProdId_tb);
            panel1.Controls.Add(ProdName_tb);
            panel1.Controls.Add(ProdQty_tb);
            panel1.Controls.Add(Refresh_btn);
            panel1.Controls.Add(ProdCat1_cmb);
            panel1.Controls.Add(Products_dgv);
            panel1.Controls.Add(Delete_btn);
            panel1.Controls.Add(Edit_btn);
            panel1.Controls.Add(Add_btn);
            panel1.Controls.Add(ProdCat_cmb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(150, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 459);
            panel1.TabIndex = 0;
            // 
            // Update_btn
            // 
            Update_btn.BackColor = Color.FromArgb(255, 192, 128);
            Update_btn.FlatStyle = FlatStyle.Flat;
            Update_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            Update_btn.Location = new Point(694, 15);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(63, 25);
            Update_btn.TabIndex = 33;
            Update_btn.Text = "UPDATE";
            Update_btn.TextAlign = ContentAlignment.BottomCenter;
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // ProdPrice_tb
            // 
            ProdPrice_tb.Location = new Point(111, 161);
            ProdPrice_tb.Name = "ProdPrice_tb";
            ProdPrice_tb.Size = new Size(175, 25);
            ProdPrice_tb.TabIndex = 32;
            // 
            // ProdId_tb
            // 
            ProdId_tb.Location = new Point(111, 53);
            ProdId_tb.Name = "ProdId_tb";
            ProdId_tb.Size = new Size(175, 25);
            ProdId_tb.TabIndex = 31;
            // 
            // ProdName_tb
            // 
            ProdName_tb.Location = new Point(111, 89);
            ProdName_tb.Name = "ProdName_tb";
            ProdName_tb.Size = new Size(175, 25);
            ProdName_tb.TabIndex = 30;
            // 
            // ProdQty_tb
            // 
            ProdQty_tb.Location = new Point(111, 125);
            ProdQty_tb.Name = "ProdQty_tb";
            ProdQty_tb.Size = new Size(175, 25);
            ProdQty_tb.TabIndex = 29;
            // 
            // Refresh_btn
            // 
            Refresh_btn.BackColor = Color.FromArgb(255, 192, 128);
            Refresh_btn.FlatStyle = FlatStyle.Flat;
            Refresh_btn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            Refresh_btn.Location = new Point(763, 15);
            Refresh_btn.Name = "Refresh_btn";
            Refresh_btn.Size = new Size(63, 25);
            Refresh_btn.TabIndex = 27;
            Refresh_btn.Text = "REFRESH";
            Refresh_btn.TextAlign = ContentAlignment.BottomCenter;
            Refresh_btn.UseVisualStyleBackColor = false;
            Refresh_btn.Click += Refresh_btn_Click;
            // 
            // ProdCat1_cmb
            // 
            ProdCat1_cmb.ForeColor = Color.FromArgb(255, 192, 128);
            ProdCat1_cmb.FormattingEnabled = true;
            ProdCat1_cmb.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            ProdCat1_cmb.Location = new Point(519, 15);
            ProdCat1_cmb.Name = "ProdCat1_cmb";
            ProdCat1_cmb.Size = new Size(169, 25);
            ProdCat1_cmb.TabIndex = 26;
            ProdCat1_cmb.Text = "SELECT CATEGORY";
            // 
            // Products_dgv
            // 
            Products_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Products_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Products_dgv.BackgroundColor = Color.White;
            Products_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Products_dgv.Location = new Point(298, 46);
            Products_dgv.Name = "Products_dgv";
            Products_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Products_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Products_dgv.Size = new Size(535, 398);
            Products_dgv.TabIndex = 25;
            Products_dgv.CellContentClick += Products_dgv_CellContentClick;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.FromArgb(255, 192, 128);
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_btn.Location = new Point(195, 234);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(90, 30);
            Delete_btn.TabIndex = 24;
            Delete_btn.Text = "DELETE";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.FromArgb(255, 192, 128);
            Edit_btn.FlatStyle = FlatStyle.Flat;
            Edit_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_btn.Location = new Point(99, 234);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(90, 30);
            Edit_btn.TabIndex = 23;
            Edit_btn.Text = "EDIT";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.FromArgb(255, 192, 128);
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.Location = new Point(3, 234);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(90, 30);
            Add_btn.TabIndex = 12;
            Add_btn.Text = "ADD";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // ProdCat_cmb
            // 
            ProdCat_cmb.ForeColor = Color.FromArgb(255, 192, 128);
            ProdCat_cmb.FormattingEnabled = true;
            ProdCat_cmb.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            ProdCat_cmb.Location = new Point(111, 192);
            ProdCat_cmb.Name = "ProdCat_cmb";
            ProdCat_cmb.Size = new Size(169, 25);
            ProdCat_cmb.TabIndex = 22;
            ProdCat_cmb.Text = "SELECT CATEGORY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 196);
            label5.Name = "label5";
            label5.Size = new Size(83, 16);
            label5.TabIndex = 21;
            label5.Text = "CATEGORY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 165);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 19;
            label4.Text = "PRICE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 129);
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
            label1.Location = new Point(3, 93);
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
            label2.Size = new Size(21, 16);
            label2.TabIndex = 13;
            label2.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(253, 1);
            label6.Name = "label6";
            label6.Size = new Size(260, 29);
            label6.TabIndex = 12;
            label6.Text = "MANAGE PRODUCTS";
            // 
            // Sellers_btn
            // 
            Sellers_btn.BackColor = Color.FromArgb(255, 192, 128);
            Sellers_btn.FlatStyle = FlatStyle.Flat;
            Sellers_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sellers_btn.Location = new Point(12, 75);
            Sellers_btn.Name = "Sellers_btn";
            Sellers_btn.Size = new Size(132, 30);
            Sellers_btn.TabIndex = 8;
            Sellers_btn.Text = "SELLERS";
            Sellers_btn.UseVisualStyleBackColor = false;
            Sellers_btn.Click += Sellers_btn_Click;
            // 
            // Categories_btn
            // 
            Categories_btn.BackColor = Color.FromArgb(255, 192, 128);
            Categories_btn.FlatStyle = FlatStyle.Flat;
            Categories_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Categories_btn.Location = new Point(12, 39);
            Categories_btn.Name = "Categories_btn";
            Categories_btn.Size = new Size(132, 30);
            Categories_btn.TabIndex = 9;
            Categories_btn.Text = "CATEGORIES";
            Categories_btn.UseVisualStyleBackColor = false;
            Categories_btn.Click += Categories_btn_Click;
            // 
            // Brands_btn
            // 
            Brands_btn.BackColor = Color.FromArgb(255, 192, 128);
            Brands_btn.FlatStyle = FlatStyle.Flat;
            Brands_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Brands_btn.Location = new Point(12, 111);
            Brands_btn.Name = "Brands_btn";
            Brands_btn.Size = new Size(132, 30);
            Brands_btn.TabIndex = 10;
            Brands_btn.Text = "BRANDS";
            Brands_btn.UseVisualStyleBackColor = false;
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Close_lbl.Location = new Point(975, 9);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 11;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // Mainmenu_btn
            // 
            Mainmenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            Mainmenu_btn.FlatStyle = FlatStyle.Flat;
            Mainmenu_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mainmenu_btn.Location = new Point(12, 147);
            Mainmenu_btn.Name = "Mainmenu_btn";
            Mainmenu_btn.Size = new Size(132, 30);
            Mainmenu_btn.TabIndex = 12;
            Mainmenu_btn.Text = "MAIN MENU";
            Mainmenu_btn.UseVisualStyleBackColor = false;
            Mainmenu_btn.Click += Mainmenu_btn_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1007, 510);
            Controls.Add(Mainmenu_btn);
            Controls.Add(Close_lbl);
            Controls.Add(Brands_btn);
            Controls.Add(Categories_btn);
            Controls.Add(Sellers_btn);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Sellers_btn;
        private Button Categories_btn;
        private Button Brands_btn;
        private Label Close_lbl;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox ProdCat_cmb;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private DataGridView Products_dgv;
        private Button Refresh_btn;
        private ComboBox ProdCat1_cmb;
        private TextBox ProdId_tb;
        private TextBox ProdName_tb;
        private TextBox ProdQty_tb;
        private TextBox ProdPrice_tb;
        private Button Update_btn;
        private Button Mainmenu_btn;
    }
}