namespace Supermarket_Management_System
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            label6 = new Label();
            label1 = new Label();
            ProdMenu_btn = new Button();
            CatMenu_btn = new Button();
            BrandMenu_btn = new Button();
            SellersMenu_btn = new Button();
            LogoutMenu_btn = new Button();
            Close_lbl = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 17F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(466, 27);
            label6.TabIndex = 12;
            label6.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 38);
            label1.Name = "label1";
            label1.Size = new Size(153, 29);
            label1.TabIndex = 13;
            label1.Text = "MAIN MENU";
            // 
            // ProdMenu_btn
            // 
            ProdMenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            ProdMenu_btn.FlatStyle = FlatStyle.Flat;
            ProdMenu_btn.Font = new Font("Arial", 18F);
            ProdMenu_btn.Image = (Image)resources.GetObject("ProdMenu_btn.Image");
            ProdMenu_btn.ImageAlign = ContentAlignment.MiddleLeft;
            ProdMenu_btn.Location = new Point(12, 106);
            ProdMenu_btn.Name = "ProdMenu_btn";
            ProdMenu_btn.Size = new Size(240, 70);
            ProdMenu_btn.TabIndex = 14;
            ProdMenu_btn.Text = "PRODUCTS";
            ProdMenu_btn.TextAlign = ContentAlignment.MiddleRight;
            ProdMenu_btn.UseVisualStyleBackColor = false;
            ProdMenu_btn.Click += ProdMenu_btn_Click;
            // 
            // CatMenu_btn
            // 
            CatMenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            CatMenu_btn.FlatStyle = FlatStyle.Flat;
            CatMenu_btn.Font = new Font("Arial", 18F);
            CatMenu_btn.Image = (Image)resources.GetObject("CatMenu_btn.Image");
            CatMenu_btn.ImageAlign = ContentAlignment.MiddleLeft;
            CatMenu_btn.Location = new Point(12, 184);
            CatMenu_btn.Name = "CatMenu_btn";
            CatMenu_btn.Size = new Size(240, 70);
            CatMenu_btn.TabIndex = 15;
            CatMenu_btn.Text = "CATEGORIES";
            CatMenu_btn.TextAlign = ContentAlignment.MiddleRight;
            CatMenu_btn.UseVisualStyleBackColor = false;
            CatMenu_btn.Click += CatMenu_btn_Click;
            // 
            // BrandMenu_btn
            // 
            BrandMenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            BrandMenu_btn.FlatStyle = FlatStyle.Flat;
            BrandMenu_btn.Font = new Font("Arial", 18F);
            BrandMenu_btn.Image = (Image)resources.GetObject("BrandMenu_btn.Image");
            BrandMenu_btn.ImageAlign = ContentAlignment.MiddleLeft;
            BrandMenu_btn.Location = new Point(263, 106);
            BrandMenu_btn.Name = "BrandMenu_btn";
            BrandMenu_btn.Size = new Size(240, 70);
            BrandMenu_btn.TabIndex = 16;
            BrandMenu_btn.Text = "BRANDS";
            BrandMenu_btn.TextAlign = ContentAlignment.MiddleRight;
            BrandMenu_btn.UseVisualStyleBackColor = false;
            BrandMenu_btn.Click += BrandMenu_btn_Click;
            // 
            // SellersMenu_btn
            // 
            SellersMenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            SellersMenu_btn.FlatStyle = FlatStyle.Flat;
            SellersMenu_btn.Font = new Font("Arial", 18F);
            SellersMenu_btn.Image = (Image)resources.GetObject("SellersMenu_btn.Image");
            SellersMenu_btn.ImageAlign = ContentAlignment.MiddleLeft;
            SellersMenu_btn.Location = new Point(263, 182);
            SellersMenu_btn.Name = "SellersMenu_btn";
            SellersMenu_btn.Size = new Size(240, 72);
            SellersMenu_btn.TabIndex = 17;
            SellersMenu_btn.Text = "SELLERS";
            SellersMenu_btn.TextAlign = ContentAlignment.MiddleRight;
            SellersMenu_btn.UseVisualStyleBackColor = false;
            SellersMenu_btn.Click += SellersMenu_btn_Click;
            // 
            // LogoutMenu_btn
            // 
            LogoutMenu_btn.BackColor = Color.FromArgb(255, 192, 128);
            LogoutMenu_btn.FlatStyle = FlatStyle.Flat;
            LogoutMenu_btn.Font = new Font("Arial", 18F);
            LogoutMenu_btn.Image = (Image)resources.GetObject("LogoutMenu_btn.Image");
            LogoutMenu_btn.Location = new Point(433, 426);
            LogoutMenu_btn.Name = "LogoutMenu_btn";
            LogoutMenu_btn.Size = new Size(70, 72);
            LogoutMenu_btn.TabIndex = 18;
            LogoutMenu_btn.TextAlign = ContentAlignment.MiddleRight;
            LogoutMenu_btn.UseVisualStyleBackColor = false;
            LogoutMenu_btn.Click += LogoutMenu_btn_Click;
            // 
            // Close_lbl
            // 
            Close_lbl.AutoSize = true;
            Close_lbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_lbl.ForeColor = Color.Black;
            Close_lbl.Location = new Point(483, 9);
            Close_lbl.Name = "Close_lbl";
            Close_lbl.Size = new Size(20, 19);
            Close_lbl.TabIndex = 19;
            Close_lbl.Text = "X";
            Close_lbl.Click += Close_lbl_Click;
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(515, 510);
            Controls.Add(Close_lbl);
            Controls.Add(LogoutMenu_btn);
            Controls.Add(SellersMenu_btn);
            Controls.Add(BrandMenu_btn);
            Controls.Add(CatMenu_btn);
            Controls.Add(ProdMenu_btn);
            Controls.Add(label1);
            Controls.Add(label6);
            Font = new Font("Arial", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainmenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private Button ProdMenu_btn;
        private Button CatMenu_btn;
        private Button BrandMenu_btn;
        private Button SellersMenu_btn;
        private Button LogoutMenu_btn;
        private Label Close_lbl;
    }
}