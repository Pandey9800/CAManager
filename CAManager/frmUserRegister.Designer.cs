namespace CAManager
{
    partial class frmUserRegister
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMobile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdharNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.spdeptSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.sp_deptSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_deptSelectTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.txtId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 86);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(140, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(219, 28);
            this.txtName.TabIndex = 3;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(140, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(219, 28);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 15);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(140, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(219, 28);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 50);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 24);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Password";
            // 
            // txtMobile
            // 
            this.txtMobile.Depth = 0;
            this.txtMobile.Hint = "";
            this.txtMobile.Location = new System.Drawing.Point(140, 122);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.Size = new System.Drawing.Size(219, 28);
            this.txtMobile.TabIndex = 4;
            this.txtMobile.UseSystemPasswordChar = false;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 122);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 24);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Mobile No.";
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(140, 158);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(219, 28);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(13, 158);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Address";
            // 
            // txtAdharNo
            // 
            this.txtAdharNo.Depth = 0;
            this.txtAdharNo.Hint = "";
            this.txtAdharNo.Location = new System.Drawing.Point(140, 193);
            this.txtAdharNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdharNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdharNo.Name = "txtAdharNo";
            this.txtAdharNo.PasswordChar = '\0';
            this.txtAdharNo.SelectedText = "";
            this.txtAdharNo.SelectionLength = 0;
            this.txtAdharNo.SelectionStart = 0;
            this.txtAdharNo.Size = new System.Drawing.Size(219, 28);
            this.txtAdharNo.TabIndex = 6;
            this.txtAdharNo.UseSystemPasswordChar = false;
            this.txtAdharNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdharNo_KeyPress);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(13, 193);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(94, 24);
            this.materialLabel6.TabIndex = 16;
            this.materialLabel6.Text = "Adhar No.";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(15, 271);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(48, 24);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Role";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(15, 238);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(108, 24);
            this.materialLabel8.TabIndex = 18;
            this.materialLabel8.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DataSource = this.spdeptSelectBindingSource;
            this.cmbDepartment.DisplayMember = "department";
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(142, 239);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(217, 24);
            this.cmbDepartment.TabIndex = 8;
            this.cmbDepartment.ValueMember = "department";
            // 
            // spdeptSelectBindingSource
            // 
            this.spdeptSelectBindingSource.DataMember = "sp_deptSelect";
            this.spdeptSelectBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "",
            "HOD",
            "PROCESS",
            "RECEPTIONIST",
            "BILLING CLERK",
            "ADMIN"});
            this.cmbRole.Location = new System.Drawing.Point(142, 272);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(217, 24);
            this.cmbRole.TabIndex = 9;
            // 
            // sp_deptSelectTableAdapter
            // 
            this.sp_deptSelectTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtAdharNo);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 522);
            this.panel1.TabIndex = 21;
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
            this.btnClear.Location = new System.Drawing.Point(30, 329);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(108, 39);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtId
            // 
            this.txtId.Depth = 0;
            this.txtId.Hint = "";
            this.txtId.Location = new System.Drawing.Point(140, 481);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.Size = new System.Drawing.Size(219, 28);
            this.txtId.TabIndex = 20;
            this.txtId.UseSystemPasswordChar = false;
            this.txtId.Visible = false;
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
            this.btnSave.IconSize = 22;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(251, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(108, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gvUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(376, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 522);
            this.panel2.TabIndex = 21;
            // 
            // gvUser
            // 
            this.gvUser.AllowUserToAddRows = false;
            this.gvUser.AllowUserToDeleteRows = false;
            this.gvUser.BackgroundColor = System.Drawing.Color.White;
            this.gvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvUser.Location = new System.Drawing.Point(0, 0);
            this.gvUser.Margin = new System.Windows.Forms.Padding(4);
            this.gvUser.Name = "gvUser";
            this.gvUser.RowHeadersWidth = 51;
            this.gvUser.Size = new System.Drawing.Size(625, 522);
            this.gvUser.TabIndex = 20;
            this.gvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUser_CellClick);
            this.gvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUser_CellContentClick);
            this.gvUser.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvUser_RowsAdded);
            // 
            // frmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserRegister";
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.frmUserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMobile;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdharNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbRole;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spdeptSelectBindingSource;
        private DataSet1TableAdapters.sp_deptSelectTableAdapter sp_deptSelectTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvUser;
        private FontAwesome.Sharp.IconButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtId;
        private FontAwesome.Sharp.IconButton btnClear;
    }
}