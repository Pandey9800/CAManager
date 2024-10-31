namespace CAManager
{
    partial class frmActivity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCommentBox = new System.Windows.Forms.TextBox();
            this.gvActivityList = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new CAManager.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.cmbForwardTo = new System.Windows.Forms.ComboBox();
            this.spselectUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFT = new MaterialSkin.Controls.MaterialLabel();
            this.txtStatus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtClientName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtlastupdate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtForwardto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.sp_selectUserTableAdapter = new CAManager.DataSet1TableAdapters.sp_selectUserTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxComment = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblbtnUp = new System.Windows.Forms.Label();
            this.btnupload = new System.Windows.Forms.Button();
            this.lblUPF = new System.Windows.Forms.Label();
            this.spcommentSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_commentSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_commentSelectTableAdapter();
            this.sp_selectUserforForwordTableAdapter = new CAManager.DataSet1TableAdapters.sp_selectUserforForwordTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chboxTask = new System.Windows.Forms.RadioButton();
            this.chbadminhelp = new System.Windows.Forms.RadioButton();
            this.chbRev = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectUserBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcommentSelectBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(17, 34);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(93, 24);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Comment";
            // 
            // txtCommentBox
            // 
            this.txtCommentBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentBox.Location = new System.Drawing.Point(15, 56);
            this.txtCommentBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommentBox.Multiline = true;
            this.txtCommentBox.Name = "txtCommentBox";
            this.txtCommentBox.Size = new System.Drawing.Size(337, 88);
            this.txtCommentBox.TabIndex = 22;
            // 
            // gvActivityList
            // 
            this.gvActivityList.AllowUserToAddRows = false;
            this.gvActivityList.AllowUserToDeleteRows = false;
            this.gvActivityList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvActivityList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActivityList.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvActivityList.Location = new System.Drawing.Point(0, 0);
            this.gvActivityList.Name = "gvActivityList";
            this.gvActivityList.ReadOnly = true;
            this.gvActivityList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvActivityList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvActivityList.Size = new System.Drawing.Size(1748, 194);
            this.gvActivityList.TabIndex = 24;
            this.gvActivityList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvActivityList_CellClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 376);
            this.panel1.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbRev);
            this.groupBox3.Controls.Add(this.chbadminhelp);
            this.groupBox3.Controls.Add(this.chboxTask);
            this.groupBox3.Controls.Add(this.materialLabel8);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.txtCommentBox);
            this.groupBox3.Controls.Add(this.cmbForwardTo);
            this.groupBox3.Controls.Add(this.lblFT);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 329);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update File Status";
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
            this.btnSave.Location = new System.Drawing.Point(261, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Rotation = 0D;
            this.btnSave.Size = new System.Drawing.Size(81, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbForwardTo
            // 
            this.cmbForwardTo.DataSource = this.spselectUserBindingSource;
            this.cmbForwardTo.DisplayMember = "name";
            this.cmbForwardTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForwardTo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbForwardTo.FormattingEnabled = true;
            this.cmbForwardTo.Location = new System.Drawing.Point(121, 155);
            this.cmbForwardTo.Name = "cmbForwardTo";
            this.cmbForwardTo.Size = new System.Drawing.Size(164, 26);
            this.cmbForwardTo.TabIndex = 23;
            this.cmbForwardTo.ValueMember = "name";
            this.cmbForwardTo.Visible = false;
            // 
            // spselectUserBindingSource
            // 
            this.spselectUserBindingSource.DataMember = "sp_selectUser";
            this.spselectUserBindingSource.DataSource = this.dataSet1;
            // 
            // lblFT
            // 
            this.lblFT.AutoSize = true;
            this.lblFT.Depth = 0;
            this.lblFT.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFT.Location = new System.Drawing.Point(17, 155);
            this.lblFT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFT.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFT.Name = "lblFT";
            this.lblFT.Size = new System.Drawing.Size(106, 24);
            this.lblFT.TabIndex = 22;
            this.lblFT.Text = "Forward To";
            this.lblFT.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Depth = 0;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.DimGray;
            this.txtStatus.Hint = "";
            this.txtStatus.Location = new System.Drawing.Point(125, 117);
            this.txtStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.Size = new System.Drawing.Size(147, 28);
            this.txtStatus.TabIndex = 35;
            this.txtStatus.UseSystemPasswordChar = false;
            // 
            // txtClientName
            // 
            this.txtClientName.Depth = 0;
            this.txtClientName.Enabled = false;
            this.txtClientName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.DimGray;
            this.txtClientName.Hint = "";
            this.txtClientName.Location = new System.Drawing.Point(125, 30);
            this.txtClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.PasswordChar = '\0';
            this.txtClientName.SelectedText = "";
            this.txtClientName.SelectionLength = 0;
            this.txtClientName.SelectionStart = 0;
            this.txtClientName.Size = new System.Drawing.Size(147, 28);
            this.txtClientName.TabIndex = 25;
            this.txtClientName.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(9, 121);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(63, 24);
            this.materialLabel7.TabIndex = 34;
            this.materialLabel7.Text = "Status";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 34);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(114, 24);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Client Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 92);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 24);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Last Update";
            // 
            // txtlastupdate
            // 
            this.txtlastupdate.Depth = 0;
            this.txtlastupdate.Enabled = false;
            this.txtlastupdate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastupdate.ForeColor = System.Drawing.Color.DimGray;
            this.txtlastupdate.Hint = "";
            this.txtlastupdate.Location = new System.Drawing.Point(125, 88);
            this.txtlastupdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtlastupdate.Name = "txtlastupdate";
            this.txtlastupdate.PasswordChar = '\0';
            this.txtlastupdate.SelectedText = "";
            this.txtlastupdate.SelectionLength = 0;
            this.txtlastupdate.SelectionStart = 0;
            this.txtlastupdate.Size = new System.Drawing.Size(147, 28);
            this.txtlastupdate.TabIndex = 27;
            this.txtlastupdate.UseSystemPasswordChar = false;
            // 
            // txtForwardto
            // 
            this.txtForwardto.Depth = 0;
            this.txtForwardto.Enabled = false;
            this.txtForwardto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForwardto.ForeColor = System.Drawing.Color.DimGray;
            this.txtForwardto.Hint = "";
            this.txtForwardto.Location = new System.Drawing.Point(125, 59);
            this.txtForwardto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtForwardto.Name = "txtForwardto";
            this.txtForwardto.PasswordChar = '\0';
            this.txtForwardto.SelectedText = "";
            this.txtForwardto.SelectionLength = 0;
            this.txtForwardto.SelectionStart = 0;
            this.txtForwardto.Size = new System.Drawing.Size(147, 28);
            this.txtForwardto.TabIndex = 31;
            this.txtForwardto.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(9, 63);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(106, 24);
            this.materialLabel5.TabIndex = 30;
            this.materialLabel5.Text = "Forward To";
            // 
            // sp_selectUserTableAdapter
            // 
            this.sp_selectUserTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(370, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 335);
            this.panel2.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxComment);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(278, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 329);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // listBoxComment
            // 
            this.listBoxComment.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComment.FormattingEnabled = true;
            this.listBoxComment.ItemHeight = 20;
            this.listBoxComment.Location = new System.Drawing.Point(6, 28);
            this.listBoxComment.Name = "listBoxComment";
            this.listBoxComment.Size = new System.Drawing.Size(613, 264);
            this.listBoxComment.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblbtnUp);
            this.groupBox2.Controls.Add(this.lblUPF);
            this.groupBox2.Controls.Add(this.txtlastupdate);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtClientName);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtForwardto);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 329);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Status";
            // 
            // lblbtnUp
            // 
            this.lblbtnUp.AutoSize = true;
            this.lblbtnUp.Location = new System.Drawing.Point(118, 220);
            this.lblbtnUp.Name = "lblbtnUp";
            this.lblbtnUp.Size = new System.Drawing.Size(0, 20);
            this.lblbtnUp.TabIndex = 39;
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(1462, 535);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(123, 29);
            this.btnupload.TabIndex = 38;
            this.btnupload.Text = "File Upload";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblUPF
            // 
            this.lblUPF.AutoSize = true;
            this.lblUPF.Location = new System.Drawing.Point(28, 230);
            this.lblUPF.Name = "lblUPF";
            this.lblUPF.Size = new System.Drawing.Size(0, 20);
            this.lblUPF.TabIndex = 37;
            // 
            // spcommentSelectBindingSource
            // 
            this.spcommentSelectBindingSource.DataMember = "sp_commentSelect";
            this.spcommentSelectBindingSource.DataSource = this.dataSet1;
            // 
            // sp_commentSelectTableAdapter
            // 
            this.sp_commentSelectTableAdapter.ClearBeforeFill = true;
            // 
            // sp_selectUserforForwordTableAdapter
            // 
            this.sp_selectUserforForwordTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxFiles);
            this.panel3.Controls.Add(this.lblFiles);
            this.panel3.Location = new System.Drawing.Point(1306, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 335);
            this.panel3.TabIndex = 38;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 20;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 36);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(414, 284);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.listBoxFiles_DoubleClick);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(18, 6);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(48, 20);
            this.lblFiles.TabIndex = 0;
            this.lblFiles.Text = "Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 39;
            // 
            // chboxTask
            // 
            this.chboxTask.AutoSize = true;
            this.chboxTask.Location = new System.Drawing.Point(0, 225);
            this.chboxTask.Name = "chboxTask";
            this.chboxTask.Size = new System.Drawing.Size(99, 24);
            this.chboxTask.TabIndex = 27;
            this.chboxTask.TabStop = true;
            this.chboxTask.Text = "Pending";
            this.chboxTask.UseVisualStyleBackColor = true;
            this.chboxTask.CheckedChanged += new System.EventHandler(this.chboxTask_CheckedChanged);
            // 
            // chbadminhelp
            // 
            this.chbadminhelp.AutoSize = true;
            this.chbadminhelp.Location = new System.Drawing.Point(105, 227);
            this.chbadminhelp.Name = "chbadminhelp";
            this.chbadminhelp.Size = new System.Drawing.Size(131, 24);
            this.chbadminhelp.TabIndex = 28;
            this.chbadminhelp.TabStop = true;
            this.chbadminhelp.Text = "Admin Help";
            this.chbadminhelp.UseVisualStyleBackColor = true;
            this.chbadminhelp.CheckedChanged += new System.EventHandler(this.chbadminhelp_CheckedChanged);
            // 
            // chbRev
            // 
            this.chbRev.AutoSize = true;
            this.chbRev.Location = new System.Drawing.Point(242, 230);
            this.chbRev.Name = "chbRev";
            this.chbRev.Size = new System.Drawing.Size(86, 24);
            this.chbRev.TabIndex = 29;
            this.chbRev.TabStop = true;
            this.chbRev.Text = "Revert";
            this.chbRev.UseVisualStyleBackColor = true;
            this.chbRev.CheckedChanged += new System.EventHandler(this.chbRev_CheckedChanged);
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvActivityList);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmActivity";
            this.Text = "Activity Manager";
            this.Load += new System.EventHandler(this.frmActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spselectUserBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcommentSelectBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TextBox txtCommentBox;
        private System.Windows.Forms.DataGridView gvActivityList;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbForwardTo;
        private MaterialSkin.Controls.MaterialLabel lblFT;
        private System.Windows.Forms.BindingSource spselectUserBindingSource;
        private DataSet1TableAdapters.sp_selectUserTableAdapter sp_selectUserTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtForwardto;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtlastupdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClientName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource spcommentSelectBindingSource;
        private DataSet1TableAdapters.sp_commentSelectTableAdapter sp_commentSelectTableAdapter;
        private DataSet1TableAdapters.sp_selectUserforForwordTableAdapter sp_selectUserforForwordTableAdapter;
        private System.Windows.Forms.Label lblUPF;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Label lblbtnUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxComment;
        private System.Windows.Forms.RadioButton chboxTask;
        private System.Windows.Forms.RadioButton chbadminhelp;
        private System.Windows.Forms.RadioButton chbRev;
    }
}