
namespace CAManager
{
    partial class PopForm2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new CAManager.DataSet1();
            this.sp_InvoiceSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_InvoiceSelTableAdapter = new CAManager.DataSet1TableAdapters.sp_InvoiceSelTableAdapter();
            this.DataSet2 = new CAManager.DataSet2();
            this.sp_companySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_companySelectTableAdapter = new CAManager.DataSet2TableAdapters.sp_companySelectTableAdapter();
            this.reportDS = new CAManager.reportDS();
            this.sp_invoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_invoiceDetailsTableAdapter = new CAManager.reportDSTableAdapters.sp_invoiceDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InvoiceSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_companySelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_invoiceDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Invoice";
            reportDataSource1.Value = this.sp_InvoiceSelBindingSource;
            reportDataSource2.Name = "ComDet";
            reportDataSource2.Value = this.sp_companySelectBindingSource;
            reportDataSource3.Name = "InvDet";
            reportDataSource3.Value = this.sp_invoiceDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CAManager.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_InvoiceSelBindingSource
            // 
            this.sp_InvoiceSelBindingSource.DataMember = "sp_InvoiceSel";
            this.sp_InvoiceSelBindingSource.DataSource = this.DataSet1;
            // 
            // sp_InvoiceSelTableAdapter
            // 
            this.sp_InvoiceSelTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_companySelectBindingSource
            // 
            this.sp_companySelectBindingSource.DataMember = "sp_companySelect";
            this.sp_companySelectBindingSource.DataSource = this.DataSet2;
            // 
            // sp_companySelectTableAdapter
            // 
            this.sp_companySelectTableAdapter.ClearBeforeFill = true;
            // 
            // reportDS
            // 
            this.reportDS.DataSetName = "reportDS";
            this.reportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_invoiceDetailsBindingSource
            // 
            this.sp_invoiceDetailsBindingSource.DataMember = "sp_invoiceDetails";
            this.sp_invoiceDetailsBindingSource.DataSource = this.reportDS;
            // 
            // sp_invoiceDetailsTableAdapter
            // 
            this.sp_invoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // PopForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "PopForm2";
            this.Text = "PopForm2";
            this.Load += new System.EventHandler(this.PopForm2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InvoiceSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_companySelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_invoiceDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_InvoiceSelBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource sp_companySelectBindingSource;
        private DataSet2 DataSet2;
        private System.Windows.Forms.BindingSource sp_invoiceDetailsBindingSource;
        private reportDS reportDS;
        private DataSet1TableAdapters.sp_InvoiceSelTableAdapter sp_InvoiceSelTableAdapter;
        private DataSet2TableAdapters.sp_companySelectTableAdapter sp_companySelectTableAdapter;
        private reportDSTableAdapters.sp_invoiceDetailsTableAdapter sp_invoiceDetailsTableAdapter;
    }
}