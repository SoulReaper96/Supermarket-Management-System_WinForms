namespace Supermarket_Management_System
{
    partial class Brands
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
            Refresh_btn = new Button();
            BrandCat1_cmb = new ComboBox();
            Products_dgv = new DataGridView();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            BrandCat_cmb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            Close_lbl = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            Mainmenu_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Refresh_btn
            // 
            Refresh_btn.BackColor = Color.FromArgb(255, 192, 128);
            Refresh_btn.FlatStyle = FlatStyle.Flat;
            Refresh_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refresh_btn.Location = new Point(694, 11);
            Refresh_btn.Name = "Refresh_btn";
            Refresh_btn.Size = new Size(90, 30);
            Refresh_btn.TabIndex = 27;
            Refresh_btn.Text = "REFRESH";
            Refresh_btn.UseVisualStyleBackColor = false;
            // 
            // BrandCat1_cmb
            // 
            BrandCat1_cmb.ForeColor = Color.FromArgb(255, 192, 128);
            BrandCat1_cmb.FormattingEnabled = true;
            BrandCat1_cmb.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            BrandCat1_cmb.Location = new Point(519, 15);
            BrandCat1_cmb.Name = "BrandCat1_cmb";
            BrandCat1_cmb.Size = new Size(169, 25);
            BrandCat1_cmb.TabIndex = 26;
            BrandCat1_cmb.Text = "SELECT BRAND";
            // 
            // Products_dgv
            // 
            Products_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Products_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Products_dgv.BackgroundColor = Color.White;
            Products_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Products_dgv.Location = new Point(298, 46);
            Products_dgv.Name = "Products_dgv";
            Products_dgv.Size = new Size(535, 398);
            Products_dgv.TabIndex = 25;
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
            // 
            // BrandCat_cmb
            // 
            BrandCat_cmb.ForeColor = Color.FromArgb(255, 192, 128);
            BrandCat_cmb.FormattingEnabled = true;
            BrandCat_cmb.Items.AddRange(new object[] { "ADMIN", "SELLER" });
            BrandCat_cmb.Location = new Point(111, 190);
            BrandCat_cmb.Name = "BrandCat_cmb";
            BrandCat_cmb.Size = new Size(169, 25);
            BrandCat_cmb.TabIndex = 22;
            BrandCat_cmb.Text = "SELECT CATEGORY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 196);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 21;
            label5.Text = "CATEGORY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 165);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 19;
            label4.Text = "PRICE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 17;
            label3.Text = "QUANTITY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(25, 19);
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
            label6.Size = new Size(228, 29);
            label6.TabIndex = 12;
            label6.Text = "MANAGE BRANDS";
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.FromArgb(255, 192, 128);
            Close_lbl.Location = new Point(975, 11);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 16;
            Close_lbl.Text = "X";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 113);
            button3.Name = "button3";
            button3.Size = new Size(132, 30);
            button3.TabIndex = 15;
            button3.Text = "SELLING";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 77);
            button2.Name = "button2";
            button2.Size = new Size(132, 30);
            button2.TabIndex = 14;
            button2.Text = "CATEGORIES";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(132, 30);
            button1.TabIndex = 13;
            button1.Text = "PRODUCTS";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 93);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 15;
            label1.Text = "NAME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(Refresh_btn);
            panel1.Controls.Add(BrandCat1_cmb);
            panel1.Controls.Add(Products_dgv);
            panel1.Controls.Add(Delete_btn);
            panel1.Controls.Add(Edit_btn);
            panel1.Controls.Add(Add_btn);
            panel1.Controls.Add(BrandCat_cmb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(150, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 459);
            panel1.TabIndex = 12;
            // 
            // Mainmenu_btn
            // 
            Mainmenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            Mainmenu_btn.FlatStyle = FlatStyle.Flat;
            Mainmenu_btn.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mainmenu_btn.Location = new Point(12, 149);
            Mainmenu_btn.Name = "Mainmenu_btn";
            Mainmenu_btn.Size = new Size(132, 30);
            Mainmenu_btn.TabIndex = 17;
            Mainmenu_btn.Text = "MAIN MENU";
            Mainmenu_btn.UseVisualStyleBackColor = false;
            // 
            // Brands
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 510);
            Controls.Add(Mainmenu_btn);
            Controls.Add(Close_lbl);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Brands";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brands";
            ((System.ComponentModel.ISupportInitialize)Products_dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Refresh_btn;
        private ComboBox BrandCat1_cmb;
        private DataGridView Products_dgv;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private ComboBox BrandCat_cmb;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label Close_lbl;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private Button Mainmenu_btn;
    }
}