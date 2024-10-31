using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAManager
{
    public partial class PopForm2 : Form
    {
        public PopForm2()
        {
            InitializeComponent();
        }

        private void PopForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.sp_InvoiceSel' table. You can move, or remove it, as needed.
            this.sp_InvoiceSelTableAdapter.Fill(this.DataSet1.sp_InvoiceSel);
            // TODO: This line of code loads data into the 'DataSet2.sp_companySelect' table. You can move, or remove it, as needed.
            this.sp_companySelectTableAdapter.Fill(this.DataSet2.sp_companySelect);
            // TODO: This line of code loads data into the 'reportDS.sp_invoiceDetails' table. You can move, or remove it, as needed.
            this.sp_invoiceDetailsTableAdapter.Fill(this.reportDS.sp_invoiceDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
