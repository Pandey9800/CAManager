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
    public partial class frmDetailMaster : MaterialSkin.Controls.MaterialForm
    {
        Services services = new Services();
        public frmDetailMaster()
        {
            InitializeComponent();
        }

        private void frmDetailMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fDS.sp_BankSel' table. You can move, or remove it, as needed.
            this.sp_BankSelTableAdapter.Fill(this.fDS.sp_BankSel);
            // TODO: This line of code loads data into the 'dataSet1.sp_customerGroupSelect' table. You can move, or remove it, as needed.
            this.sp_customerGroupSelectTableAdapter.Fill(this.dataSet1.sp_customerGroupSelect);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);
        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerGroup.Text == "")
                {
                    MessageBox.Show("All fields are mendatory.", "Customer Group", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return;
                }

                SqlCommand cmd = services.CreateSqlConnection("sp_custGroupInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@customerGroup", txtCustomerGroup.Text.ToUpper());
                cmd.Parameters.AddWithValue("@code", txtGroupCode.Text.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                    txtCustomerGroup.Text = "";
                     gvCustGroup.DataSource = sp_customerGroupSelectTableAdapter.GetData();
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeptSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepartment.Text == "")
                {
                    MessageBox.Show("Department field are mendatory.", "Department", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return;
                }
                SqlCommand cmd = services.CreateSqlConnection("sp_departmentInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text.ToUpper());
                cmd.Parameters.AddWithValue("@code", txtCode.Text.ToUpper());
                cmd.Parameters.AddWithValue("@activity", txtActivity.Text.ToUpper());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                    txtDepartment.Text = txtCode.Text = "";
                    gvDept.DataSource = sp_deptSelectTableAdapter.GetData("All");
                }
                reader.Close();
                cmd.Connection.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFeesSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFees.Text == "")
                {
                    MessageBox.Show("All fields are mendatory.", "Activity Fees", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return;
                }
                SqlCommand cmd = services.CreateSqlConnection("sp_feesInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@activity", cmbFeesActivity.Text.ToUpper());
                cmd.Parameters.AddWithValue("@fees", txtFees.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                    cmbFeesActivity.SelectedIndex = 0;
                    txtFees.Text = "";
                    gvFees.DataSource = sp_FeesSelectTableAdapter.GetData();
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBankSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBankName.Text == "" || txtBankNumner.Text == "")
                {
                    MessageBox.Show("All fields are mendatory.", "Bank Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return;
                }
                SqlCommand cmd = services.CreateSqlConnection("sp_bankInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@bankName", txtBankName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@acountNo", txtBankNumner.Text.ToUpper());
                cmd.Parameters.AddWithValue("@branch", txtBankBranch.Text.ToUpper());
                cmd.Parameters.AddWithValue("@IFSC", txtIFSC.Text.ToUpper());
                cmd.Parameters.AddWithValue("@companyCode", cmbBankCompany.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                    txtBankName.Text = txtBankNumner.Text = cmbBankCompany.Text = txtIFSC.Text = txtBankBranch.Text = "";
                     gvBank.DataSource= sp_BankDetailsTableAdapter.GetData(cmbBankCompany.SelectedIndex);
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (materialTabControl1.SelectedTab.Text == "Customer Group")
            {
                gvCustGroup.DataSource = sp_customerGroupSelectTableAdapter.GetData();
            }
            else if (materialTabControl1.SelectedTab.Text == "Department Master")
            {
                gvDept.DataSource = sp_deptSelectTableAdapter.GetData("All");
            }
            else if (materialTabControl1.SelectedTab.Text == "Fees Master")
            {
                cmbFeesActivity.DataSource = sp_deptSelectTableAdapter.GetData("All");
                gvFees.DataSource = sp_FeesSelectTableAdapter.GetData();
            }
            else if (materialTabControl1.SelectedTab.Text == "Bank Master")
            {
                cmbBankCompany.DataSource = services.getCompany();
                cmbBankCompany.DisplayMember = "Name";
                cmbBankCompany.ValueMember = "CompanyCode";
                gvBank.DataSource = sp_BankDetailsTableAdapter.GetData(Convert.ToInt32(cmbBankCompany.SelectedValue));
            }            
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtFees.Text.Length >= 10 || e.KeyChar == 32)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void txtBankNumner_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            if (txtBankNumner.Text.Length >= 20 || e.KeyChar == 32)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void cmbBankCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvBank.DataSource = sp_BankDetailsTableAdapter.GetData(Convert.ToInt32(cmbBankCompany.SelectedValue));
        }

        public void bankclear()
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerGroup.Text = "";
            txtGroupCode.Text = "";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtDepartment.Text = "";
            txtCode.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            cmbFeesActivity.SelectedIndex = 0;
            txtFees.Text = "";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            cmbBankCompany.SelectedIndex = 0;
            txtBankName.Text = "";
            txtBankBranch.Text = "";
            txtBankNumner.Text = "";
            txtIFSC.Text = "";
        }
    }
}
