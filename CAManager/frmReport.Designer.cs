
namespace CAManager
{
    partial class frmReport
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
            this.spInvoiceSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDS = new CAManager.reportDS();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbGroupClient = new System.Windows.Forms.ComboBox();
            this.spcustomerGroupSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.sp_invoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_InvoiceSelTableAdapter = new CAManager.reportDSTableAdapters.sp_InvoiceSelTableAdapter();
            this.spcompanySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_companySelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_companySelectTableAdapter();
            this.sp_customerGroupSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_customerGroupSelectTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spInvoiceSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_invoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // spInvoiceSelBindingSource
            // 
            this.spInvoiceSelBindingSource.DataMember = "sp_InvoiceSel";
            this.spInvoiceSelBindingSource.DataSource = this.reportDS;
            // 
            // reportDS
            // 
            this.reportDS.DataSetName = "reportDS";
            this.reportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cmbGroupClient);
            this.panel1.Controls.Add(this.cmbClientName);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1839, 100);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(873, 9);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel1.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 26);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Client Name";
            // 
            // cmbGroupClient
            // 
            this.cmbGroupClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGroupClient.DataSource = this.spcustomerGroupSelectBindingSource;
            this.cmbGroupClient.DisplayMember = "customerGroup";
            this.cmbGroupClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupClient.FormattingEnabled = true;
            this.cmbGroupClient.Location = new System.Drawing.Point(185, 40);
            this.cmbGroupClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroupClient.Name = "cmbGroupClient";
            this.cmbGroupClient.Size = new System.Drawing.Size(200, 26);
            this.cmbGroupClient.TabIndex = 34;
            this.cmbGroupClient.ValueMember = "Code";
            this.cmbGroupClient.SelectedIndexChanged += new System.EventHandler(this.cmbGroupClient_SelectedIndexChanged);
            // 
            // spcustomerGroupSelectBindingSource
            // 
            this.spcustomerGroupSelectBindingSource.DataMember = "sp_customerGroupSelect";
            this.spcustomerGroupSelectBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbClientName
            // 
            this.cmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Items.AddRange(new object[] {
            ""});
            this.cmbClientName.Location = new System.Drawing.Point(871, 39);
            this.cmbClientName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(202, 26);
            this.cmbClientName.TabIndex = 35;
            this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbClientName_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(188, 8);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel4.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(189, 26);
            this.materialLabel4.TabIndex = 33;
            this.materialLabel4.Text = "Client Group";
            // 
            // sp_invoiceDetailsBindingSource
            // 
            this.sp_invoiceDetailsBindingSource.DataMember = "sp_invoiceDetails";
            this.sp_invoiceDetailsBindingSource.DataSource = this.reportDS;
            // 
            // sp_InvoiceSelTableAdapter
            // 
            this.sp_InvoiceSelTableAdapter.ClearBeforeFill = true;
            // 
            // spcompanySelectBindingSource
            // 
            this.spcompanySelectBindingSource.DataMember = "sp_companySelect";
            this.spcompanySelectBindingSource.DataSource = this.dataSet1;
            // 
            // sp_companySelectTableAdapter
            // 
            this.sp_companySelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_customerGroupSelectTableAdapter
            // 
            this.sp_customerGroupSelectTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1839, 794);
            this.panel3.TabIndex = 2;
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.AllowUserToDeleteRows = false;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInv.Location = new System.Drawing.Point(0, 0);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowHeadersWidth = 51;
            this.dgvInv.RowTemplate.Height = 24;
            this.dgvInv.Size = new System.Drawing.Size(1839, 794);
            this.dgvInv.TabIndex = 0;
            this.dgvInv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 894);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spInvoiceSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_invoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private reportDS reportDS;
        private System.Windows.Forms.BindingSource spInvoiceSelBindingSource;
        private reportDSTableAdapters.sp_InvoiceSelTableAdapter sp_InvoiceSelTableAdapter;
        private System.Windows.Forms.BindingSource sp_invoiceDetailsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbGroupClient;
        private System.Windows.Forms.ComboBox cmbClientName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spcompanySelectBindingSource;
        private DataSet1TableAdapters.sp_companySelectTableAdapter sp_companySelectTableAdapter;
        private System.Windows.Forms.BindingSource spcustomerGroupSelectBindingSource;
        private DataSet1TableAdapters.sp_customerGroupSelectTableAdapter sp_customerGroupSelectTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInv;
    }
}