namespace CAManager
{
    partial class frmTaskList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexcel = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbgroup = new System.Windows.Forms.ComboBox();
            this.spcustomerGroupSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CAManager.DataSet1();
            this.lblstatus = new MaterialSkin.Controls.MaterialLabel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.spstatusSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTo = new MaterialSkin.Controls.MaterialLabel();
            this.lblFrom = new MaterialSkin.Controls.MaterialLabel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.sp_statusSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_statusSelectTableAdapter();
            this.gvTaskList = new System.Windows.Forms.DataGridView();
            this.sp_customerGroupSelectTableAdapter = new CAManager.DataSet1TableAdapters.sp_customerGroupSelectTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spstatusSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexcel);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cmbgroup);
            this.panel1.Controls.Add(this.lblstatus);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1695, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnexcel
            // 
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Location = new System.Drawing.Point(1551, 39);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(133, 39);
            this.btnexcel.TabIndex = 8;
            this.btnexcel.Text = "Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(845, 39);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MaximumSize = new System.Drawing.Size(75, 28);
            this.materialLabel1.MinimumSize = new System.Drawing.Size(36, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 28);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Group";
            // 
            // cmbgroup
            // 
            this.cmbgroup.DataSource = this.spcustomerGroupSelectBindingSource;
            this.cmbgroup.DisplayMember = "customerGroup";
            this.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgroup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgroup.FormattingEnabled = true;
            this.cmbgroup.Location = new System.Drawing.Point(923, 39);
            this.cmbgroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbgroup.Name = "cmbgroup";
            this.cmbgroup.Size = new System.Drawing.Size(253, 26);
            this.cmbgroup.TabIndex = 6;
            this.cmbgroup.ValueMember = "customerGroup";
            this.cmbgroup.SelectedIndexChanged += new System.EventHandler(this.cmbgroup_SelectedIndexChanged);
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
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Depth = 0;
            this.lblstatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblstatus.Location = new System.Drawing.Point(489, 39);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatus.MaximumSize = new System.Drawing.Size(75, 28);
            this.lblstatus.MinimumSize = new System.Drawing.Size(36, 28);
            this.lblstatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(63, 28);
            this.lblstatus.TabIndex = 5;
            this.lblstatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataSource = this.spstatusSelectBindingSource;
            this.cmbStatus.DisplayMember = "status";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(567, 39);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(253, 26);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.ValueMember = "id";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // spstatusSelectBindingSource
            // 
            this.spstatusSelectBindingSource.DataMember = "sp_statusSelect";
            this.spstatusSelectBindingSource.DataSource = this.dataSet1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Depth = 0;
            this.lblTo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTo.Location = new System.Drawing.Point(252, 39);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.MaximumSize = new System.Drawing.Size(36, 28);
            this.lblTo.MinimumSize = new System.Drawing.Size(36, 28);
            this.lblTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 28);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Depth = 0;
            this.lblFrom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFrom.Location = new System.Drawing.Point(7, 39);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.MaximumSize = new System.Drawing.Size(59, 28);
            this.lblFrom.MinimumSize = new System.Drawing.Size(59, 28);
            this.lblFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(59, 28);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.CustomFormat = "dd-MM-yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(292, 39);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(153, 27);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(69, 39);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(153, 27);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // sp_statusSelectTableAdapter
            // 
            this.sp_statusSelectTableAdapter.ClearBeforeFill = true;
            // 
            // gvTaskList
            // 
            this.gvTaskList.AllowUserToDeleteRows = false;
            this.gvTaskList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTaskList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTaskList.Location = new System.Drawing.Point(0, 82);
            this.gvTaskList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvTaskList.Name = "gvTaskList";
            this.gvTaskList.ReadOnly = true;
            this.gvTaskList.RowHeadersWidth = 51;
            this.gvTaskList.Size = new System.Drawing.Size(1695, 599);
            this.gvTaskList.TabIndex = 1;
            // 
            // sp_customerGroupSelectTableAdapter
            // 
            this.sp_customerGroupSelectTableAdapter.ClearBeforeFill = true;
            // 
            // frmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 681);
            this.Controls.Add(this.gvTaskList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTaskList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "frmTaskList";
            this.Load += new System.EventHandler(this.frmTaskList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcustomerGroupSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spstatusSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private MaterialSkin.Controls.MaterialLabel lblTo;
        private MaterialSkin.Controls.MaterialLabel lblFrom;
        private System.Windows.Forms.ComboBox cmbStatus;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spstatusSelectBindingSource;
        private DataSet1TableAdapters.sp_statusSelectTableAdapter sp_statusSelectTableAdapter;
        private System.Windows.Forms.DataGridView gvTaskList;
        private MaterialSkin.Controls.MaterialLabel lblstatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbgroup;
        private System.Windows.Forms.BindingSource spcustomerGroupSelectBindingSource;
        private DataSet1TableAdapters.sp_customerGroupSelectTableAdapter sp_customerGroupSelectTableAdapter;
        private System.Windows.Forms.Button btnexcel;
    }
}