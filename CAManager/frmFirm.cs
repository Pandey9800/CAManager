using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAManager
{
    public partial class frmFirm : Form
    {
        Services services = new Services();
        public frmFirm()
        {
            InitializeComponent();
        }

        private void frmFirm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fDS.sp_firmName' table. You can move, or remove it, as needed.
            this.sp_firmNameTableAdapter.Fill(this.fDS.sp_firmName);
            // TODO: This line of code loads data into the 'fDS.sp_firmName' table. You can move, or remove it, as needed.
            this.sp_firmNameTableAdapter.Fill(this.fDS.sp_firmName);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               SqlCommand cmd = services.CreateSqlConnection("sp_firmInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@firmName",txtFName.Text);
                cmd.Parameters.AddWithValue("@addess",txtAddress.Text);
                cmd.Parameters.AddWithValue("@GST",txtGST.Text);
                cmd.Parameters.AddWithValue("@PAN",txtPAN.Text);
                cmd.Parameters.AddWithValue("@personName",txtPersonName.Text);
                cmd.Parameters.AddWithValue("@personContact",txtPersonContact.Text);
                cmd.Parameters.AddWithValue("@personEmail",txtPersonEmail.Text);
                cmd.Parameters.AddWithValue("@email",txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobile",txtMob.Text);
                cmd.Parameters.AddWithValue("@fPrefix",txtPrefix.Text);
                cmd.Parameters.AddWithValue("@designation",txtWork.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Saved Successfully");
                   txtFName.Text = txtAddress.Text = txtGST.Text = txtPAN.Text = txtPersonName.Text = txtPersonContact.Text = txtPersonEmail.Text = txtEmail.Text = txtMob.Text = txtPrefix.Text = txtWork.Text  = "";
                }
                else { MessageBox.Show("Something Wrong"); }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frmFirm_Load(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtAddress.Text = "";
            txtGST.Text = "";
            txtPAN.Text = "";
            txtPersonName.Text = "";
            txtPersonContact.Text = "";
            txtPersonEmail.Text = "";
            txtEmail.Text = "";
            txtMob.Text = "";
        }
    }
}
