using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAManager
{

	public partial class frmInvoice : Form
	{

		Services services = new Services();

		DataTable Dgv = new DataTable();

		public frmInvoice()
		{
			InitializeComponent();
			//AddCheckBoxColumn();

		}

		private void frmInvoice_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet1.sp_customerGroupSelect' table. You can move, or remove it, as needed.
			this.sp_customerGroupSelectTableAdapter.Fill(this.dataSet1.sp_customerGroupSelect);
			// TODO: This line of code loads data into the 'dataSet1.sp_getInvoice' table. You can move, or remove it, as needed.

			//MessageBox.Show(Services.User.role);
		}


		public void AddCheckBoxColumn()
		{
			DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
			checkBoxColumn.Name = " ";
			checkBoxColumn.HeaderText = "Select";
			dgvInvoice.Columns.Add(checkBoxColumn);
			int checkBoxIndex = dgvInvoice.Columns.Count - 1;
			if (checkBoxIndex >= 0 && checkBoxIndex < dgvInvoice.Columns.Count)
			{
				dgvInvoice.Columns[" "].DisplayIndex = checkBoxIndex;
			}

		}

		private void cmbGroupClient_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmd = services.CreateSqlConnection("sp_companySelect");
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@searchText", cmbGroupClient.SelectedValue);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					cmbClientName.DisplayMember = "name";
					cmbClientName.ValueMember = "CompanyCode";
					cmbClientName.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



		private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbClientName.SelectedIndex > -1)
				dgvInvoice.DataSource = services.getBillRprt(Convert.ToInt64(cmbClientName.SelectedValue.ToString()));
		}


		private void txtIN_Click(object sender, EventArgs e)
		{

		}

		private void txtComment_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblTA_Click(object sender, EventArgs e)
		{

		}

		private void lblTOP_Click(object sender, EventArgs e)
		{

		}

		private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{



		}
		private void materialLabel1_Click(object sender, EventArgs e)
		{

		}

		private void btnDeptSave_Click(object sender, EventArgs e)
		{

			SqlCommand cmd = services.CreateSqlConnection("sp_InvoiceIns");
			cmd.Connection.Open();

			try
			{
				cmd.Parameters.AddWithValue("@CompanyCode", cmbClientName.SelectedValue.ToString());
				cmd.Parameters.AddWithValue("@DocumentDate", DocDate.Value);
				cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoice.Text);

				cmd.Parameters.AddWithValue("@TotalAmount", txtTotalAm.Text);
				cmd.Parameters.AddWithValue("@TermsOfPayment", txtTermPayment.Text);
				cmd.Parameters.AddWithValue("@Remark", txtRemark.Text);
				cmd.Parameters.AddWithValue("@CreatedBy", Services.User.role);
				//  cmd.Parameters.AddWithValue("@ModifiedOn", DateTime.Now.Date);
				//  cmd.Parameters.AddWithValue("@ModifiedBy",Services.User.role);

				string check = cmd.ExecuteScalar().ToString();

				if (Convert.ToInt64(check) > 0)
				{
					SqlCommand cmd1 = services.CreateSqlConnection("sp_InvoiceDetailsIns");
					cmd1.Connection.Open();

					cmd1.Parameters.Add("@InvoiceId", SqlDbType.BigInt);
					cmd1.Parameters.Add("@FileId", SqlDbType.Int);
					cmd1.Parameters.Add("@Description", SqlDbType.VarChar, 250);
					cmd1.Parameters.Add("@HSN_SAC", SqlDbType.VarChar, 50);
					cmd1.Parameters.Add("@Quantity", SqlDbType.Float);
					cmd1.Parameters.Add("@Rate", SqlDbType.Decimal);
					cmd1.Parameters.Add("@Per", SqlDbType.VarChar, 50);
					cmd1.Parameters.Add("@Amount", SqlDbType.Decimal);
					cmd1.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 50);

					var rows = dgvInvoice.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells[0].Value) == true);

					foreach (var row in rows)
					{
						cmd1.Parameters["@InvoiceId"].Value = check;
						cmd1.Parameters["@FileId"].Value = row.Cells["Id"].Value;
						cmd1.Parameters["@Description"].Value = row.Cells["Details"].Value;
						cmd1.Parameters["@HSN_SAC"].Value = null;
						cmd1.Parameters["@Quantity"].Value = 1;
						cmd1.Parameters["@Rate"].Value = row.Cells["Price"].Value;
						cmd1.Parameters["@Per"].Value = null;
						cmd1.Parameters["@Amount"].Value = row.Cells["Price"].Value;
						cmd1.Parameters["@CreatedBy"].Value = Services.User.email;

						cmd1.ExecuteNonQuery();
					}	
					MessageBox.Show("Saved Successfully");
					dgvInvoice.DataSource = null;
					DocDate.Text = txtInvoice.Text = txtTotalAm.Text = txtTermPayment.Text = txtRemark.Text = string.Empty;
					
				}
				else
				{
					MessageBox.Show("Updated Successfully");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}






		}

		private void txtTotalAm_TextChanged(object sender, EventArgs e)
		{

		}

		private void dgvInvoice_CellLeave(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{

				if (dgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || (bool)dgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == false)
				{
					dgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
				}
				else
				{
					dgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
				}

				double prz = Convert.ToInt64(txtTotalAm.Text == "" ? "0" : txtTotalAm.Text);
				bool check = (bool)dgvInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
				string DataId = dgvInvoice.Rows[e.RowIndex].Cells["Price"].Value.ToString();
				if (check)
				{
					dgvInvoice.Rows[e.RowIndex].ReadOnly = true;
					prz = prz + Convert.ToDouble(DataId);

				}
				else
				{
					prz = prz - Convert.ToDouble(DataId);
					dgvInvoice.Rows[e.RowIndex].ReadOnly = false;
				}

				txtTotalAm.Text = prz.ToString();
			}
		}
	}
}
