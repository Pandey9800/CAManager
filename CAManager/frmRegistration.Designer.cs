namespace CAManager
{
    partial class frmRegistration
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch { }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbGroupClient = new System.Windows.Forms.ComboBox();
            this.spcustomerGroupSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.spdeptSelectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spdeptSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbClientFor = new System.Windows.Forms.ComboBox();
            this.fDS = new CAManager.fDS();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.cmbClientName = new System.Windows.Forms.ComboBox();
            this.spcompanySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRegDet = new System.Windows.Forms.TextBox();
            this.lblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sp_deptSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_deptSelectTableAdapter();
            this.sp_customerGroupSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_customerGroupSelectTableAdapter();
            this.sp_companySelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_companySelectTableAdapter();
            this.spselectFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_selectFeesTableAdapter = new CAManager.DataSet1TableAdapters.sp_selectFeesTableAdapter();
            this.reportFinalDS = new CAManager.ReportFinalDS();
            this.spfirmNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_firmNameTableAdapter = new CAManager.fDSTableAdapters.sp_firmNameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFinalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfirmNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroupClient
            // 
            this.cmbGroupClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGroupClient.DataSource = this.spcustomerGroupSelectBindingSource;
            this.cmbGroupClient.DisplayMember = "customerGroup";
            this.cmbGroupClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupClient.FormattingEnabled = true;
            this.cmbGroupClient.Location = new System.Drawing.Point(19, 56);
            this.cmbGroupClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGroupClient.Name = "cmbGroupClient";
            this.cmbGroupClient.Size = new System.Drawing.Size(200, 26);
            this.cmbGroupClient.TabIndex = 11;
            this.cmbGroupClient.ValueMember = "customerGroup";
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(22, 24);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel4.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(189, 26);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Client Group";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.DataSource = this.spdeptSelectBindingSource1;
            this.cmbDepartment.DisplayMember = "Department";
            this.cmbDepartment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(19, 123);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(183, 26);
            this.cmbDepartment.TabIndex = 13;
            this.cmbDepartment.ValueMember = "department";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // spdeptSelectBindingSource1
            // 
            this.spdeptSelectBindingSource1.DataMember = "sp_deptSelect";
            this.spdeptSelectBindingSource1.DataSource = this.dataSet1;
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
            this.materialLabel5.Location = new System.Drawing.Point(14, 93);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel5.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(189, 26);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Department";
            // 
            // cmbClientFor
            // 
            this.cmbClientFor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientFor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientFor.DataSource = this.spfirmNameBindingSource;
            this.cmbClientFor.DisplayMember = "firmPrefix";
            this.cmbClientFor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientFor.FormattingEnabled = true;
            this.cmbClientFor.Location = new System.Drawing.Point(428, 128);
            this.cmbClientFor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientFor.Name = "cmbClientFor";
            this.cmbClientFor.Size = new System.Drawing.Size(168, 26);
            this.cmbClientFor.TabIndex = 15;
            this.cmbClientFor.ValueMember = "firmPrefix";
            // 
            // fDS
            // 
            this.fDS.DataSetName = "fDS";
            this.fDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(423, 98);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel6.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(189, 26);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Firm";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(19, 150);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(175, 24);
            this.materialLabel7.TabIndex = 17;
            this.materialLabel7.Text = "Registration Details";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(19, 328);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(93, 24);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "Comment";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(19, 435);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(75, 24);
            this.materialLabel9.TabIndex = 21;
            this.materialLabel9.Text = "Remark";
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
            this.btnSave.Location = new System.Drawing.Point(252, 597);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(107, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbClientName
            // 
            this.cmbClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spcompanySelectBindingSource, "name", true));
            this.cmbClientName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientName.FormattingEnabled = true;
            this.cmbClientName.Items.AddRange(new object[] {
            ""});
            this.cmbClientName.Location = new System.Drawing.Point(225, 55);
            this.cmbClientName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClientName.Name = "cmbClientName";
            this.cmbClientName.Size = new System.Drawing.Size(202, 26);
            this.cmbClientName.TabIndex = 23;
            this.cmbClientName.SelectedIndexChanged += new System.EventHandler(this.cmbClientName_SelectedIndexChanged);
            // 
            // spcompanySelectBindingSource
            // 
            this.spcompanySelectBindingSource.DataMember = "sp_companySelect";
            this.spcompanySelectBindingSource.DataSource = this.dataSet1;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(17, 355);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(571, 75);
            this.txtComment.TabIndex = 24;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(17, 462);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(571, 75);
            this.txtRemark.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 651);
            this.panel1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileNumber);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.cmbActivity);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtRegDet);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbClientFor);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.cmbGroupClient);
            this.groupBox1.Controls.Add(this.cmbClientName);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(608, 643);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.Location = new System.Drawing.Point(434, 55);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.ReadOnly = true;
            this.txtFileNumber.Size = new System.Drawing.Size(162, 27);
            this.txtFileNumber.TabIndex = 37;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(221, 98);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel3.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(189, 26);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Activity";
            // 
            // cmbActivity
            // 
            this.cmbActivity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbActivity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbActivity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(226, 128);
            this.cmbActivity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(168, 26);
            this.cmbActivity.TabIndex = 36;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(424, 22);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MaximumSize = new System.Drawing.Size(139, 26);
            this.materialLabel2.MinimumSize = new System.Drawing.Size(139, 26);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(139, 26);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "File Num.";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(227, 25);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MaximumSize = new System.Drawing.Size(189, 26);
            this.materialLabel1.MinimumSize = new System.Drawing.Size(189, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 26);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegDet
            // 
            this.txtRegDet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegDet.Location = new System.Drawing.Point(19, 178);
            this.txtRegDet.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegDet.Multiline = true;
            this.txtRegDet.Name = "txtRegDet";
            this.txtRegDet.Size = new System.Drawing.Size(571, 75);
            this.txtRegDet.TabIndex = 27;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Depth = 0;
            this.lblMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(17, 560);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.MaximumSize = new System.Drawing.Size(572, 31);
            this.lblMsg.MinimumSize = new System.Drawing.Size(572, 31);
            this.lblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(572, 31);
            this.lblMsg.TabIndex = 26;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sp_deptSelectTableAdapter
            // 
            this.sp_deptSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_customerGroupSelectTableAdapter
            // 
            this.sp_customerGroupSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_companySelectTableAdapter
            // 
            this.sp_companySelectTableAdapter.ClearBeforeFill = true;
            // 
            // spselectFeesBindingSource
            // 
            this.spselectFeesBindingSource.DataMember = "sp_selectFees";
            this.spselectFeesBindingSource.DataSource = this.dataSet1;
            // 
            // sp_selectFeesTableAdapter
            // 
            this.sp_selectFeesTableAdapter.ClearBeforeFill = true;
            // 
            // reportFinalDS
            // 
            this.reportFinalDS.DataSetName = "ReportFinalDS";
            this.reportFinalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 651);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistration";
            this.Text = "File Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdeptSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcompanySelectBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportFinalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spfirmNameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGroupClient;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cmbClientFor;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private FontAwesome.Sharp.IconButton btnSave;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spdeptSelectBindingSource;
        private DataSet1TableAdapters.sp_deptSelectTableAdapter sp_deptSelectTableAdapter;
        private System.Windows.Forms.BindingSource spcustomerGroupSelectBindingSource;
        private DataSet1TableAdapters.sp_customerGroupSelectTableAdapter sp_customerGroupSelectTableAdapter;
        private System.Windows.Forms.ComboBox cmbClientName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRegDet;
        private MaterialSkin.Controls.MaterialLabel lblMsg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource spcompanySelectBindingSource;
        private DataSet1TableAdapters.sp_companySelectTableAdapter sp_companySelectTableAdapter;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.BindingSource spselectFeesBindingSource;
        private DataSet1TableAdapters.sp_selectFeesTableAdapter sp_selectFeesTableAdapter;
        private System.Windows.Forms.BindingSource spdeptSelectBindingSource1;
        //private firmDS firmDS;
        //private filrREGDS filrREGDS;
        private ReportFinalDS reportFinalDS;
        private fDS fDS;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.BindingSource spfirmNameBindingSource;
        private fDSTableAdapters.sp_firmNameTableAdapter sp_firmNameTableAdapter;
    }
}