namespace CAManager
{
    partial class frmDetailMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabCustomerGroup = new System.Windows.Forms.TabPage();
            this.gvCustGroup = new System.Windows.Forms.DataGridView();
            this.customerGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spcustomerGroupSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.txtGroupCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCustSave = new FontAwesome.Sharp.IconButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCustomerGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabDepartment = new System.Windows.Forms.TabPage();
            this.gvDept = new System.Windows.Forms.DataGridView();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spdeptSelectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtActivity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDeptSave = new FontAwesome.Sharp.IconButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDepartment = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabFees = new System.Windows.Forms.TabPage();
            this.gvFees = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spFeesSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnFeesSave = new FontAwesome.Sharp.IconButton();
            this.cmbFeesActivity = new System.Windows.Forms.ComboBox();
            this.spdeptSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFees = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.spBankSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fDS = new CAManager.fDS();
            this.reportFinalDS = new CAManager.ReportFinalDS();
            this.sp_deptSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_deptSelectTableAdapter();
            this.sp_BankDetailsTableAdapter = new CAManager.DataSet1TableAdapters.sp_BankDetailsTableAdapter();
            this.sp_FeesSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_FeesSelectTableAdapter();
            this.sp_customerGroupSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_customerGroupSelectTableAdapter();
            this.sp_BankSelTableAdapter = new CAManager.fDSTableAdapters.sp_BankSelTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBankName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBankNumner = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBankSave = new FontAwesome.Sharp.IconButton();
            this.cmbBankCompany = new System.Windows.Forms.ComboBox();
            this.txtIFSC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBankBranch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.gvBank = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBank = new System.Windows.Forms.TabPage();
            this.reportDS = new CAManager.reportDS();
            this.spcompanySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_companySelectTableAdapter = new CAManager.reportDSTableAdapters.sp_companySelectTableAdapter();
            this.panel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabCustomerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFeesSelectBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBankSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFinalDS)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 71);
            this.panel1.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(126)))), ((int)(((byte)(139)))));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1124, 71);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabCustomerGroup);
            this.materialTabControl1.Controls.Add(this.tabDepartment);
            this.materialTabControl1.Controls.Add(this.tabFees);
            this.materialTabControl1.Controls.Add(this.tabBank);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 71);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1124, 571);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.materialTabControl1_Selected);
            // 
            // tabCustomerGroup
            // 
            this.tabCustomerGroup.Controls.Add(this.gvCustGroup);
            this.tabCustomerGroup.Controls.Add(this.panel2);
            this.tabCustomerGroup.Location = new System.Drawing.Point(4, 25);
            this.tabCustomerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.tabCustomerGroup.Name = "tabCustomerGroup";
            this.tabCustomerGroup.Padding = new System.Windows.Forms.Padding(4);
            this.tabCustomerGroup.Size = new System.Drawing.Size(1116, 542);
            this.tabCustomerGroup.TabIndex = 0;
            this.tabCustomerGroup.Text = "Customer Group";
            this.tabCustomerGroup.UseVisualStyleBackColor = true;
            // 
            // gvCustGroup
            // 
            this.gvCustGroup.AllowUserToAddRows = false;
            this.gvCustGroup.AllowUserToDeleteRows = false;
            this.gvCustGroup.AutoGenerateColumns = false;
            this.gvCustGroup.BackgroundColor = System.Drawing.Color.White;
            this.gvCustGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerGroupDataGridViewTextBoxColumn,
            this.Code});
            this.gvCustGroup.DataSource = this.spcustomerGroupSelectBindingSource;
            this.gvCustGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCustGroup.Location = new System.Drawing.Point(303, 4);
            this.gvCustGroup.Margin = new System.Windows.Forms.Padding(4);
            this.gvCustGroup.Name = "gvCustGroup";
            this.gvCustGroup.ReadOnly = true;
            this.gvCustGroup.RowHeadersWidth = 51;
            this.gvCustGroup.Size = new System.Drawing.Size(809, 534);
            this.gvCustGroup.TabIndex = 4;
            // 
            // customerGroupDataGridViewTextBoxColumn
            // 
            this.customerGroupDataGridViewTextBoxColumn.DataPropertyName = "customerGroup";
            this.customerGroupDataGridViewTextBoxColumn.HeaderText = "customerGroup";
            this.customerGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerGroupDataGridViewTextBoxColumn.Name = "customerGroupDataGridViewTextBoxColumn";
            this.customerGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Group Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 125;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.txtGroupCode);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.btnCustSave);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.txtCustomerGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 534);
            this.panel2.TabIndex = 0;
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
            this.btnClear.Location = new System.Drawing.Point(37, 197);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(108, 39);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Depth = 0;
            this.txtGroupCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupCode.Hint = "group code";
            this.txtGroupCode.Location = new System.Drawing.Point(12, 102);
            this.txtGroupCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroupCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.PasswordChar = '\0';
            this.txtGroupCode.SelectedText = "";
            this.txtGroupCode.SelectionLength = 0;
            this.txtGroupCode.SelectionStart = 0;
            this.txtGroupCode.Size = new System.Drawing.Size(268, 28);
            this.txtGroupCode.TabIndex = 4;
            this.txtGroupCode.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(8, 74);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(110, 24);
            this.materialLabel9.TabIndex = 3;
            this.materialLabel9.Text = "Group Code";
            // 
            // btnCustSave
            // 
            this.btnCustSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnCustSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCustSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSave.ForeColor = System.Drawing.Color.White;
            this.btnCustSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnCustSave.IconColor = System.Drawing.Color.White;
            this.btnCustSave.IconSize = 22;
            this.btnCustSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustSave.Location = new System.Drawing.Point(173, 197);
            this.btnCustSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Rotation = 0D;
            this.btnCustSave.Size = new System.Drawing.Size(107, 39);
            this.btnCustSave.TabIndex = 2;
            this.btnCustSave.Text = "Save";
            this.btnCustSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustSave.UseVisualStyleBackColor = false;
            this.btnCustSave.Click += new System.EventHandler(this.btnCustSave_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 18);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Group Name";
            // 
            // txtCustomerGroup
            // 
            this.txtCustomerGroup.Depth = 0;
            this.txtCustomerGroup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerGroup.Hint = "group name";
            this.txtCustomerGroup.Location = new System.Drawing.Point(12, 45);
            this.txtCustomerGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCustomerGroup.Name = "txtCustomerGroup";
            this.txtCustomerGroup.PasswordChar = '\0';
            this.txtCustomerGroup.SelectedText = "";
            this.txtCustomerGroup.SelectionLength = 0;
            this.txtCustomerGroup.SelectionStart = 0;
            this.txtCustomerGroup.Size = new System.Drawing.Size(268, 28);
            this.txtCustomerGroup.TabIndex = 0;
            this.txtCustomerGroup.UseSystemPasswordChar = false;
            // 
            // tabDepartment
            // 
            this.tabDepartment.Controls.Add(this.gvDept);
            this.tabDepartment.Controls.Add(this.panel3);
            this.tabDepartment.Location = new System.Drawing.Point(4, 25);
            this.tabDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.tabDepartment.Name = "tabDepartment";
            this.tabDepartment.Padding = new System.Windows.Forms.Padding(4);
            this.tabDepartment.Size = new System.Drawing.Size(1116, 542);
            this.tabDepartment.TabIndex = 1;
            this.tabDepartment.Text = "Department Master";
            this.tabDepartment.UseVisualStyleBackColor = true;
            // 
            // gvDept
            // 
            this.gvDept.AllowUserToAddRows = false;
            this.gvDept.AllowUserToDeleteRows = false;
            this.gvDept.AutoGenerateColumns = false;
            this.gvDept.BackgroundColor = System.Drawing.Color.White;
            this.gvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn});
            this.gvDept.DataSource = this.spdeptSelectBindingSource1;
            this.gvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDept.Location = new System.Drawing.Point(399, 4);
            this.gvDept.Margin = new System.Windows.Forms.Padding(4);
            this.gvDept.Name = "gvDept";
            this.gvDept.ReadOnly = true;
            this.gvDept.RowHeadersWidth = 51;
            this.gvDept.Size = new System.Drawing.Size(713, 534);
            this.gvDept.TabIndex = 4;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityDataGridViewTextBoxColumn1
            // 
            this.activityDataGridViewTextBoxColumn1.DataPropertyName = "activity";
            this.activityDataGridViewTextBoxColumn1.HeaderText = "activity";
            this.activityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.activityDataGridViewTextBoxColumn1.Name = "activityDataGridViewTextBoxColumn1";
            this.activityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // spdeptSelectBindingSource1
            // 
            this.spdeptSelectBindingSource1.DataMember = "sp_deptSelect";
            this.spdeptSelectBindingSource1.DataSource = this.dataSet1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.materialLabel12);
            this.panel3.Controls.Add(this.txtActivity);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.materialLabel8);
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Controls.Add(this.btnDeptSave);
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Controls.Add(this.txtDepartment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 534);
            this.panel3.TabIndex = 1;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(11, 86);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(72, 24);
            this.materialLabel12.TabIndex = 44;
            this.materialLabel12.Text = "Activity";
            // 
            // txtActivity
            // 
            this.txtActivity.Depth = 0;
            this.txtActivity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.Hint = "Activity";
            this.txtActivity.Location = new System.Drawing.Point(143, 86);
            this.txtActivity.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.PasswordChar = '\0';
            this.txtActivity.SelectedText = "";
            this.txtActivity.SelectionLength = 0;
            this.txtActivity.SelectionStart = 0;
            this.txtActivity.Size = new System.Drawing.Size(239, 28);
            this.txtActivity.TabIndex = 43;
            this.txtActivity.UseSystemPasswordChar = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Typo3;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 22;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(56, 149);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(108, 39);
            this.iconButton1.TabIndex = 42;
            this.iconButton1.Text = "Clear";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(7, 50);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(54, 24);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Depth = 0;
            this.txtCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Hint = "code";
            this.txtCode.Location = new System.Drawing.Point(140, 50);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.Size = new System.Drawing.Size(239, 28);
            this.txtCode.TabIndex = 3;
            this.txtCode.UseSystemPasswordChar = false;
            // 
            // btnDeptSave
            // 
            this.btnDeptSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnDeptSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeptSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptSave.ForeColor = System.Drawing.Color.White;
            this.btnDeptSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnDeptSave.IconColor = System.Drawing.Color.White;
            this.btnDeptSave.IconSize = 22;
            this.btnDeptSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeptSave.Location = new System.Drawing.Point(269, 149);
            this.btnDeptSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeptSave.Name = "btnDeptSave";
            this.btnDeptSave.Rotation = 0D;
            this.btnDeptSave.Size = new System.Drawing.Size(107, 39);
            this.btnDeptSave.TabIndex = 2;
            this.btnDeptSave.Text = "Save";
            this.btnDeptSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeptSave.UseVisualStyleBackColor = false;
            this.btnDeptSave.Click += new System.EventHandler(this.btnDeptSave_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 20);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Depth = 0;
            this.txtDepartment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Hint = "department";
            this.txtDepartment.Location = new System.Drawing.Point(140, 15);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.PasswordChar = '\0';
            this.txtDepartment.SelectedText = "";
            this.txtDepartment.SelectionLength = 0;
            this.txtDepartment.SelectionStart = 0;
            this.txtDepartment.Size = new System.Drawing.Size(239, 28);
            this.txtDepartment.TabIndex = 0;
            this.txtDepartment.UseSystemPasswordChar = false;
            // 
            // tabFees
            // 
            this.tabFees.Controls.Add(this.gvFees);
            this.tabFees.Controls.Add(this.panel4);
            this.tabFees.Location = new System.Drawing.Point(4, 25);
            this.tabFees.Margin = new System.Windows.Forms.Padding(4);
            this.tabFees.Name = "tabFees";
            this.tabFees.Padding = new System.Windows.Forms.Padding(4);
            this.tabFees.Size = new System.Drawing.Size(1116, 542);
            this.tabFees.TabIndex = 2;
            this.tabFees.Text = "Fees Master";
            this.tabFees.UseVisualStyleBackColor = true;
            // 
            // gvFees
            // 
            this.gvFees.AllowUserToAddRows = false;
            this.gvFees.AllowUserToDeleteRows = false;
            this.gvFees.AutoGenerateColumns = false;
            this.gvFees.BackgroundColor = System.Drawing.Color.White;
            this.gvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.activityDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn});
            this.gvFees.DataSource = this.spFeesSelectBindingSource;
            this.gvFees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFees.Location = new System.Drawing.Point(360, 4);
            this.gvFees.Margin = new System.Windows.Forms.Padding(4);
            this.gvFees.Name = "gvFees";
            this.gvFees.ReadOnly = true;
            this.gvFees.RowHeadersWidth = 51;
            this.gvFees.Size = new System.Drawing.Size(752, 534);
            this.gvFees.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            this.activityDataGridViewTextBoxColumn.DataPropertyName = "activity";
            this.activityDataGridViewTextBoxColumn.HeaderText = "activity";
            this.activityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            this.activityDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityDataGridViewTextBoxColumn.Width = 125;
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "fees";
            this.feesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            this.feesDataGridViewTextBoxColumn.ReadOnly = true;
            this.feesDataGridViewTextBoxColumn.Width = 125;
            // 
            // spFeesSelectBindingSource
            // 
            this.spFeesSelectBindingSource.DataMember = "sp_FeesSelect";
            this.spFeesSelectBindingSource.DataSource = this.dataSet1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.btnFeesSave);
            this.panel4.Controls.Add(this.cmbFeesActivity);
            this.panel4.Controls.Add(this.materialLabel5);
            this.panel4.Controls.Add(this.txtFees);
            this.panel4.Controls.Add(this.materialLabel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 534);
            this.panel4.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Typo3;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 22;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(46, 89);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(108, 39);
            this.iconButton2.TabIndex = 42;
            this.iconButton2.Text = "Clear";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnFeesSave
            // 
            this.btnFeesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnFeesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeesSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFeesSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeesSave.ForeColor = System.Drawing.Color.White;
            this.btnFeesSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnFeesSave.IconColor = System.Drawing.Color.White;
            this.btnFeesSave.IconSize = 22;
            this.btnFeesSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeesSave.Location = new System.Drawing.Point(229, 89);
            this.btnFeesSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeesSave.Name = "btnFeesSave";
            this.btnFeesSave.Rotation = 0D;
            this.btnFeesSave.Size = new System.Drawing.Size(107, 39);
            this.btnFeesSave.TabIndex = 6;
            this.btnFeesSave.Text = "Save";
            this.btnFeesSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFeesSave.UseVisualStyleBackColor = false;
            this.btnFeesSave.Click += new System.EventHandler(this.btnFeesSave_Click);
            // 
            // cmbFeesActivity
            // 
            this.cmbFeesActivity.DataSource = this.spdeptSelectBindingSource;
            this.cmbFeesActivity.DisplayMember = "department";
            this.cmbFeesActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeesActivity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeesActivity.FormattingEnabled = true;
            this.cmbFeesActivity.Location = new System.Drawing.Point(93, 17);
            this.cmbFeesActivity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFeesActivity.Name = "cmbFeesActivity";
            this.cmbFeesActivity.Size = new System.Drawing.Size(241, 26);
            this.cmbFeesActivity.TabIndex = 5;
            this.cmbFeesActivity.ValueMember = "department";
            // 
            // spdeptSelectBindingSource
            // 
            this.spdeptSelectBindingSource.DataMember = "sp_deptSelect";
            this.spdeptSelectBindingSource.DataSource = this.dataSet1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(7, 53);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Fees";
            // 
            // txtFees
            // 
            this.txtFees.Depth = 0;
            this.txtFees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Hint = "department";
            this.txtFees.Location = new System.Drawing.Point(93, 53);
            this.txtFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtFees.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.SelectedText = "";
            this.txtFees.SelectionLength = 0;
            this.txtFees.SelectionStart = 0;
            this.txtFees.Size = new System.Drawing.Size(243, 28);
            this.txtFees.TabIndex = 3;
            this.txtFees.Text = "0";
            this.txtFees.UseSystemPasswordChar = false;
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 17);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 24);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Activity";
            // 
            // spBankSelBindingSource
            // 
            this.spBankSelBindingSource.DataMember = "sp_BankSel";
            this.spBankSelBindingSource.DataSource = this.fDS;
            // 
            // fDS
            // 
            this.fDS.DataSetName = "fDS";
            this.fDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportFinalDS
            // 
            this.reportFinalDS.DataSetName = "ReportFinalDS";
            this.reportFinalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_deptSelectTableAdapter
            // 
            this.sp_deptSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BankDetailsTableAdapter
            // 
            this.sp_BankDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // sp_FeesSelectTableAdapter
            // 
            this.sp_FeesSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_customerGroupSelectTableAdapter
            // 
            this.sp_customerGroupSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BankSelTableAdapter
            // 
            this.sp_BankSelTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.iconButton3);
            this.panel5.Controls.Add(this.materialLabel10);
            this.panel5.Controls.Add(this.txtBankBranch);
            this.panel5.Controls.Add(this.materialLabel11);
            this.panel5.Controls.Add(this.txtIFSC);
            this.panel5.Controls.Add(this.cmbBankCompany);
            this.panel5.Controls.Add(this.btnBankSave);
            this.panel5.Controls.Add(this.materialLabel7);
            this.panel5.Controls.Add(this.materialLabel6);
            this.panel5.Controls.Add(this.txtBankNumner);
            this.panel5.Controls.Add(this.materialLabel4);
            this.panel5.Controls.Add(this.txtBankName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 534);
            this.panel5.TabIndex = 2;
            // 
            // txtBankName
            // 
            this.txtBankName.Depth = 0;
            this.txtBankName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Hint = "bank name";
            this.txtBankName.Location = new System.Drawing.Point(211, 58);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.PasswordChar = '\0';
            this.txtBankName.SelectedText = "";
            this.txtBankName.SelectionLength = 0;
            this.txtBankName.SelectionStart = 0;
            this.txtBankName.Size = new System.Drawing.Size(219, 28);
            this.txtBankName.TabIndex = 0;
            this.txtBankName.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 58);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(108, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Bank Name";
            // 
            // txtBankNumner
            // 
            this.txtBankNumner.Depth = 0;
            this.txtBankNumner.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankNumner.Hint = "account no.";
            this.txtBankNumner.Location = new System.Drawing.Point(211, 122);
            this.txtBankNumner.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankNumner.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBankNumner.Name = "txtBankNumner";
            this.txtBankNumner.PasswordChar = '\0';
            this.txtBankNumner.SelectedText = "";
            this.txtBankNumner.SelectionLength = 0;
            this.txtBankNumner.SelectionStart = 0;
            this.txtBankNumner.Size = new System.Drawing.Size(219, 28);
            this.txtBankNumner.TabIndex = 3;
            this.txtBankNumner.UseSystemPasswordChar = false;
            this.txtBankNumner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankNumner_KeyPress);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 122);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(114, 24);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Account No.";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(21, 18);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(146, 24);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Company Name";
            // 
            // btnBankSave
            // 
            this.btnBankSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnBankSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBankSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankSave.ForeColor = System.Drawing.Color.White;
            this.btnBankSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnBankSave.IconColor = System.Drawing.Color.White;
            this.btnBankSave.IconSize = 22;
            this.btnBankSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankSave.Location = new System.Drawing.Point(301, 202);
            this.btnBankSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnBankSave.Name = "btnBankSave";
            this.btnBankSave.Rotation = 0D;
            this.btnBankSave.Size = new System.Drawing.Size(107, 39);
            this.btnBankSave.TabIndex = 7;
            this.btnBankSave.Text = "Save";
            this.btnBankSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBankSave.UseVisualStyleBackColor = false;
            this.btnBankSave.Click += new System.EventHandler(this.btnBankSave_Click);
            // 
            // cmbBankCompany
            // 
            this.cmbBankCompany.DataSource = this.spcompanySelectBindingSource;
            this.cmbBankCompany.DisplayMember = "CompanyName";
            this.cmbBankCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankCompany.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.cmbBankCompany.FormattingEnabled = true;
            this.cmbBankCompany.Location = new System.Drawing.Point(211, 20);
            this.cmbBankCompany.Name = "cmbBankCompany";
            this.cmbBankCompany.Size = new System.Drawing.Size(219, 26);
            this.cmbBankCompany.TabIndex = 8;
            this.cmbBankCompany.ValueMember = "CompanyCode";
            // 
            // txtIFSC
            // 
            this.txtIFSC.Depth = 0;
            this.txtIFSC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIFSC.Hint = "IFSC Code";
            this.txtIFSC.Location = new System.Drawing.Point(209, 156);
            this.txtIFSC.Margin = new System.Windows.Forms.Padding(4);
            this.txtIFSC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.PasswordChar = '\0';
            this.txtIFSC.SelectedText = "";
            this.txtIFSC.SelectionLength = 0;
            this.txtIFSC.SelectionStart = 0;
            this.txtIFSC.Size = new System.Drawing.Size(219, 28);
            this.txtIFSC.TabIndex = 9;
            this.txtIFSC.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(19, 156);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(102, 24);
            this.materialLabel11.TabIndex = 10;
            this.materialLabel11.Text = "IFSC CODE";
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.Depth = 0;
            this.txtBankBranch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankBranch.Hint = "Branch";
            this.txtBankBranch.Location = new System.Drawing.Point(212, 90);
            this.txtBankBranch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankBranch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.PasswordChar = '\0';
            this.txtBankBranch.SelectedText = "";
            this.txtBankBranch.SelectionLength = 0;
            this.txtBankBranch.SelectionStart = 0;
            this.txtBankBranch.Size = new System.Drawing.Size(219, 28);
            this.txtBankBranch.TabIndex = 11;
            this.txtBankBranch.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(20, 90);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(124, 24);
            this.materialLabel10.TabIndex = 12;
            this.materialLabel10.Text = "Branch Name";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Typo3;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 22;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(104, 202);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(108, 39);
            this.iconButton3.TabIndex = 42;
            this.iconButton3.Text = "Clear";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // gvBank
            // 
            this.gvBank.AllowUserToAddRows = false;
            this.gvBank.AllowUserToDeleteRows = false;
            this.gvBank.BackgroundColor = System.Drawing.Color.White;
            this.gvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvBank.Location = new System.Drawing.Point(448, 4);
            this.gvBank.Margin = new System.Windows.Forms.Padding(4);
            this.gvBank.Name = "gvBank";
            this.gvBank.ReadOnly = true;
            this.gvBank.RowHeadersWidth = 51;
            this.gvBank.Size = new System.Drawing.Size(664, 534);
            this.gvBank.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.bankNameDataGridViewTextBoxColumn,
            this.acountNoDataGridViewTextBoxColumn,
            this.companyCodeDataGridViewTextBoxColumn,
            this.iFSCDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spBankSelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(448, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 534);
            this.dataGridView1.TabIndex = 4;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "branch";
            this.branchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.Width = 125;
            // 
            // iFSCDataGridViewTextBoxColumn
            // 
            this.iFSCDataGridViewTextBoxColumn.DataPropertyName = "IFSC";
            this.iFSCDataGridViewTextBoxColumn.HeaderText = "IFSC";
            this.iFSCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iFSCDataGridViewTextBoxColumn.Name = "iFSCDataGridViewTextBoxColumn";
            this.iFSCDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyCodeDataGridViewTextBoxColumn
            // 
            this.companyCodeDataGridViewTextBoxColumn.DataPropertyName = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.HeaderText = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyCodeDataGridViewTextBoxColumn.Name = "companyCodeDataGridViewTextBoxColumn";
            this.companyCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // acountNoDataGridViewTextBoxColumn
            // 
            this.acountNoDataGridViewTextBoxColumn.DataPropertyName = "acountNo";
            this.acountNoDataGridViewTextBoxColumn.HeaderText = "acountNo";
            this.acountNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acountNoDataGridViewTextBoxColumn.Name = "acountNoDataGridViewTextBoxColumn";
            this.acountNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "bankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "bankName";
            this.bankNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tabBank
            // 
            this.tabBank.Controls.Add(this.dataGridView1);
            this.tabBank.Controls.Add(this.gvBank);
            this.tabBank.Controls.Add(this.panel5);
            this.tabBank.Location = new System.Drawing.Point(4, 25);
            this.tabBank.Margin = new System.Windows.Forms.Padding(4);
            this.tabBank.Name = "tabBank";
            this.tabBank.Padding = new System.Windows.Forms.Padding(4);
            this.tabBank.Size = new System.Drawing.Size(1116, 542);
            this.tabBank.TabIndex = 3;
            this.tabBank.Text = "Bank Master";
            this.tabBank.UseVisualStyleBackColor = true;
            // 
            // reportDS
            // 
            this.reportDS.DataSetName = "reportDS";
            this.reportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spcompanySelectBindingSource
            // 
            this.spcompanySelectBindingSource.DataMember = "sp_companySelect";
            this.spcompanySelectBindingSource.DataSource = this.reportDS;
            // 
            // sp_companySelectTableAdapter
            // 
            this.sp_companySelectTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetailMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 642);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetailMaster";
            this.Text = "Master Details";
            this.Load += new System.EventHandler(this.frmDetailMaster_Load);
            this.panel1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabCustomerGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabFees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFeesSelectBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBankSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFinalDS)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabCustomerGroup;
        private System.Windows.Forms.TabPage tabDepartment;
        private System.Windows.Forms.TabPage tabFees;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCustSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCustomerGroup;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnDeptSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDepartment;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFees;
        private System.Windows.Forms.ComboBox cmbFeesActivity;
        private System.Windows.Forms.DataGridView gvFees;
        private System.Windows.Forms.DataGridView gvDept;
        private System.Windows.Forms.DataGridView gvCustGroup;
        private DataSet1 dataSet1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCode;
        private FontAwesome.Sharp.IconButton btnFeesSave;
        private System.Windows.Forms.BindingSource spdeptSelectBindingSource;
        private DataSet1TableAdapters.sp_deptSelectTableAdapter sp_deptSelectTableAdapter;
        private DataSet1TableAdapters.sp_BankDetailsTableAdapter sp_BankDetailsTableAdapter;
        private System.Windows.Forms.BindingSource spFeesSelectBindingSource;
        private DataSet1TableAdapters.sp_FeesSelectTableAdapter sp_FeesSelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spcustomerGroupSelectBindingSource;
        private DataSet1TableAdapters.sp_customerGroupSelectTableAdapter sp_customerGroupSelectTableAdapter;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGroupCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spdeptSelectBindingSource1;
        private ReportFinalDS reportFinalDS;
        private fDS fDS;
        private System.Windows.Forms.BindingSource spBankSelBindingSource;
        private fDSTableAdapters.sp_BankSelTableAdapter sp_BankSelTableAdapter;
        private System.Windows.Forms.TabPage tabBank;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gvBank;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBankBranch;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIFSC;
        private System.Windows.Forms.ComboBox cmbBankCompany;
        private FontAwesome.Sharp.IconButton btnBankSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBankNumner;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBankName;
        private System.Windows.Forms.BindingSource spcompanySelectBindingSource;
        private reportDS reportDS;
        private reportDSTableAdapters.sp_companySelectTableAdapter sp_companySelectTableAdapter;
    }
}