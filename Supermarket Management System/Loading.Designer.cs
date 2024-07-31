namespace Supermarket_Management_System
{
    partial class Loading
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            label6 = new Label();
            label1 = new Label();
            Loading_pbar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            LoadValue_lbl = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(487, 29);
            label6.TabIndex = 11;
            label6.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 22);
            label1.TabIndex = 12;
            label1.Text = "VERSION 1.0";
            // 
            // Loading_pbar
            // 
            Loading_pbar.Dock = DockStyle.Bottom;
            Loading_pbar.Location = new Point(0, 230);
            Loading_pbar.Name = "Loading_pbar";
            Loading_pbar.Size = new Size(512, 19);
            Loading_pbar.TabIndex = 13;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // LoadValue_lbl
            // 
            LoadValue_lbl.AutoSize = true;
            LoadValue_lbl.Location = new Point(12, 212);
            LoadValue_lbl.Name = "LoadValue_lbl";
            LoadValue_lbl.Size = new Size(25, 15);
            LoadValue_lbl.TabIndex = 14;
            LoadValue_lbl.Text = "0%";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(177, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(512, 249);
            Controls.Add(pictureBox1);
            Controls.Add(LoadValue_lbl);
            Controls.Add(Loading_pbar);
            Controls.Add(label1);
            Controls.Add(label6);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            Text = "Form1";
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private ProgressBar Loading_pbar;
        private System.Windows.Forms.Timer timer1;
        private Label LoadValue_lbl;
        private PictureBox pictureBox1;
    }
}
