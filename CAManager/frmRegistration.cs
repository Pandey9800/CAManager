using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAManager
{
    public partial class frmRegistration : MaterialSkin.Controls.MaterialForm
    {
        Services services = new Services();
        private string uploadedFilePath;
        private string ofileName;
        public string OriginalFileName { get; private set; }

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fDS.sp_firmName' table. You can move, or remove it, as needed.
            this.sp_firmNameTableAdapter.Fill(this.fDS.sp_firmName);
            // TODO: This line of code loads data into the 'fDS.sp_firmName' table. You can move, or remove it, as needed.
            this.sp_firmNameTableAdapter.Fill(this.fDS.sp_firmName);
            // TODO: This line of code loads data into the 'dataSet1.sp_FeesSelect' table. You can move, or remove it, as needed.
            //this.sp_FeesSelectTableAdapter.Fill(this.dataSet1.sp_FeesSelect);
            // TODO: This line of code loads data into the 'dataSet1.sp_firmMasterSelect' table. You can move, or remove it, as needed.
            //this.sp_firmMasterSelectTableAdapter.Fill(this.dataSet1.sp_firmMasterSelect);
            // TODO: This line of code loads data into the 'dataSet1.sp_customerGroupSelect' table. You can move, or remove it, as needed.
            this.sp_customerGroupSelectTableAdapter.Fill(this.dataSet1.sp_customerGroupSelect);
            // TODO: This line of code loads data into the 'dataSet1.sp_deptSelect' table. You can move, or remove it, as needed.
            this.sp_deptSelectTableAdapter.Fill(this.dataSet1.sp_deptSelect, null);
            

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);
            lblMsg.ForeColor = Color.Red;

            cmbGroupClient.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbGroupClient.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbClientName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbClientName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbActivity.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbActivity.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbClientFor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbClientFor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClientName.SelectedValue == null) { lblMsg.Text = "Please select Client Name."; cmbClientName.Focus(); return; }
            if (cmbClientFor.SelectedValue == null) { lblMsg.Text = "Please select Firm Name."; cmbClientFor.Focus(); return; }
            if (cmbDepartment.SelectedValue == null) { lblMsg.Text = "Please select task related Department."; cmbDepartment.Focus(); return; }
            if (txtComment.Text == "") { lblMsg.Text = "Comment box cannot be blank."; txtComment.Focus(); return; }
            if (txtRegDet.Text == "") { lblMsg.Text = "Please input some Registration Details."; txtRegDet.Focus(); return; }
            lblMsg.Text = "";
            try
            {
                SqlCommand cmd = services.CreateSqlConnection("sp_fileRegInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@clientGroup", cmbGroupClient.Text);
                cmd.Parameters.AddWithValue("@groupCode", cmbGroupClient.SelectedValue);
                cmd.Parameters.AddWithValue("@clientName", cmbClientName.Text);
                cmd.Parameters.AddWithValue("@CompanyCode", cmbClientName.SelectedValue);
                cmd.Parameters.AddWithValue("@fileNo", txtFileNumber.Text);
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@activity", cmbActivity.Text);

                // cmd.Parameters.AddWithValue("@workingDate", );

                //cmd.Parameters.AddWithValue("@forwardTo", );
                cmd.Parameters.AddWithValue("@clientFor", cmbClientFor.Text);
                cmd.Parameters.AddWithValue("@registrationDetails", txtRegDet.Text);
                cmd.Parameters.AddWithValue("@comments", txtComment.Text);
                cmd.Parameters.AddWithValue("@remark", txtRemark.Text);
                cmd.Parameters.AddWithValue("@status", 1);
                cmd.Parameters.AddWithValue("@FilePath", uploadedFilePath);
                cmd.Parameters.AddWithValue("@DocumentName", ofileName);
                //cmd.Parameters.AddWithValue("@receiptNo", txt);
                //cmd.Parameters.AddWithValue("@FilingFees", txt);

                cmd.Parameters.AddWithValue("@enteredby", Services.User.name);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Saved Successfully", "File Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else { MessageBox.Show("File Registration", "Something Wrong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            txtRemark.Text = "";
            txtComment.Text = "";
            txtRegDet.Text = "";
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
            cmbClienName();
        }

        public void cmbClienName()
        {
            try
            {
                txtFileNumber.Text = ((DataRowView)cmbClientName.SelectedItem)[23].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "C:\\Desktop";
                openFileDialog.Title = "Select file to upload";
                openFileDialog.Filter = "Valid Document (*.pdf; *.doc; *.xlsx; *.html *.png *.jpg *.jpeg)|*.pdf; *.docx; *.xlsx; *.html; *.png; *.jpg; *.jpeg;";
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string destinationDirectory = @"E:\Office Work\5). May\Windows Application\CAManager\CAManager\Docs";
                    string fileName = Path.GetFileName(sourceFilePath);
                    ofileName = fileName;
                    string fileExtension = Path.GetExtension(sourceFilePath);

                    string uniqueFileName = $"{DateTime.Now:yyyyMMddHHmmss}{fileExtension}";

                    string destinationFilePath = Path.Combine(destinationDirectory, uniqueFileName);

                    File.Copy(sourceFilePath, destinationFilePath);

                    uploadedFilePath = destinationFilePath;
                }
                else
                {
                    MessageBox.Show("Please upload a document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying file: " + ex.Message, "File Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            try
            {
                DataTable dt = services.getCompany();

                if (txtFileNumber.Text.ToString() != null)
                {
                    DataRow[] selectedRows = dt.Select("fileNo='" + txtFileNumber.Text.ToString() + "'");
                    if (selectedRows.Length > 0)
                    {
                        cmbClientName.Text = selectedRows[0]["name"].ToString();
                        cmbGroupClient.Text = selectedRows[0]["CostumerGroup"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = services.CreateSqlConnection("sp_deptSelect");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@department", cmbDepartment.SelectedValue);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbActivity.DisplayMember = "activity";
                    cmbActivity.ValueMember = "code";
                    cmbActivity.DataSource = dt;
                }
                else
                {
                    cmbActivity.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
