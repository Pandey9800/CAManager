using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAManager
{
    public partial class popForm : Form
    {
        public popForm(Int64 invoiceId, int companyCode)
        {
            InitializeComponent();
            Services services = new Services();

            SqlCommand cmd = services.CreateSqlConnection("sp_InvoiceSel");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@invoiceId", invoiceId);

            SqlCommand cd = services.CreateSqlConnection("sp_BankDetails");
            cd.CommandType = CommandType.StoredProcedure;
            cd.Parameters.AddWithValue("@CompanyCode", companyCode);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            SqlDataAdapter adapterBankDetails = new SqlDataAdapter(cd);
            adapterBankDetails.Fill(ds, "BankDetails");



            if (ds.Tables.Count >= 2)
            {
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceSel", ds.Tables[0]));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceDetails", ds.Tables[1]));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompDet", ds.Tables[2]));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("FDS", ds.Tables[3]));
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BankDetails", ds.Tables[4]));
            }
            else
            {
                MessageBox.Show("Can't load data from all datasets.");
            }
        }

        private void popForm_Load(object sender, EventArgs e)
        {
        }

        private void popForm_Load_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
