using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAManager
{
    public partial class frmActivity : MaterialSkin.Controls.MaterialForm
    {
        public static int count;
        Services services = new Services();
        private string uploadedFilePath;
        private string ofileName;
        public static ClientFile clientFile = new ClientFile();
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);
            cmbForwardTo.Visible = lblFT.Visible = true;
            chboxTask.Visible = true;

            if (Services.User.role == "HOD")
            {
                cmbForwardTo.Enabled = true;
            }
            if(Services.User.role == "PROCESS")
            {
                cmbForwardTo.Visible = false;
                lblFT.Visible = false;
                chbRev.Visible = false;
            }
            if (Services.User.role == "ADMIN")
            {
                cmbForwardTo.Visible = false;
                lblFT.Visible = false;
                chbadminhelp.Visible = false;
            }
            else
            {
                chbadminhelp.Visible = true;
            }

            loadActivity();

            count = gvActivityList.Rows.Count - 1;
            if (count < 0)
                count = 0;
        }


        private DataTable GetForwardToData(int fileId)
        {
            string connectionString = Properties.Settings.Default.CAManagerConnectionString;
            string query = "sp_selectUserforForword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fileno", fileId);

                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void gvActivityList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= gvActivityList.Rows.Count)
                    return;

                listBoxComment.DataSource = null;
                listBoxFiles.DataSource = null;
                DataGridViewRow row = gvActivityList.Rows[e.RowIndex];

                if (int.TryParse(row.Cells[0].Value?.ToString(), out int id))
                {
                    clientFile.id = id;
                    clientFile.status = Convert.ToInt32(row.Cells[18].Value);
                    clientFile.fileNo = row.Cells[2].Value?.ToString() ?? "";
                    txtClientName.Text = row.Cells[5].Value?.ToString() ?? "";
                    txtForwardto.Text = row.Cells[6].Value?.ToString() ?? "";
                    txtlastupdate.Text = row.Cells[17].Value?.ToString() ?? "";
                    txtStatus.Text = row.Cells[12].Value?.ToString() ?? "";

                    int idColumnIndex = 0;
                    string idValue = row.Cells[idColumnIndex].Value?.ToString();

                    string connectionString = Properties.Settings.Default.CAManagerConnectionString;
                    string query = "[sp_commentSelect]";
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", idValue);
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);


                        listBoxFiles.DataSource = dt;
                        listBoxFiles.DisplayMember = "DocumentName";
                        listBoxFiles.ValueMember = "filePath";

                        listBoxComment.DataSource = dt;
                        listBoxComment.DisplayMember = "comment";
                        listBoxComment.ValueMember = "comment";
                    }

                }
                DataTable forwardToData = GetForwardToData(id);
                cmbForwardTo.DataSource = forwardToData;
                cmbForwardTo.DisplayMember = "name";
                cmbForwardTo.ValueMember = "id";
                cmbForwardTo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }

        private void LoadFileLink(string filePath, string serverFilePath)
        {
            LinkLabel fileLink = new LinkLabel();
            fileLink.Text = filePath;
            fileLink.AutoSize = true;
            fileLink.LinkClicked += (s, ev) =>
            {
                try
                {
                    System.Diagnostics.Process.Start(serverFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open the file. Error: " + ex.Message);
                }
            };

            listBoxFiles.Items.Clear();
            listBoxFiles.Items.Add(fileLink.ToString());
        }
        void getComment(int fileId)
        {
            listBoxComment.DataSource = null;
            DataTable dt = sp_commentSelectTableAdapter.GetData(fileId);
            foreach (DataRow row in dt.Rows)
            {
                string fileName = row["FilePath"].ToString();
                string serverFilePath = Path.Combine(@"E:\Office Work\5). May\Windows Application\CAManager\CAManager\Docs", fileName);
                LoadFileLink(fileName, serverFilePath);
                listBoxComment.Items.Add(Convert.ToDateTime(row[0].ToString()).ToString("dd/MM/yyyy") + " | " + row[1].ToString() + " | ");
            }
        }
        bool updateStatus()
        {
            SqlCommand cmd = services.CreateSqlConnection("sp_fileStatusUpdate");

            try
            {
                if (txtCommentBox.Text == "" || clientFile.id == 0)
                    return false;
                else
                {
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@id", clientFile.id);
                    cmd.Parameters.AddWithValue("@comments", txtCommentBox.Text);

                    if (cmbForwardTo.SelectedIndex > 0 && cmbForwardTo.Visible == true)
                    {
                        cmd.Parameters.AddWithValue("@forwardTo", cmbForwardTo.Text);
                        cmd.Parameters.AddWithValue("@forwardBy", Services.User.name);
                        cmd.Parameters.AddWithValue("@status", clientFile.status + 1);
                    }
                    else if (txtCommentBox.Text != "" && cmbForwardTo.Visible == false && chboxTask.Checked == false && chbRev.Checked == false && chbadminhelp.Checked == false)
                    {
                        cmd.Parameters.AddWithValue("@forwardTo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@forwardBy", Services.User.name);
                        cmd.Parameters.AddWithValue("@status", clientFile.status);
                    }
                    else if (chboxTask.Checked == true)
                    {
                        if (clientFile.status == 5 && Services.User.role == "HOD")
                        {
                            cmd.Parameters.AddWithValue("@status", clientFile.status + 1);
                        }
                        else if (Services.User.role == "ADMIN")
                        {

                            cmd.Parameters.AddWithValue("@status", clientFile.status + 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@status", 5);
                        }
                    }
                    else if (chbRev.Checked == true)
                    {
                        if(clientFile.status == 6 && Services.User.role == "ADMIN")
                        {
                            cmd.Parameters.AddWithValue("@status", clientFile.status - 1);
                        }
                       else if(clientFile.status == 5 && Services.User.role == "HOD")
                        {
                            cmd.Parameters.AddWithValue("@status", clientFile.status - 3);
                        }
                    }
                    else if (chbadminhelp.Checked == true)
                    {
                        if (clientFile.status == 2 && Services.User.role == "PROCESS")
                        {
                            cmd.Parameters.AddWithValue("@adminHelp", "Y");
                            cmd.Parameters.AddWithValue("@status", clientFile.status + 4);
                        }
                        else if (clientFile.status == 1 && Services.User.role == "HOD")
                        {
                            cmd.Parameters.AddWithValue("@adminHelp", "Y");
                            cmd.Parameters.AddWithValue("@status", clientFile.status + 2);
                        }
                    }

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }

                
            }
            catch(Exception ex) 
            {
                services.MessageBoxError(ex);
                return false;
            }
            finally
            {
                if(cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!updateStatus())
                {
                    MessageBox.Show("Comment box cannot be blank.");
                    return;
                }

                SqlCommand cmd = services.CreateSqlConnection("sp_activityInsert");
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@fileId", clientFile.id);
                if (cmbForwardTo.Visible == true && cmbForwardTo.SelectedIndex > 0)
                {
                    cmd.Parameters.AddWithValue("@forwardTo", cmbForwardTo.Text);
                }

                cmd.Parameters.AddWithValue("@enteredBy", Services.User.name);
                cmd.Parameters.AddWithValue("@comment", txtCommentBox.Text);
                cmd.Parameters.AddWithValue("@filepath", uploadedFilePath);
                cmd.Parameters.AddWithValue("@DocumentName", ofileName);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Updated Successfully.", "Activity Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClientName.Text = txtCommentBox.Text = txtForwardto.Text = txtlastupdate.Text = txtStatus.Text = "";
                    if (cmbForwardTo.Visible == true)
                        cmbForwardTo.SelectedIndex = 0;
                    listBoxComment.DataSource = null;
                    listBoxComment.DataSource = null;
                    chboxTask.Checked = false;
                    listBoxFiles.DataSource = null;
                    cmd.Connection.Close();
                    loadActivity();
                }
                else
                {
                    MessageBox.Show("Something wrong");
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
            //finally
            //{
            //}
        }
        private void loadActivity()
        {
            try
            {
                SqlCommand cmd = services.CreateSqlConnection("sp_fileRegSelect");
                cmd.Parameters.AddWithValue("@department", Services.User.department);
                cmd.Parameters.AddWithValue("@role", Services.User.role);
                cmd.Parameters.AddWithValue("@forwardTo", Services.User.name);
                cmd.Connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gvActivityList.DataSource = dt;

                    DataTable forwardToData = dt.DefaultView.ToTable(true, "ForwardTo");
                    cmbForwardTo.DataSource = forwardToData;
                    cmbForwardTo.DisplayMember = "ForwardTo";
                    cmbForwardTo.ValueMember = "ForwardTo";

                    cmbForwardTo.SelectedIndex = 0;
                }
                else
                {
                    gvActivityList.DataSource = null;
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
            GetForwardToData(count);
        }

        private void chboxTask_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxTask.Checked)
                chboxTask.Text = "Complete";
            else
                chboxTask.Text = "Pending";
        }
        private void chbadminhelp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbadminhelp.Checked == true)
            {
                lblFT.Visible = false;
                cmbForwardTo.Visible = false;
            }
            else
            {
                lblFT.Visible = true;
                cmbForwardTo.Visible = true;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
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

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            string filePath = ((ListBox)sender).SelectedValue.ToString();

            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void chbRev_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRev.Checked)
                chbRev.Text = "Reverted";
            else
                chbRev.Text = "Revert";
        }
    }
}