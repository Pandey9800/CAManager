namespace CAManager
{
    partial class frmCompany
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
            this.spcompanyTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.spcustomerGroupSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_customerGroupSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_customerGroupSelectTableAdapter();
            this.sp_companyTypeTableAdapter = new CAManager.DataSet1TableAdapters.sp_companyTypeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cAManagerDataSet = new CAManager.CAManagerDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCustGroup = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMobile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFoundationDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCompanyCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFileNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTAN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtESIC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtGST = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTIN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCIN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.txtPAN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAdhar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.txtVoterId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrimeryName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrimeryEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrimeryContact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanyTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAManagerDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcompanyTypeBindingSource
            // 
            this.spcompanyTypeBindingSource.DataMember = "sp_companyType";
            this.spcompanyTypeBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spcustomerGroupSelectBindingSource
            // 
            this.spcustomerGroupSelectBindingSource.DataMember = "sp_customerGroupSelect";
            this.spcustomerGroupSelectBindingSource.DataSource = this.dataSet1;
            // 
            // sp_customerGroupSelectTableAdapter
            // 
            this.sp_customerGroupSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_companyTypeTableAdapter
            // 
            this.sp_companyTypeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 1102);
            this.panel1.TabIndex = 45;
            // 
            // cAManagerDataSet
            // 
            this.cAManagerDataSet.DataSetName = "CAManagerDataSet";
            this.cAManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1942, 658);
            this.panel2.TabIndex = 49;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1942, 658);
            this.dgv.TabIndex = 51;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.lblMsg);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1942, 421);
            this.panel3.TabIndex = 50;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtsearch.Depth = 0;
            this.txtsearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Hint = "Search";
            this.txtsearch.Location = new System.Drawing.Point(37, 385);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.Size = new System.Drawing.Size(287, 28);
            this.txtsearch.TabIndex = 49;
            this.txtsearch.UseSystemPasswordChar = false;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Depth = 0;
            this.lblMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(245, 350);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.MaximumSize = new System.Drawing.Size(1453, 31);
            this.lblMsg.MinimumSize = new System.Drawing.Size(1453, 31);
            this.lblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(1453, 31);
            this.lblMsg.TabIndex = 53;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.materialLabel17);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.materialLabel18);
            this.groupBox3.Controls.Add(this.cmbCustGroup);
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.cmbType);
            this.groupBox3.Controls.Add(this.materialLabel16);
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Controls.Add(this.materialLabel12);
            this.groupBox3.Controls.Add(this.txtMobile);
            this.groupBox3.Controls.Add(this.txtFoundationDate);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.txtCompanyCode);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(642, 322);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company Primary Details";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 36);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Company Name";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(8, 215);
            this.materialLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(63, 24);
            this.materialLabel17.TabIndex = 28;
            this.materialLabel17.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(240, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(287, 28);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(8, 178);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(69, 24);
            this.materialLabel18.TabIndex = 26;
            this.materialLabel18.Text = "Mobile";
            // 
            // cmbCustGroup
            // 
            this.cmbCustGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustGroup.DataSource = this.spcustomerGroupSelectBindingSource;
            this.cmbCustGroup.DisplayMember = "customerGroup";
            this.cmbCustGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustGroup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustGroup.FormattingEnabled = true;
            this.cmbCustGroup.Location = new System.Drawing.Point(240, 250);
            this.cmbCustGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustGroup.Name = "cmbCustGroup";
            this.cmbCustGroup.Size = new System.Drawing.Size(285, 26);
            this.cmbCustGroup.TabIndex = 7;
            this.cmbCustGroup.ValueMember = "customerGroup";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 143);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(80, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(240, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(287, 28);
            this.txtName.TabIndex = 1;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(240, 143);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(287, 28);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbType.DataSource = this.spcompanyTypeBindingSource;
            this.cmbType.DisplayMember = "type";
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(240, 108);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(285, 26);
            this.cmbType.TabIndex = 3;
            this.cmbType.ValueMember = "type";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(8, 247);
            this.materialLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(148, 24);
            this.materialLabel16.TabIndex = 30;
            this.materialLabel16.Text = "Customer Group";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 107);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Type";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(8, 283);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(139, 24);
            this.materialLabel12.TabIndex = 39;
            this.materialLabel12.Text = "Company Code";
            this.materialLabel12.Visible = false;
            // 
            // txtMobile
            // 
            this.txtMobile.Depth = 0;
            this.txtMobile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Hint = "";
            this.txtMobile.Location = new System.Drawing.Point(240, 178);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.Size = new System.Drawing.Size(287, 28);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.UseSystemPasswordChar = false;
            // 
            // txtFoundationDate
            // 
            this.txtFoundationDate.Depth = 0;
            this.txtFoundationDate.Enabled = false;
            this.txtFoundationDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoundationDate.Hint = "";
            this.txtFoundationDate.Location = new System.Drawing.Point(240, 71);
            this.txtFoundationDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtFoundationDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFoundationDate.Name = "txtFoundationDate";
            this.txtFoundationDate.PasswordChar = '\0';
            this.txtFoundationDate.SelectedText = "";
            this.txtFoundationDate.SelectionLength = 0;
            this.txtFoundationDate.SelectionStart = 0;
            this.txtFoundationDate.Size = new System.Drawing.Size(171, 28);
            this.txtFoundationDate.TabIndex = 2;
            this.txtFoundationDate.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  dd-MMM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 71);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 24);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 6, 13, 29, 32, 0);
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Depth = 0;
            this.txtCompanyCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyCode.Hint = "";
            this.txtCompanyCode.Location = new System.Drawing.Point(240, 283);
            this.txtCompanyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.PasswordChar = '\0';
            this.txtCompanyCode.SelectedText = "";
            this.txtCompanyCode.SelectionLength = 0;
            this.txtCompanyCode.SelectionStart = 0;
            this.txtCompanyCode.Size = new System.Drawing.Size(287, 28);
            this.txtCompanyCode.TabIndex = 8;
            this.txtCompanyCode.UseSystemPasswordChar = false;
            this.txtCompanyCode.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 71);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Foundation Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFileNo);
            this.groupBox2.Controls.Add(this.materialLabel21);
            this.groupBox2.Controls.Add(this.txtPF);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.txtTAN);
            this.groupBox2.Controls.Add(this.txtESIC);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.txtGST);
            this.groupBox2.Controls.Add(this.txtTIN);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.txtCIN);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(716, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(519, 322);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Details";
            // 
            // txtFileNo
            // 
            this.txtFileNo.Depth = 0;
            this.txtFileNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNo.Hint = "";
            this.txtFileNo.Location = new System.Drawing.Point(191, 37);
            this.txtFileNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.PasswordChar = '\0';
            this.txtFileNo.SelectedText = "";
            this.txtFileNo.SelectionLength = 0;
            this.txtFileNo.SelectionStart = 0;
            this.txtFileNo.Size = new System.Drawing.Size(287, 28);
            this.txtFileNo.TabIndex = 9;
            this.txtFileNo.UseSystemPasswordChar = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(27, 37);
            this.materialLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(76, 24);
            this.materialLabel21.TabIndex = 22;
            this.materialLabel21.Text = "File No.";
            // 
            // txtPF
            // 
            this.txtPF.Depth = 0;
            this.txtPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPF.Hint = "";
            this.txtPF.Location = new System.Drawing.Point(191, 70);
            this.txtPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPF.Name = "txtPF";
            this.txtPF.PasswordChar = '\0';
            this.txtPF.SelectedText = "";
            this.txtPF.SelectionLength = 0;
            this.txtPF.SelectionStart = 0;
            this.txtPF.Size = new System.Drawing.Size(287, 28);
            this.txtPF.TabIndex = 10;
            this.txtPF.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(27, 106);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(84, 24);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "ESIC No.";
            // 
            // txtTAN
            // 
            this.txtTAN.Depth = 0;
            this.txtTAN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAN.Hint = "";
            this.txtTAN.Location = new System.Drawing.Point(191, 142);
            this.txtTAN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTAN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTAN.Name = "txtTAN";
            this.txtTAN.PasswordChar = '\0';
            this.txtTAN.SelectedText = "";
            this.txtTAN.SelectionLength = 0;
            this.txtTAN.SelectionStart = 0;
            this.txtTAN.Size = new System.Drawing.Size(287, 28);
            this.txtTAN.TabIndex = 12;
            this.txtTAN.UseSystemPasswordChar = false;
            // 
            // txtESIC
            // 
            this.txtESIC.Depth = 0;
            this.txtESIC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESIC.Hint = "";
            this.txtESIC.Location = new System.Drawing.Point(191, 106);
            this.txtESIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtESIC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtESIC.Name = "txtESIC";
            this.txtESIC.PasswordChar = '\0';
            this.txtESIC.SelectedText = "";
            this.txtESIC.SelectionLength = 0;
            this.txtESIC.SelectionStart = 0;
            this.txtESIC.Size = new System.Drawing.Size(287, 28);
            this.txtESIC.TabIndex = 11;
            this.txtESIC.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(27, 142);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(82, 24);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "TAN No.";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(27, 249);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(80, 24);
            this.materialLabel10.TabIndex = 20;
            this.materialLabel10.Text = "GST No.";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(27, 70);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 24);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "PF No.";
            // 
            // txtGST
            // 
            this.txtGST.Depth = 0;
            this.txtGST.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGST.Hint = "";
            this.txtGST.Location = new System.Drawing.Point(191, 249);
            this.txtGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtGST.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGST.Name = "txtGST";
            this.txtGST.PasswordChar = '\0';
            this.txtGST.SelectedText = "";
            this.txtGST.SelectionLength = 0;
            this.txtGST.SelectionStart = 0;
            this.txtGST.Size = new System.Drawing.Size(287, 28);
            this.txtGST.TabIndex = 15;
            this.txtGST.UseSystemPasswordChar = false;
            // 
            // txtTIN
            // 
            this.txtTIN.Depth = 0;
            this.txtTIN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIN.Hint = "";
            this.txtTIN.Location = new System.Drawing.Point(191, 177);
            this.txtTIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.PasswordChar = '\0';
            this.txtTIN.SelectedText = "";
            this.txtTIN.SelectionLength = 0;
            this.txtTIN.SelectionStart = 0;
            this.txtTIN.Size = new System.Drawing.Size(287, 28);
            this.txtTIN.TabIndex = 13;
            this.txtTIN.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(27, 177);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(75, 24);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "TIN No.";
            // 
            // txtCIN
            // 
            this.txtCIN.Depth = 0;
            this.txtCIN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIN.Hint = "";
            this.txtCIN.Location = new System.Drawing.Point(191, 213);
            this.txtCIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.PasswordChar = '\0';
            this.txtCIN.SelectedText = "";
            this.txtCIN.SelectionLength = 0;
            this.txtCIN.SelectionStart = 0;
            this.txtCIN.Size = new System.Drawing.Size(287, 28);
            this.txtCIN.TabIndex = 14;
            this.txtCIN.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(27, 213);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(76, 24);
            this.materialLabel9.TabIndex = 18;
            this.materialLabel9.Text = "CIN No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtPAN);
            this.groupBox1.Controls.Add(this.txtAdhar);
            this.groupBox1.Controls.Add(this.materialLabel19);
            this.groupBox1.Controls.Add(this.txtVoterId);
            this.groupBox1.Controls.Add(this.materialLabel20);
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.txtPrimeryName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.materialLabel15);
            this.groupBox1.Controls.Add(this.txtPrimeryEmail);
            this.groupBox1.Controls.Add(this.txtPrimeryContact);
            this.groupBox1.Controls.Add(this.materialLabel14);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1295, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(574, 322);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Typo3;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconSize = 22;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(191, 270);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(108, 41);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPAN
            // 
            this.txtPAN.Depth = 0;
            this.txtPAN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAN.Hint = "";
            this.txtPAN.Location = new System.Drawing.Point(195, 36);
            this.txtPAN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.PasswordChar = '\0';
            this.txtPAN.SelectedText = "";
            this.txtPAN.SelectionLength = 0;
            this.txtPAN.SelectionStart = 0;
            this.txtPAN.Size = new System.Drawing.Size(287, 28);
            this.txtPAN.TabIndex = 16;
            this.txtPAN.UseSystemPasswordChar = false;
            // 
            // txtAdhar
            // 
            this.txtAdhar.Depth = 0;
            this.txtAdhar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdhar.Hint = "";
            this.txtAdhar.Location = new System.Drawing.Point(195, 174);
            this.txtAdhar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdhar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdhar.Name = "txtAdhar";
            this.txtAdhar.PasswordChar = '\0';
            this.txtAdhar.SelectedText = "";
            this.txtAdhar.SelectionLength = 0;
            this.txtAdhar.SelectionStart = 0;
            this.txtAdhar.Size = new System.Drawing.Size(287, 28);
            this.txtAdhar.TabIndex = 20;
            this.txtAdhar.UseSystemPasswordChar = false;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(8, 209);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(77, 24);
            this.materialLabel19.TabIndex = 24;
            this.materialLabel19.Text = "Voter ID";
            // 
            // txtVoterId
            // 
            this.txtVoterId.Depth = 0;
            this.txtVoterId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoterId.Hint = "";
            this.txtVoterId.Location = new System.Drawing.Point(195, 209);
            this.txtVoterId.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoterId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVoterId.Name = "txtVoterId";
            this.txtVoterId.PasswordChar = '\0';
            this.txtVoterId.SelectedText = "";
            this.txtVoterId.SelectionLength = 0;
            this.txtVoterId.SelectionStart = 0;
            this.txtVoterId.Size = new System.Drawing.Size(287, 28);
            this.txtVoterId.TabIndex = 21;
            this.txtVoterId.UseSystemPasswordChar = false;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(8, 174);
            this.materialLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(94, 24);
            this.materialLabel20.TabIndex = 22;
            this.materialLabel20.Text = "Adhar No.";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(8, 138);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(133, 24);
            this.materialLabel13.TabIndex = 37;
            this.materialLabel13.Text = "Primary E-mail";
            // 
            // txtPrimeryName
            // 
            this.txtPrimeryName.Depth = 0;
            this.txtPrimeryName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeryName.Hint = "";
            this.txtPrimeryName.Location = new System.Drawing.Point(195, 66);
            this.txtPrimeryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimeryName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrimeryName.Name = "txtPrimeryName";
            this.txtPrimeryName.PasswordChar = '\0';
            this.txtPrimeryName.SelectedText = "";
            this.txtPrimeryName.SelectionLength = 0;
            this.txtPrimeryName.SelectionStart = 0;
            this.txtPrimeryName.Size = new System.Drawing.Size(287, 28);
            this.txtPrimeryName.TabIndex = 17;
            this.txtPrimeryName.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 26;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(331, 268);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(136, 43);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(8, 102);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(145, 24);
            this.materialLabel15.TabIndex = 33;
            this.materialLabel15.Text = "Primary Contact";
            // 
            // txtPrimeryEmail
            // 
            this.txtPrimeryEmail.Depth = 0;
            this.txtPrimeryEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeryEmail.Hint = "";
            this.txtPrimeryEmail.Location = new System.Drawing.Point(195, 138);
            this.txtPrimeryEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimeryEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrimeryEmail.Name = "txtPrimeryEmail";
            this.txtPrimeryEmail.PasswordChar = '\0';
            this.txtPrimeryEmail.SelectedText = "";
            this.txtPrimeryEmail.SelectionLength = 0;
            this.txtPrimeryEmail.SelectionStart = 0;
            this.txtPrimeryEmail.Size = new System.Drawing.Size(287, 28);
            this.txtPrimeryEmail.TabIndex = 19;
            this.txtPrimeryEmail.UseSystemPasswordChar = false;
            // 
            // txtPrimeryContact
            // 
            this.txtPrimeryContact.Depth = 0;
            this.txtPrimeryContact.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeryContact.Hint = "";
            this.txtPrimeryContact.Location = new System.Drawing.Point(195, 102);
            this.txtPrimeryContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimeryContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrimeryContact.Name = "txtPrimeryContact";
            this.txtPrimeryContact.PasswordChar = '\0';
            this.txtPrimeryContact.SelectedText = "";
            this.txtPrimeryContact.SelectionLength = 0;
            this.txtPrimeryContact.SelectionStart = 0;
            this.txtPrimeryContact.Size = new System.Drawing.Size(287, 28);
            this.txtPrimeryContact.TabIndex = 18;
            this.txtPrimeryContact.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(8, 66);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(131, 24);
            this.materialLabel14.TabIndex = 35;
            this.materialLabel14.Text = "Primary Name";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(8, 36);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(83, 24);
            this.materialLabel11.TabIndex = 41;
            this.materialLabel11.Text = "PAN No.";
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompany";
            this.ShowInTaskbar = false;
            this.Text = "Register Company";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spcompanyTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cAManagerDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spcustomerGroupSelectBindingSource;
        private DataSet1TableAdapters.sp_customerGroupSelectTableAdapter sp_customerGroupSelectTableAdapter;
        private System.Windows.Forms.BindingSource spcompanyTypeBindingSource;
        private DataSet1TableAdapters.sp_companyTypeTableAdapter sp_companyTypeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private CAManagerDataSet cAManagerDataSet;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsearch;
        private MaterialSkin.Controls.MaterialLabel lblMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private System.Windows.Forms.ComboBox cmbCustGroup;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private System.Windows.Forms.ComboBox cmbType;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMobile;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFoundationDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCompanyCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFileNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPF;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTAN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtESIC;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGST;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTIN;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCIN;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnClear;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPAN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdhar;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVoterId;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrimeryName;
        private FontAwesome.Sharp.IconButton btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrimeryEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrimeryContact;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
    }
}