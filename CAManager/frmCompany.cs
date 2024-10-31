using MaterialSkin.Controls;
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
    public partial class frmCompany : MaterialSkin.Controls.MaterialForm
    {
        public frmCompany()
        {
            InitializeComponent();
            Load += dataload;
           Load += selectbutton;
        }
        Services services = new Services();
        private void frmCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sp_companyType' table. You can move, or remove it, as needed.
            this.sp_companyTypeTableAdapter.Fill(this.dataSet1.sp_companyType);
            // TODO: This line of code loads data into the 'dataSet1.sp_customerGroupSelect' table. You can move, or remove it, as needed.
            this.sp_customerGroupSelectTableAdapter.Fill(this.dataSet1.sp_customerGroupSelect);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);

            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);
            dateTimePicker1.Value = DateTime.Now;
            lblMsg.Width = this.Size.Width; lblMsg.ForeColor = Color.Red;
            //MessageBox.Show(Services.User.role);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = services.CreateSqlConnection("sp_companyInsert");
            cmd.Connection.Open();
            try
            {
                if (txtName.Text == "")
                {
                    txtName.Focus();
                    lblMsg.Text = "Company Name is required field, cannot be blank.";
                    return;
                }

                lblMsg.Text = "";

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@foundationDate", txtFoundationDate.Text);
                cmd.Parameters.AddWithValue("@type", cmbType.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PFNo", txtPF.Text);
                cmd.Parameters.AddWithValue("@ESICNo", txtESIC.Text);
                cmd.Parameters.AddWithValue("@PAN", txtPAN.Text);
                cmd.Parameters.AddWithValue("@TAN", txtTAN.Text);
                cmd.Parameters.AddWithValue("@TIN", txtTIN.Text);
                cmd.Parameters.AddWithValue("@CIN", txtCIN.Text);
                cmd.Parameters.AddWithValue("@GST", txtGST.Text);
                cmd.Parameters.AddWithValue("@fileNo", txtFileNo.Text);
                cmd.Parameters.AddWithValue("@adharNo", txtAdhar.Text);
                cmd.Parameters.AddWithValue("@voterId", txtVoterId.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@CostomerGroup", cmbCustGroup.Text);
                cmd.Parameters.AddWithValue("@primeryContactNo", txtPrimeryContact.Text);
                cmd.Parameters.AddWithValue("@primeryName", txtPrimeryName.Text);
                cmd.Parameters.AddWithValue("@primeryEmail", txtPrimeryEmail.Text);
                cmd.Parameters.AddWithValue("@companyCode", txtCompanyCode.Text);
                cmd.Parameters.AddWithValue("@enteredby", Services.User.role.ToString());

                string check = cmd.ExecuteScalar().ToString();
                if (check == "Saved Successfully")
                {
                    MessageBox.Show(check);
                    cmbCustGroup.SelectedIndex = cmbType.SelectedIndex = 0;
                    txtAddress.Text = txtAdhar.Text = txtCIN.Text = txtCompanyCode.Text = txtEmail.Text = txtESIC.Text = txtFoundationDate.Text =
                    txtGST.Text = txtMobile.Text = txtName.Text = txtPAN.Text = txtPF.Text = txtPrimeryContact.Text = txtPrimeryEmail.Text = txtPrimeryName.Text =
                    txtTAN.Text = txtTIN.Text = txtsearch.Text = txtVoterId.Text = txtFileNo.Text = "";
                    }
                else
                {
                    MessageBox.Show("Updated Successfully");
                }
                dataload(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            this.Controls.Clear();
            this.InitializeComponent();
            this.dataload(sender, e);
            this.selectbutton(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtFoundationDate.Text = Convert.ToDateTime(dateTimePicker1.Text).ToString("dd/MM/yyyy");
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtPF.Text.Length >= 22)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtESIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtESIC.Text.Length >= 17)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtTIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtTIN.Text.Length >= 15)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtCIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtCIN.Text.Length >= 21)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtGST.Text.Length >= 15)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtTAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtTAN.Text.Length >= 10)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtAdhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtAdhar.Text.Length >= 12)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtVoterId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtVoterId.Text.Length >= 10)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtMobile.Text.Length >= 10)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtPAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtPAN.Text.Length >= 10)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        //private void txtEmail_Leave(object sender, EventArgs e)
        //{
        //    if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com") || !txtEmail.Text.Contains(".in"))
        //        MessageBox.Show("invalid Email Syntex");
        //}

        private void txtMobile_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtPrimeryContact.Text.Length >= 10)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        //private void txtPrimeryEmail_Leave(object sender, EventArgs e)
        //{
        //    if (!txtPrimeryEmail.Text.Contains("@") || !txtPrimeryEmail.Text.Contains(".com") || !txtPrimeryEmail.Text.Contains(".in"))
        //        MessageBox.Show(" ");
        //}

        private void txtFileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtsearch.Text.Length >= 5)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtPF.Text = string.Empty;
            txtESIC.Text = string.Empty;
            txtTAN.Text = string.Empty;
            txtTIN.Text = string.Empty;
            txtCIN.Text = string.Empty;
            txtGST.Text = string.Empty;
            txtAdhar.Text = string.Empty;
            txtVoterId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPrimeryContact.Text = string.Empty;
            txtPrimeryName.Text = string.Empty;
            txtPrimeryEmail.Text = string.Empty;
            txtCompanyCode.Text = string.Empty;
            txtPAN.Text = string.Empty;
            txtFileNo.Text = string.Empty;
            cmbCustGroup.SelectedItem = 0;
            cmbType.SelectedIndex = 0;
        }

        public void clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtPF.Text = "";
            txtESIC.Text = "";
            txtTAN.Text = "";
            txtTIN.Text = "";
            txtCIN.Text = "";
            txtGST.Text = "";
            txtAdhar.Text = "";
            txtVoterId.Text = "";
            txtEmail.Text = "";
            txtPrimeryContact.Text = "";
            txtPrimeryName.Text = "";
            txtPrimeryEmail.Text = "";
            txtCompanyCode.Text = "";
            txtPAN.Text = "";
            txtFileNo.Text = "";
            cmbType.SelectedIndex = -1;
            cmbCustGroup.SelectedIndex = -1;
        }


        public void dataload(object sender, EventArgs e)
        {
            dgv.DataSource = services.getCompany();
        }

        public void selectbutton(object sender, EventArgs e)
        {
            DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn();
            selectButtonColumn.Name = " ";
            selectButtonColumn.Text = "Select";
            selectButtonColumn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(selectButtonColumn);
            int selectButtonIndex = dgv.Columns.Count - 22;
            if (selectButtonIndex >= 0 && selectButtonIndex < dgv.Columns.Count)
            {
                dgv.Columns[" "].DisplayIndex = selectButtonIndex;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns.Count - 1 && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                string companyCode = selectedRow.Cells["CompanyCode"].Value.ToString();
                string companyName = selectedRow.Cells["CompanyName"].Value.ToString();
                string group = selectedRow.Cells["CostumerGroup"].Value.ToString();
                string fileNo = selectedRow.Cells["FileNo"].Value.ToString();
                string FoundationDate = selectedRow.Cells["FoundationDate"].Value.ToString();
                string type = selectedRow.Cells["type"].Value.ToString();
                string mobile = selectedRow.Cells["Mobile"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string GST = selectedRow.Cells["GST"].Value.ToString();
                string PF = selectedRow.Cells["PFNo"].Value.ToString();
                string ESIC = selectedRow.Cells["ESICNo"].Value.ToString();
                string TAN = selectedRow.Cells["TAN"].Value.ToString();
                string TIN = selectedRow.Cells["TIN"].Value.ToString();
                string CIN = selectedRow.Cells["CIN"].Value.ToString();
                string PAN = selectedRow.Cells["PAN"].Value.ToString();
                string adhar = selectedRow.Cells["AdharNo"].Value.ToString();
                string primaryName = selectedRow.Cells["PrimeryName"].Value.ToString();
                string primaryCN = selectedRow.Cells["PrimeryContactNo"].Value.ToString();
                string primaryEmail = selectedRow.Cells["PrimeryEmail"].Value.ToString();
                string voterId = selectedRow.Cells["VoterId"].Value.ToString();

                txtCompanyCode.Text = companyCode;
                txtName.Text = companyName;
                cmbCustGroup.Text = group;
                txtFileNo.Text = fileNo;
                txtFoundationDate.Text = FoundationDate;
                cmbType.Text = type;
                txtMobile.Text = mobile;
                txtEmail.Text = email;
                txtAddress.Text = address;
                txtGST.Text = GST;
                txtPF.Text = PF;
                txtESIC.Text = ESIC;
                txtTAN.Text = TAN;
                txtTIN.Text = TIN;
                txtCIN.Text = CIN;
                txtPAN.Text = PAN;
                txtAdhar.Text = adhar;
                txtPrimeryName.Text = primaryName;
                txtPrimeryContact.Text = primaryCN;
                txtPrimeryEmail.Text = primaryEmail;
                txtVoterId.Text = voterId;
            }
        }



        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgv.DataSource;
            bs.Filter = "[name] like '%" + txtsearch.Text + "%' " +
                        "OR [address] like '%" + txtsearch.Text + "%'" +
                        "OR [PAN] like '%" + txtsearch.Text + "%'" +
                        "OR [mobile] like '%" + txtsearch.Text.ToString() + "%'" +
                        "OR [PFNo] like '%" + txtsearch.Text + "%'" +
                        "OR [ESICNo] like '%" + txtsearch.Text + "%'" +
                        "OR [TAN] like '%" + txtsearch.Text + "%'" +
                        "OR [TIN] like '%" + txtsearch.Text + "%'" +
                        "OR Convert(fileNo, 'System.String') like '%" + txtsearch.Text + "%'" +
                        "OR [CIN] like '%" + txtsearch.Text + "%'" +
                        "OR [GST] like '%" + txtsearch.Text + "%'" +
                        "OR [voterId] like '%" + txtsearch.Text + "%'" +
                        "OR [adharNo] like '%" + txtsearch.Text + "%'" +
                        "OR [voterId] like '%" + txtsearch.Text + "%'" +
                        "OR [enteredby] like '%" + txtsearch.Text + "%'" +
                        "OR [primeryContactNo] like '%" + txtsearch.Text + "%'" +
                        "OR [primeryEmail] like '%" + txtsearch.Text + "%'" +
                        "OR [email] like '%" + txtsearch.Text + "%'";
        }
    }
}

