
namespace CAManager
{
    partial class frmInvoice
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
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.spfileRegSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.spfileRegSelectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spgetInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeptSave = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalAm = new System.Windows.Forms.TextBox();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.lblTA = new MaterialSkin.Controls.MaterialLabel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTermPayment = new System.Windows.Forms.TextBox();
            this.lblTOP = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblDD = new MaterialSkin.Controls.MaterialLabel();
            this.DocDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbGroupClient = new System.Windows.Forms.ComboBox();
            this.spcustomerGroupSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sp_customerGroupSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_customerGroupSelectTableAdapter();
            this.sp_fileRegSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_fileRegSelectTableAdapter();
            this.lblWarning = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfileRegSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfileRegSelectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetInvoiceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.ColumnHeadersHeight = 29;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.Size = new System.Drawing.Size(1924, 681);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellContentClick);
            this.dgvInvoice.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellLeave);
            // 
            // Select
            // 
            this.Select.Frozen = true;
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 125;
            // 
            // spfileRegSelectBindingSource
            // 
            this.spfileRegSelectBindingSource.DataMember = "sp_fileRegSelect";
            this.spfileRegSelectBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spfileRegSelectBindingSource1
            // 
            this.spfileRegSelectBindingSource1.DataMember = "sp_fileRegSelect";
            this.spfileRegSelectBindingSource1.DataSource = this.dataSet1;
            // 
            // btnDeptSave
            // 
            this.btnDeptSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnDeptSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeptSave.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeptSave.ForeColor = System.Drawing.Color.White;
            this.btnDeptSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeptSave.IconColor = System.Drawing.Color.Thistle;
            this.btnDeptSave.IconSize = 22;
            this.btnDeptSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeptSave.Location = new System.Drawing.Point(838, 27);
            this.btnDeptSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeptSave.Name = "btnDeptSave";
            this.btnDeptSave.Rotation = 0D;
            this.btnDeptSave.Size = new System.Drawing.Size(196, 43);
            this.btnDeptSave.TabIndex = 3;
            this.btnDeptSave.Text = "Save";
            this.btnDeptSave.UseVisualStyleBackColor = false;
            this.btnDeptSave.Click += new System.EventHandler(this.btnDeptSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotalAm);
            this.panel1.Controls.Add(this.txtInvoice);
            this.panel1.Controls.Add(this.lblTA);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.txtTermPayment);
            this.panel1.Controls.Add(this.lblTOP);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.lblDD);
            this.panel1.Controls.Add(this.DocDate);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cmbGroupClient);
            this.panel1.Controls.Add(this.cmbClientName);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 118);
            this.panel1.TabIndex = 4;
            // 
            // txtTotalAm
            // 
            this.txtTotalAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAm.Location = new System.Drawing.Point(816, 54);
            this.txtTotalAm.Multiline = true;
            this.txtTotalAm.Name = "txtTotalAm";
            this.txtTotalAm.ReadOnly = true;
            this.txtTotalAm.Size = new System.Drawing.Size(133, 31);
            this.txtTotalAm.TabIndex = 47;
            this.txtTotalAm.TextChanged += new System.EventHandler(this.txtTotalAm_TextChanged);
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(640, 54);
            this.txtInvoice.Multiline = true;
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(141, 31);
            this.txtInvoice.TabIndex = 47;
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Depth = 0;
            this.lblTA.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTA.Location = new System.Drawing.Point(811, 24);
            this.lblTA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(124, 24);
            this.lblTA.TabIndex = 46;
            this.lblTA.Text = "Total Amount";
            this.lblTA.Click += new System.EventHandler(this.lblTA_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(1395, 36);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(249, 64);
            this.txtRemark.TabIndex = 45;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1391, 8);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 24);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "Remark";
            // 
            // txtTermPayment
            // 
            this.txtTermPayment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermPayment.Location = new System.Drawing.Point(1009, 38);
            this.txtTermPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtTermPayment.Multiline = true;
            this.txtTermPayment.Name = "txtTermPayment";
            this.txtTermPayment.Size = new System.Drawing.Size(337, 61);
            this.txtTermPayment.TabIndex = 42;
            this.txtTermPayment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblTOP
            // 
            this.lblTOP.AutoSize = true;
            this.lblTOP.Depth = 0;
            this.lblTOP.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTOP.Location = new System.Drawing.Point(1005, 10);
            this.lblTOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTOP.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTOP.Name = "lblTOP";
            this.lblTOP.Size = new System.Drawing.Size(168, 24);
            this.lblTOP.TabIndex = 41;
            this.lblTOP.Text = "Terms Of Payment";
            this.lblTOP.Click += new System.EventHandler(this.lblTOP_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(638, 28);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel3.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(189, 26);
            this.materialLabel3.TabIndex = 38;
            this.materialLabel3.Text = "Invoice No";
            // 
            // lblDD
            // 
            this.lblDD.AutoSize = true;
            this.lblDD.Depth = 0;
            this.lblDD.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDD.Location = new System.Drawing.Point(421, 28);
            this.lblDD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDD.MaximumSize = new System.Drawing.Size(189, 26);
            this.lblDD.MinimumSize = new System.Drawing.Size(189, 26);
            this.lblDD.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDD.Name = "lblDD";
            this.lblDD.Size = new System.Drawing.Size(189, 26);
            this.lblDD.TabIndex = 38;
            this.lblDD.Text = "Document Date";
            // 
            // DocDate
            // 
            this.DocDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DocDate.Location = new System.Drawing.Point(425, 56);
            this.DocDate.Name = "DocDate";
            this.DocDate.Size = new System.Drawing.Size(200, 28);
            this.DocDate.TabIndex = 37;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(211, 30);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel1.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 26);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Client Name";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // cmbGroupClient
            // 
            this.cmbGroupClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGroupClient.DataSource = this.spcustomerGroupSelectBindingSource;
            this.cmbGroupClient.DisplayMember = "customerGroup";
            this.cmbGroupClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupClient.FormattingEnabled = true;
            this.cmbGroupClient.Location = new System.Drawing.Point(17, 57);
            this.cmbGroupClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroupClient.Name = "cmbGroupClient";
            this.cmbGroupClient.Size = new System.Drawing.Size(186, 26);
            this.cmbGroupClient.TabIndex = 34;
            this.cmbGroupClient.ValueMember = "customerGroup";
            this.cmbGroupClient.SelectedIndexChanged += new System.EventHandler(this.cmbGroupClient_SelectedIndexChanged);
            // 
            // spcustomerGroupSelectBindingSource
            // 
            this.spcustomerGroupSelectBindingSource.DataMember = "sp_customerGroupSelect";
            this.spcustomerGroupSelectBindingSource.DataSource = this.dataSet1;
            // 
            // cmbClientName
            // 
            this.cmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Items.AddRange(new object[] {
            ""});
            this.cmbClientName.Location = new System.Drawing.Point(214, 57);
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
            this.materialLabel4.Location = new System.Drawing.Point(17, 30);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel4.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(189, 26);
            this.materialLabel4.TabIndex = 33;
            this.materialLabel4.Text = "Client Group";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWarning);
            this.panel2.Controls.Add(this.btnDeptSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 799);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvInvoice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 681);
            this.panel3.TabIndex = 6;
            // 
            // sp_customerGroupSelectTableAdapter
            // 
            this.sp_customerGroupSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_fileRegSelectTableAdapter
            // 
            this.sp_fileRegSelectTableAdapter.ClearBeforeFill = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Depth = 0;
            this.lblWarning.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarning.Location = new System.Drawing.Point(1103, 37);
            this.lblWarning.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 24);
            this.lblWarning.TabIndex = 4;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 899);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInvoice";
            this.Text = "frmInvoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfileRegSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfileRegSelectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetInvoiceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spgetInvoiceBindingSource;
        //private DataSet1TableAdapters.sp_getInvoiceTableAdapter sp_getInvoiceTableAdapter;
        private FontAwesome.Sharp.IconButton btnDeptSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbGroupClient;
        private System.Windows.Forms.ComboBox cmbClientName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.BindingSource spcustomerGroupSelectBindingSource;
        private DataSet1TableAdapters.sp_customerGroupSelectTableAdapter sp_customerGroupSelectTableAdapter;
        private System.Windows.Forms.BindingSource spfileRegSelectBindingSource1;
        private System.Windows.Forms.BindingSource spfileRegSelectBindingSource;
        private DataSet1TableAdapters.sp_fileRegSelectTableAdapter sp_fileRegSelectTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private MaterialSkin.Controls.MaterialLabel lblDD;
        private System.Windows.Forms.DateTimePicker DocDate;
        private System.Windows.Forms.TextBox txtTermPayment;
        private MaterialSkin.Controls.MaterialLabel lblTOP;
        private System.Windows.Forms.TextBox txtRemark;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblTA;
		private System.Windows.Forms.TextBox txtInvoice;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private System.Windows.Forms.TextBox txtTotalAm;
        private MaterialSkin.Controls.MaterialLabel lblWarning;
    }
}