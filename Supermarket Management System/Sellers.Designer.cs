namespace Supermarket_Management_System
{
    partial class Sellers
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
            Close_lbl = new Label();
            Brands_btn = new Button();
            Categories_btn = new Button();
            Products_btn = new Button();
            panel1 = new Panel();
            Sellers_dgv = new DataGridView();
            SellerId_tb = new TextBox();
            SellerPass_tb = new TextBox();
            SellerName_tb = new TextBox();
            SellerAge_tb = new TextBox();
            SellerPhone_tb = new TextBox();
            label5 = new Label();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            Mainmenu_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Sellers_dgv).BeginInit();
            SuspendLayout();
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Close_lbl.Location = new Point(975, 11);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 21;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // Brands_btn
            // 
            Brands_btn.BackColor = Color.FromArgb(255, 192, 128);
            Brands_btn.FlatStyle = FlatStyle.Flat;
            Brands_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Brands_btn.Location = new Point(12, 113);
            Brands_btn.Name = "Brands_btn";
            Brands_btn.Size = new Size(132, 30);
            Brands_btn.TabIndex = 20;
            Brands_btn.Text = "BRANDS";
            Brands_btn.UseVisualStyleBackColor = false;
            // 
            // Categories_btn
            // 
            Categories_btn.BackColor = Color.FromArgb(255, 192, 128);
            Categories_btn.FlatStyle = FlatStyle.Flat;
            Categories_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Categories_btn.Location = new Point(12, 77);
            Categories_btn.Name = "Categories_btn";
            Categories_btn.Size = new Size(132, 30);
            Categories_btn.TabIndex = 19;
            Categories_btn.Text = "CATEGORIES";
            Categories_btn.UseVisualStyleBackColor = false;
            Categories_btn.Click += Categories_btn_Click;
            // 
            // Products_btn
            // 
            Products_btn.BackColor = Color.FromArgb(255, 192, 128);
            Products_btn.FlatStyle = FlatStyle.Flat;
            Products_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Products_btn.Location = new Point(12, 41);
            Products_btn.Name = "Products_btn";
            Products_btn.Size = new Size(132, 30);
            Products_btn.TabIndex = 18;
            Products_btn.Text = "PRODUCTS";
            Products_btn.UseVisualStyleBackColor = false;
            Products_btn.Click += Products_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(Sellers_dgv);
            panel1.Controls.Add(SellerId_tb);
            panel1.Controls.Add(SellerPass_tb);
            panel1.Controls.Add(SellerName_tb);
            panel1.Controls.Add(SellerAge_tb);
            panel1.Controls.Add(SellerPhone_tb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Delete_btn);
            panel1.Controls.Add(Edit_btn);
            panel1.Controls.Add(Add_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(150, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 459);
            panel1.TabIndex = 17;
            // 
            // Sellers_dgv
            // 
            Sellers_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Sellers_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Sellers_dgv.BackgroundColor = Color.White;
            Sellers_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Sellers_dgv.Location = new Point(291, 53);
            Sellers_dgv.Name = "Sellers_dgv";
            Sellers_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Sellers_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Sellers_dgv.Size = new Size(535, 398);
            Sellers_dgv.TabIndex = 38;
            // 
            // SellerId_tb
            // 
            SellerId_tb.Location = new Point(110, 53);
            SellerId_tb.Name = "SellerId_tb";
            SellerId_tb.Size = new Size(175, 25);
            SellerId_tb.TabIndex = 37;
            // 
            // SellerPass_tb
            // 
            SellerPass_tb.Location = new Point(110, 197);
            SellerPass_tb.Name = "SellerPass_tb";
            SellerPass_tb.Size = new Size(175, 25);
            SellerPass_tb.TabIndex = 36;
            // 
            // SellerName_tb
            // 
            SellerName_tb.Location = new Point(110, 89);
            SellerName_tb.Name = "SellerName_tb";
            SellerName_tb.Size = new Size(175, 25);
            SellerName_tb.TabIndex = 35;
            // 
            // SellerAge_tb
            // 
            SellerAge_tb.Location = new Point(110, 125);
            SellerAge_tb.Name = "SellerAge_tb";
            SellerAge_tb.Size = new Size(175, 25);
            SellerAge_tb.TabIndex = 34;
            // 
            // SellerPhone_tb
            // 
            SellerPhone_tb.Location = new Point(110, 161);
            SellerPhone_tb.Name = "SellerPhone_tb";
            SellerPhone_tb.Size = new Size(175, 25);
            SellerPhone_tb.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 26;
            label5.Text = "PASSWORD";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 165);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 19;
            label4.Text = "PHONE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(36, 16);
            label3.TabIndex = 17;
            label3.Text = "AGE";
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
            label6.Size = new Size(238, 29);
            label6.TabIndex = 12;
            label6.Text = "MANAGE SELLERS";
            // 
            // Mainmenu_btn
            // 
            Mainmenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            Mainmenu_btn.FlatStyle = FlatStyle.Flat;
            Mainmenu_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mainmenu_btn.Location = new Point(12, 149);
            Mainmenu_btn.Name = "Mainmenu_btn";
            Mainmenu_btn.Size = new Size(132, 30);
            Mainmenu_btn.TabIndex = 22;
            Mainmenu_btn.Text = "MAIN MENU";
            Mainmenu_btn.UseVisualStyleBackColor = false;
            Mainmenu_btn.Click += Mainmenu_btn_Click;
            // 
            // Sellers
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 510);
            Controls.Add(Mainmenu_btn);
            Controls.Add(Close_lbl);
            Controls.Add(Brands_btn);
            Controls.Add(Categories_btn);
            Controls.Add(Products_btn);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sellers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sellers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Sellers_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Close_lbl;
        private Button Brands_btn;
        private Button Categories_btn;
        private Button Products_btn;
        private Panel panel1;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox SellerPass_tb;
        private TextBox SellerName_tb;
        private TextBox SellerAge_tb;
        private TextBox SellerPhone_tb;
        private TextBox SellerId_tb;
        private DataGridView Sellers_dgv;
        private Button Mainmenu_btn;
    }
}