namespace Supermarket_Management_System
{
    partial class Categories
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
            Categories_dgv = new DataGridView();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            Brands_btn = new Button();
            Sellers_btn = new Button();
            Products_btn = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            Close_lbl = new Label();
            panel1 = new Panel();
            CategoryId_tb = new TextBox();
            CategoryName_tb = new TextBox();
            CategoryDesc_tb = new TextBox();
            Mainmenu_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Categories_dgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Categories_dgv
            // 
            Categories_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Categories_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Categories_dgv.BackgroundColor = Color.White;
            Categories_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Categories_dgv.Location = new Point(298, 46);
            Categories_dgv.Name = "Categories_dgv";
            Categories_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Categories_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            Categories_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Categories_dgv.Size = new Size(535, 398);
            Categories_dgv.TabIndex = 25;
            Categories_dgv.CellContentClick += Categories_dgv_CellContentClick;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.FromArgb(255, 192, 128);
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_btn.Location = new Point(195, 167);
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
            Edit_btn.Location = new Point(99, 167);
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
            Add_btn.Location = new Point(3, 167);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(90, 30);
            Add_btn.TabIndex = 12;
            Add_btn.Text = "ADD";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // Brands_btn
            // 
            Brands_btn.BackColor = Color.FromArgb(255, 192, 128);
            Brands_btn.FlatStyle = FlatStyle.Flat;
            Brands_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Brands_btn.Location = new Point(12, 113);
            Brands_btn.Name = "Brands_btn";
            Brands_btn.Size = new Size(132, 30);
            Brands_btn.TabIndex = 25;
            Brands_btn.Text = "BRANDS";
            Brands_btn.UseVisualStyleBackColor = false;
            // 
            // Sellers_btn
            // 
            Sellers_btn.BackColor = Color.FromArgb(255, 192, 128);
            Sellers_btn.FlatStyle = FlatStyle.Flat;
            Sellers_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sellers_btn.Location = new Point(12, 77);
            Sellers_btn.Name = "Sellers_btn";
            Sellers_btn.Size = new Size(132, 30);
            Sellers_btn.TabIndex = 24;
            Sellers_btn.Text = "SELLERS";
            Sellers_btn.UseVisualStyleBackColor = false;
            Sellers_btn.Click += Sellers_btn_Click;
            // 
            // Products_btn
            // 
            Products_btn.BackColor = Color.FromArgb(255, 192, 128);
            Products_btn.FlatStyle = FlatStyle.Flat;
            Products_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Products_btn.Location = new Point(12, 41);
            Products_btn.Name = "Products_btn";
            Products_btn.Size = new Size(132, 30);
            Products_btn.TabIndex = 23;
            Products_btn.Text = "PRODUCTS";
            Products_btn.UseVisualStyleBackColor = false;
            Products_btn.Click += Products_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.3F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(101, 16);
            label3.TabIndex = 17;
            label3.Text = "DESCRIPTION";
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
            label6.Size = new Size(283, 29);
            label6.TabIndex = 12;
            label6.Text = "MANAGE CATEGORIES";
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Close_lbl.Location = new Point(975, 11);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 26;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(CategoryId_tb);
            panel1.Controls.Add(CategoryName_tb);
            panel1.Controls.Add(CategoryDesc_tb);
            panel1.Controls.Add(Categories_dgv);
            panel1.Controls.Add(Delete_btn);
            panel1.Controls.Add(Edit_btn);
            panel1.Controls.Add(Add_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(150, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 459);
            panel1.TabIndex = 22;
            // 
            // CategoryId_tb
            // 
            CategoryId_tb.Location = new Point(110, 53);
            CategoryId_tb.Name = "CategoryId_tb";
            CategoryId_tb.Size = new Size(175, 25);
            CategoryId_tb.TabIndex = 41;
            // 
            // CategoryName_tb
            // 
            CategoryName_tb.Location = new Point(110, 89);
            CategoryName_tb.Name = "CategoryName_tb";
            CategoryName_tb.Size = new Size(175, 25);
            CategoryName_tb.TabIndex = 40;
            // 
            // CategoryDesc_tb
            // 
            CategoryDesc_tb.Location = new Point(110, 125);
            CategoryDesc_tb.Name = "CategoryDesc_tb";
            CategoryDesc_tb.Size = new Size(175, 25);
            CategoryDesc_tb.TabIndex = 39;
            // 
            // Mainmenu_btn
            // 
            Mainmenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            Mainmenu_btn.FlatStyle = FlatStyle.Flat;
            Mainmenu_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mainmenu_btn.Location = new Point(12, 149);
            Mainmenu_btn.Name = "Mainmenu_btn";
            Mainmenu_btn.Size = new Size(132, 30);
            Mainmenu_btn.TabIndex = 27;
            Mainmenu_btn.Text = "MAIN MENU";
            Mainmenu_btn.UseVisualStyleBackColor = false;
            Mainmenu_btn.Click += Mainmenu_btn_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 510);
            Controls.Add(Mainmenu_btn);
            Controls.Add(Brands_btn);
            Controls.Add(Sellers_btn);
            Controls.Add(Products_btn);
            Controls.Add(Close_lbl);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)Categories_dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Categories_dgv;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private Button Brands_btn;
        private Button Sellers_btn;
        private Button Products_btn;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label Close_lbl;
        private Panel panel1;
        private TextBox CategoryId_tb;
        private TextBox CategoryName_tb;
        private TextBox CategoryDesc_tb;
        private Button Mainmenu_btn;
    }
}