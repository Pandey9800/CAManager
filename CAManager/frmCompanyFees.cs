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
    public partial class frmCompanyFees : MaterialSkin.Controls.MaterialForm
    {
        public static readonly DataSet1 dataSet1 = new DataSet1();
        public frmCompanyFees()
        {
            InitializeComponent();
        }
        Services services = new Services();
       
        
        private void frmCompanyFees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.sp_FeesSelect' table. You can move, or remove it, as needed.
            this.sp_FeesSelectTableAdapter.Fill(this.dataSet11.sp_FeesSelect);
            // TODO: This line of code loads data into the 'dataSet11.sp_deptSelect' table. You can move, or remove it, as needed.
            this.sp_deptSelectTableAdapter.Fill(this.dataSet11.sp_deptSelect, "All") ;
            // TODO: This line of code loads data into the 'dataSet11.sp_FeesSelect' table. You can move, or remove it, as needed.
            this.sp_FeesSelectTableAdapter.Fill(this.dataSet11.sp_FeesSelect);
            // TODO: This line of code loads data into the 'dataSet11.sp_deptSelect' table. You can move, or remove it, as needed.
            this.sp_deptSelectTableAdapter.Fill(this.dataSet11.sp_deptSelect, "All");
            //cmbCC.SelectedValue = ReadOnlyAttribute.Yes;
            //cmbDept.SelectedValue = ReadOnlyAttribute.Yes;
            this.sp_companySelectTableAdapter.Fill(this.dataSet11.sp_companySelect);
            load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = services.CreateSqlConnection("sp_InsertFees");
            cmd.Connection.Open();
            try
            {
                cmd.Parameters.AddWithValue("@CC", cmbCC.Text);
                cmd.Parameters.AddWithValue("@dept", cmbDept.Text);
                cmd.Parameters.AddWithValue("feeAmount",txtFeesAmount.Text);
                cmd.Parameters.AddWithValue("@enteredBy", Services.User.email);
                cmd.Parameters.AddWithValue("@modifiedBy", Services.User.email);
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show(i + " " + "Data Saved");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            load();
        }

        public void load()
        {
            dgvFee.DataSource = services.getFees();
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDept.SelectedValue != null)
            txtFeesAmount.Text = cmbDept.SelectedValue.ToString();
        }
    }
}
