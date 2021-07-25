namespace Medical_Center
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet9 = new Medical_Center.MedicalDataSet9();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet6 = new Medical_Center.MedicalDataSet6();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet4 = new Medical_Center.MedicalDataSet4();
            this.stockTableAdapter = new Medical_Center.MedicalDataSet4TableAdapters.StockTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.medicalDataSet5 = new Medical_Center.MedicalDataSet5();
            this.medicalDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter1 = new Medical_Center.MedicalDataSet6TableAdapters.StockTableAdapter();
            this.medicalDataSet8 = new Medical_Center.MedicalDataSet8();
            this.medicalDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter2 = new Medical_Center.MedicalDataSet9TableAdapters.StockTableAdapter();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSrch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(949, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // stockBindingSource2
            // 
            this.stockBindingSource2.DataMember = "Stock";
            this.stockBindingSource2.DataSource = this.medicalDataSet9;
            // 
            // medicalDataSet9
            // 
            this.medicalDataSet9.DataSetName = "MedicalDataSet9";
            this.medicalDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "Stock";
            this.stockBindingSource1.DataSource = this.medicalDataSet6;
            // 
            // medicalDataSet6
            // 
            this.medicalDataSet6.DataSetName = "MedicalDataSet6";
            this.medicalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.medicalDataSet4;
            // 
            // medicalDataSet4
            // 
            this.medicalDataSet4.DataSetName = "MedicalDataSet4";
            this.medicalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("RomanSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(731, 575);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 53);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(245, 91);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 27);
            this.txtName.TabIndex = 51;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Medicine Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(546, 88);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 32);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // medicalDataSet5
            // 
            this.medicalDataSet5.DataSetName = "MedicalDataSet5";
            this.medicalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalDataSet5BindingSource
            // 
            this.medicalDataSet5BindingSource.DataSource = this.medicalDataSet5;
            this.medicalDataSet5BindingSource.Position = 0;
            // 
            // stockTableAdapter1
            // 
            this.stockTableAdapter1.ClearBeforeFill = true;
            // 
            // medicalDataSet8
            // 
            this.medicalDataSet8.DataSetName = "MedicalDataSet8";
            this.medicalDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalDataSet8BindingSource
            // 
            this.medicalDataSet8BindingSource.DataSource = this.medicalDataSet8;
            this.medicalDataSet8BindingSource.Position = 0;
            // 
            // stockTableAdapter2
            // 
            this.stockTableAdapter2.ClearBeforeFill = true;
            // 
            // txtBName
            // 
            this.txtBName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(245, 150);
            this.txtBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(260, 27);
            this.txtBName.TabIndex = 75;
            this.txtBName.Click += new System.EventHandler(this.txtBName_Click);
            this.txtBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBName_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Brand Name:";
            // 
            // btnSrch
            // 
            this.btnSrch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSrch.Font = new System.Drawing.Font("Google Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrch.Location = new System.Drawing.Point(546, 148);
            this.btnSrch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(151, 32);
            this.btnSrch.TabIndex = 76;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            this.btnSrch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSrch_KeyDown);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 710);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Stock";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet8BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalDataSet4 medicalDataSet4;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private MedicalDataSet4TableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource medicalDataSet5BindingSource;
        private MedicalDataSet5 medicalDataSet5;
        private MedicalDataSet6 medicalDataSet6;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private MedicalDataSet6TableAdapters.StockTableAdapter stockTableAdapter1;
        private System.Windows.Forms.BindingSource medicalDataSet8BindingSource;
        private MedicalDataSet8 medicalDataSet8;
        private MedicalDataSet9 medicalDataSet9;
        private System.Windows.Forms.BindingSource stockBindingSource2;
        private MedicalDataSet9TableAdapters.StockTableAdapter stockTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSrch;
    }
}