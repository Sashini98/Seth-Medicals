namespace Medical_Center
{
    partial class Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            this.btn_pharmacy = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_channel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pharmacy
            // 
            this.btn_pharmacy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pharmacy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_pharmacy.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pharmacy.ForeColor = System.Drawing.Color.White;
            this.btn_pharmacy.Location = new System.Drawing.Point(370, 366);
            this.btn_pharmacy.Name = "btn_pharmacy";
            this.btn_pharmacy.Size = new System.Drawing.Size(244, 80);
            this.btn_pharmacy.TabIndex = 1;
            this.btn_pharmacy.Text = "Pharmacy";
            this.btn_pharmacy.UseVisualStyleBackColor = false;
            this.btn_pharmacy.Click += new System.EventHandler(this.btn_pharmacy_Click);
            this.btn_pharmacy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_pharmacy_KeyDown);
            // 
            // btn_stock
            // 
            this.btn_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_stock.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_stock.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.Location = new System.Drawing.Point(1168, 366);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(189, 80);
            this.btn_stock.TabIndex = 2;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            this.btn_stock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_stock_KeyDown);
            // 
            // btn_channel
            // 
            this.btn_channel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_channel.AutoSize = true;
            this.btn_channel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_channel.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_channel.ForeColor = System.Drawing.Color.White;
            this.btn_channel.Location = new System.Drawing.Point(729, 366);
            this.btn_channel.Name = "btn_channel";
            this.btn_channel.Size = new System.Drawing.Size(322, 80);
            this.btn_channel.TabIndex = 3;
            this.btn_channel.Text = "Channeling Center";
            this.btn_channel.UseVisualStyleBackColor = false;
            this.btn_channel.Click += new System.EventHandler(this.btn_channel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1722, 930);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_channel);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_pharmacy);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Select";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pharmacy;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_channel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}