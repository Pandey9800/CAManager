
namespace CAManager
{
    partial class popForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportFinalDS = new CAManager.ReportFinalDS();
            this.sp_InvoiceSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_InvoiceSelTableAdapter = new CAManager.ReportFinalDSTableAdapters.sp_InvoiceSelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportFinalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InvoiceSelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InvocieSel";
            reportDataSource1.Value = this.sp_InvoiceSelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CAManager.ReportFINAL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportFinalDS
            // 
            this.ReportFinalDS.DataSetName = "ReportFinalDS";
            this.ReportFinalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_InvoiceSelBindingSource
            // 
            this.sp_InvoiceSelBindingSource.DataMember = "sp_InvoiceSel";
            this.sp_InvoiceSelBindingSource.DataSource = this.ReportFinalDS;
            // 
            // sp_InvoiceSelTableAdapter
            // 
            this.sp_InvoiceSelTableAdapter.ClearBeforeFill = true;
            // 
            // popForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "popForm";
            this.Text = "popForm";
            this.Load += new System.EventHandler(this.popForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ReportFinalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_InvoiceSelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_InvoiceSelBindingSource;
        private ReportFinalDS ReportFinalDS;
        private ReportFinalDSTableAdapters.sp_InvoiceSelTableAdapter sp_InvoiceSelTableAdapter;
    }
}