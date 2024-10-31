
namespace CAManager
{
    partial class frmCompanyFees
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
            this.lbldpt = new MaterialSkin.Controls.MaterialLabel();
            this.lblComp = new MaterialSkin.Controls.MaterialLabel();
            this.lblFee = new MaterialSkin.Controls.MaterialLabel();
            this.spdeptSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new CAManager.DataSet1();
            this.cmbCC = new System.Windows.Forms.ComboBox();
            this.spcompanySelectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spcompanySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFee = new System.Windows.Forms.DataGridView();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.lblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.sp_deptSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_deptSelectTableAdapter();
            this.sp_companySelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_companySelectTableAdapter();
            this.sp_FeesSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_FeesSelectTableAdapter();
            this.spFeesSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtFeesAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFeesSelectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldpt
            // 
            this.lbldpt.AutoSize = true;
            this.lbldpt.Depth = 0;
            this.lbldpt.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbldpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldpt.Location = new System.Drawing.Point(89, 82);
            this.lbldpt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldpt.Name = "lbldpt";
            this.lbldpt.Size = new System.Drawing.Size(108, 24);
            this.lbldpt.TabIndex = 0;
            this.lbldpt.Text = "Department";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Depth = 0;
            this.lblComp.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblComp.Location = new System.Drawing.Point(271, 82);
            this.lblComp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(146, 24);
            this.lblComp.TabIndex = 1;
            this.lblComp.Text = "Company Name";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Depth = 0;
            this.lblFee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFee.Location = new System.Drawing.Point(493, 84);
            this.lblFee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(122, 24);
            this.lblFee.TabIndex = 2;
            this.lblFee.Text = "Fees Amount";
            // 
            // spdeptSelectBindingSource
            // 
            this.spdeptSelectBindingSource.DataMember = "sp_deptSelect";
            this.spdeptSelectBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCC
            // 
            this.cmbCC.DataSource = this.spcompanySelectBindingSource1;
            this.cmbCC.DisplayMember = "Name";
            this.cmbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCC.FormattingEnabled = true;
            this.cmbCC.Location = new System.Drawing.Point(277, 111);
            this.cmbCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCC.Name = "cmbCC";
            this.cmbCC.Size = new System.Drawing.Size(163, 24);
            this.cmbCC.TabIndex = 4;
            this.cmbCC.ValueMember = "CompanyCode";
            // 
            // spcompanySelectBindingSource1
            // 
            this.spcompanySelectBindingSource1.DataMember = "sp_companySelect";
            this.spcompanySelectBindingSource1.DataSource = this.dataSet11;
            // 
            // spcompanySelectBindingSource
            // 
            this.spcompanySelectBindingSource.DataMember = "sp_companySelect";
            this.spcompanySelectBindingSource.DataSource = this.dataSet11;
            // 
            // dgvFee
            // 
            this.dgvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFee.Location = new System.Drawing.Point(0, 258);
            this.dgvFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFee.Name = "dgvFee";
            this.dgvFee.RowHeadersWidth = 51;
            this.dgvFee.RowTemplate.Height = 24;
            this.dgvFee.Size = new System.Drawing.Size(1321, 442);
            this.dgvFee.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(732, 100);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(136, 43);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Depth = 0;
            this.lblMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(237, 190);
            this.lblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 24);
            this.lblMsg.TabIndex = 25;
            // 
            // sp_deptSelectTableAdapter
            // 
            this.sp_deptSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_companySelectTableAdapter
            // 
            this.sp_companySelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_FeesSelectTableAdapter
            // 
            this.sp_FeesSelectTableAdapter.ClearBeforeFill = true;
            // 
            // spFeesSelectBindingSource
            // 
            this.spFeesSelectBindingSource.DataMember = "sp_FeesSelect";
            this.spFeesSelectBindingSource.DataSource = this.dataSet11;
            // 
            // cmbDept
            // 
            this.cmbDept.DataSource = this.spFeesSelectBindingSource;
            this.cmbDept.DisplayMember = "department";
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.Location = new System.Drawing.Point(97, 111);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(129, 24);
            this.cmbDept.TabIndex = 3;
            this.cmbDept.ValueMember = "fees";
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // txtFeesAmount
            // 
            this.txtFeesAmount.Depth = 0;
            this.txtFeesAmount.Hint = "";
            this.txtFeesAmount.Location = new System.Drawing.Point(499, 111);
            this.txtFeesAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFeesAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFeesAmount.Name = "txtFeesAmount";
            this.txtFeesAmount.PasswordChar = '\0';
            this.txtFeesAmount.SelectedText = "";
            this.txtFeesAmount.SelectionLength = 0;
            this.txtFeesAmount.SelectionStart = 0;
            this.txtFeesAmount.Size = new System.Drawing.Size(144, 28);
            this.txtFeesAmount.TabIndex = 27;
            this.txtFeesAmount.UseSystemPasswordChar = false;
            // 
            // frmCompanyFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 700);
            this.Controls.Add(this.txtFeesAmount);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvFee);
            this.Controls.Add(this.cmbCC);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lbldpt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCompanyFees";
            this.Text = "frmCompanyFees";
            this.Load += new System.EventHandler(this.frmCompanyFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFeesSelectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbldpt;
        private MaterialSkin.Controls.MaterialLabel lblComp;
        private MaterialSkin.Controls.MaterialLabel lblFee;
        private System.Windows.Forms.ComboBox cmbCC;
        private System.Windows.Forms.DataGridView dgvFee;
        private FontAwesome.Sharp.IconButton btnSave;
        private MaterialSkin.Controls.MaterialLabel lblMsg;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource spdeptSelectBindingSource;
        private DataSet1TableAdapters.sp_deptSelectTableAdapter sp_deptSelectTableAdapter;
        private System.Windows.Forms.BindingSource spcompanySelectBindingSource;
        private DataSet1TableAdapters.sp_companySelectTableAdapter sp_companySelectTableAdapter;
        private DataSet1TableAdapters.sp_FeesSelectTableAdapter sp_FeesSelectTableAdapter;
        private System.Windows.Forms.BindingSource spcompanySelectBindingSource1;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.BindingSource spFeesSelectBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFeesAmount;
    }
}