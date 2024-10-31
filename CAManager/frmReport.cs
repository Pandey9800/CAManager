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
    public partial class frmReport : Form
    {
        Services services = new Services();
        DataTable dt = new DataTable();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.sp_customerGroupSelectTableAdapter.Fill(this.dataSet1.sp_customerGroupSelect);
            this.sp_companySelectTableAdapter.Fill(this.dataSet1.sp_companySelect);
        }
        private void cmbGroupClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = services.CreateSqlConnection("sp_companySelect");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@searchText", cmbGroupClient.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbClientName.DisplayMember = "Name";
                    cmbClientName.ValueMember = "CompanyCode";
                    cmbClientName.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    popForm reportForm = new popForm(Convert.ToInt64(dgvInv.Rows[e.RowIndex].Cells["Id"].Value),
                                                     Convert.ToInt32(dgvInv.Rows[e.RowIndex].Cells["CompanyCode"].Value));
                    reportForm.StartPosition = FormStartPosition.CenterScreen;
                    reportForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvInv.DataSource = services.getReportInvoice(Convert.ToInt64(cmbClientName.SelectedValue));
        }
    }
}



