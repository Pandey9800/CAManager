
namespace CAManager
{
    partial class frmFirm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrefix = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtWork = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMob = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPersonEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPersonContact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPersonName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fDS = new CAManager.fDS();
            this.spfirmNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_firmNameTableAdapter = new CAManager.fDSTableAdapters.sp_firmNameTableAdapter();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmPrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGST = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPAN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfirmNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 365);
            this.panel1.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmNameDataGridViewTextBoxColumn,
            this.firmPrefixDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.gSTDataGridViewTextBoxColumn,
            this.pANDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn,
            this.personContactDataGridViewTextBoxColumn,
            this.personEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spfirmNameBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1750, 365);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconSize = 26;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1597, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(107, 39);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClear.Location = new System.Drawing.Point(1597, 126);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(108, 39);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtGST);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.txtPAN);
            this.groupBox1.Controls.Add(this.txtPrefix);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.txtWork);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtMob);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 197);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firm Details";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Depth = 0;
            this.txtPrefix.Hint = "";
            this.txtPrefix.Location = new System.Drawing.Point(227, 58);
            this.txtPrefix.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.PasswordChar = '\0';
            this.txtPrefix.SelectedText = "";
            this.txtPrefix.SelectionLength = 0;
            this.txtPrefix.SelectionStart = 0;
            this.txtPrefix.Size = new System.Drawing.Size(295, 28);
            this.txtPrefix.TabIndex = 41;
            this.txtPrefix.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(51, 58);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(103, 24);
            this.materialLabel11.TabIndex = 40;
            this.materialLabel11.Text = "Firm Prefix";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(52, 160);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(54, 24);
            this.materialLabel10.TabIndex = 30;
            this.materialLabel10.Text = "Work";
            // 
            // txtWork
            // 
            this.txtWork.Depth = 0;
            this.txtWork.Hint = "";
            this.txtWork.Location = new System.Drawing.Point(227, 156);
            this.txtWork.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWork.Name = "txtWork";
            this.txtWork.PasswordChar = '\0';
            this.txtWork.SelectedText = "";
            this.txtWork.SelectionLength = 0;
            this.txtWork.SelectionStart = 0;
            this.txtWork.Size = new System.Drawing.Size(295, 28);
            this.txtWork.TabIndex = 31;
            this.txtWork.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Firm Name";
            // 
            // txtMob
            // 
            this.txtMob.Depth = 0;
            this.txtMob.Hint = "";
            this.txtMob.Location = new System.Drawing.Point(227, 92);
            this.txtMob.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMob.Name = "txtMob";
            this.txtMob.PasswordChar = '\0';
            this.txtMob.SelectedText = "";
            this.txtMob.SelectionLength = 0;
            this.txtMob.SelectionStart = 0;
            this.txtMob.Size = new System.Drawing.Size(295, 28);
            this.txtMob.TabIndex = 39;
            this.txtMob.UseSystemPasswordChar = false;
            // 
            // txtFName
            // 
            this.txtFName.Depth = 0;
            this.txtFName.Hint = "";
            this.txtFName.Location = new System.Drawing.Point(227, 19);
            this.txtFName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFName.Name = "txtFName";
            this.txtFName.PasswordChar = '\0';
            this.txtFName.SelectedText = "";
            this.txtFName.SelectionLength = 0;
            this.txtFName.SelectionStart = 0;
            this.txtFName.Size = new System.Drawing.Size(295, 28);
            this.txtFName.TabIndex = 1;
            this.txtFName.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(51, 92);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(69, 24);
            this.materialLabel9.TabIndex = 38;
            this.materialLabel9.Text = "Mobile";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(227, 126);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(295, 28);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(51, 126);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(58, 24);
            this.materialLabel8.TabIndex = 36;
            this.materialLabel8.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPersonEmail);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.txtPersonContact);
            this.groupBox2.Controls.Add(this.txtPersonName);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Location = new System.Drawing.Point(1045, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 185);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Details";
            // 
            // txtPersonEmail
            // 
            this.txtPersonEmail.Depth = 0;
            this.txtPersonEmail.Hint = "";
            this.txtPersonEmail.Location = new System.Drawing.Point(224, 89);
            this.txtPersonEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPersonEmail.Name = "txtPersonEmail";
            this.txtPersonEmail.PasswordChar = '\0';
            this.txtPersonEmail.SelectedText = "";
            this.txtPersonEmail.SelectionLength = 0;
            this.txtPersonEmail.SelectionStart = 0;
            this.txtPersonEmail.Size = new System.Drawing.Size(281, 28);
            this.txtPersonEmail.TabIndex = 51;
            this.txtPersonEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(15, 56);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(139, 24);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "Person Contact";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(15, 89);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(122, 24);
            this.materialLabel7.TabIndex = 50;
            this.materialLabel7.Text = "Person Email";
            // 
            // txtPersonContact
            // 
            this.txtPersonContact.Depth = 0;
            this.txtPersonContact.Hint = "";
            this.txtPersonContact.Location = new System.Drawing.Point(224, 52);
            this.txtPersonContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPersonContact.Name = "txtPersonContact";
            this.txtPersonContact.PasswordChar = '\0';
            this.txtPersonContact.SelectedText = "";
            this.txtPersonContact.SelectionLength = 0;
            this.txtPersonContact.SelectionStart = 0;
            this.txtPersonContact.Size = new System.Drawing.Size(281, 28);
            this.txtPersonContact.TabIndex = 49;
            this.txtPersonContact.UseSystemPasswordChar = false;
            // 
            // txtPersonName
            // 
            this.txtPersonName.Depth = 0;
            this.txtPersonName.Hint = "";
            this.txtPersonName.Location = new System.Drawing.Point(224, 21);
            this.txtPersonName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.PasswordChar = '\0';
            this.txtPersonName.SelectedText = "";
            this.txtPersonName.SelectionLength = 0;
            this.txtPersonName.SelectionStart = 0;
            this.txtPersonName.Size = new System.Drawing.Size(281, 28);
            this.txtPersonName.TabIndex = 47;
            this.txtPersonName.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(15, 23);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(125, 24);
            this.materialLabel5.TabIndex = 46;
            this.materialLabel5.Text = "Person Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1750, 209);
            this.panel2.TabIndex = 43;
            // 
            // fDS
            // 
            this.fDS.DataSetName = "fDS";
            this.fDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spfirmNameBindingSource
            // 
            this.spfirmNameBindingSource.DataMember = "sp_firmName";
            this.spfirmNameBindingSource.DataSource = this.fDS;
            // 
            // sp_firmNameTableAdapter
            // 
            this.sp_firmNameTableAdapter.ClearBeforeFill = true;
            // 
            // firmNameDataGridViewTextBoxColumn
            // 
            this.firmNameDataGridViewTextBoxColumn.DataPropertyName = "firmName";
            this.firmNameDataGridViewTextBoxColumn.HeaderText = "firmName";
            this.firmNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmNameDataGridViewTextBoxColumn.Name = "firmNameDataGridViewTextBoxColumn";
            this.firmNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firmPrefixDataGridViewTextBoxColumn
            // 
            this.firmPrefixDataGridViewTextBoxColumn.DataPropertyName = "firmPrefix";
            this.firmPrefixDataGridViewTextBoxColumn.HeaderText = "firmPrefix";
            this.firmPrefixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firmPrefixDataGridViewTextBoxColumn.Name = "firmPrefixDataGridViewTextBoxColumn";
            this.firmPrefixDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmPrefixDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // gSTDataGridViewTextBoxColumn
            // 
            this.gSTDataGridViewTextBoxColumn.DataPropertyName = "GST";
            this.gSTDataGridViewTextBoxColumn.HeaderText = "GST";
            this.gSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gSTDataGridViewTextBoxColumn.Name = "gSTDataGridViewTextBoxColumn";
            this.gSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // pANDataGridViewTextBoxColumn
            // 
            this.pANDataGridViewTextBoxColumn.DataPropertyName = "PAN";
            this.pANDataGridViewTextBoxColumn.HeaderText = "PAN";
            this.pANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pANDataGridViewTextBoxColumn.Name = "pANDataGridViewTextBoxColumn";
            this.pANDataGridViewTextBoxColumn.ReadOnly = true;
            this.pANDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "personName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "personName";
            this.personNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            this.personNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.personNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personContactDataGridViewTextBoxColumn
            // 
            this.personContactDataGridViewTextBoxColumn.DataPropertyName = "personContact";
            this.personContactDataGridViewTextBoxColumn.HeaderText = "personContact";
            this.personContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personContactDataGridViewTextBoxColumn.Name = "personContactDataGridViewTextBoxColumn";
            this.personContactDataGridViewTextBoxColumn.ReadOnly = true;
            this.personContactDataGridViewTextBoxColumn.Width = 125;
            // 
            // personEmailDataGridViewTextBoxColumn
            // 
            this.personEmailDataGridViewTextBoxColumn.DataPropertyName = "personEmail";
            this.personEmailDataGridViewTextBoxColumn.HeaderText = "personEmail";
            this.personEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personEmailDataGridViewTextBoxColumn.Name = "personEmailDataGridViewTextBoxColumn";
            this.personEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.personEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(545, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 24);
            this.materialLabel2.TabIndex = 42;
            this.materialLabel2.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(720, 19);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(295, 28);
            this.txtAddress.TabIndex = 43;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtGST
            // 
            this.txtGST.Depth = 0;
            this.txtGST.Hint = "";
            this.txtGST.Location = new System.Drawing.Point(720, 56);
            this.txtGST.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGST.Name = "txtGST";
            this.txtGST.PasswordChar = '\0';
            this.txtGST.SelectedText = "";
            this.txtGST.SelectionLength = 0;
            this.txtGST.SelectionStart = 0;
            this.txtGST.Size = new System.Drawing.Size(295, 28);
            this.txtGST.TabIndex = 45;
            this.txtGST.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(545, 60);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 24);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "GSTIN / UIN";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(545, 93);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 24);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "PAN";
            // 
            // txtPAN
            // 
            this.txtPAN.Depth = 0;
            this.txtPAN.Hint = "";
            this.txtPAN.Location = new System.Drawing.Point(720, 89);
            this.txtPAN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.PasswordChar = '\0';
            this.txtPAN.SelectedText = "";
            this.txtPAN.SelectionLength = 0;
            this.txtPAN.SelectionStart = 0;
            this.txtPAN.Size = new System.Drawing.Size(295, 28);
            this.txtPAN.TabIndex = 47;
            this.txtPAN.UseSystemPasswordChar = false;
            // 
            // frmFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmFirm";
            this.Text = "frmFirm";
            this.Load += new System.EventHandler(this.frmFirm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfirmNameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrefix;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtWork;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMob;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFName;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPersonEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPersonContact;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPersonName;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNmaeDataGridViewTextBoxColumn;
        private fDS fDS;
        private System.Windows.Forms.BindingSource spfirmNameBindingSource;
        private fDSTableAdapters.sp_firmNameTableAdapter sp_firmNameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmPrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personEmailDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGST;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPAN;
    }
}