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
    public partial class frmTaskList : MaterialSkin.Controls.MaterialForm
    {
        public frmTaskList()
        {
            InitializeComponent();
        }
        public static int count;
        Services services = new Services();

        private void frmTaskList_Load(object sender, EventArgs e)
        {
                this.sp_customerGroupSelectTableAdapter.Fill(this.dataSet1.sp_customerGroupSelect);
                this.sp_statusSelectTableAdapter.Fill(this.dataSet1.sp_statusSelect);
                MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedItem != null && cmbgroup.SelectedItem != null)
                {
                    if (cmbStatus.SelectedIndex != 0)
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, cmbStatus.SelectedValue.ToString(), cmbgroup.Text.ToString());
                    }
                    else
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, "All", "All");
                    }
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }

        void loadTask(string fromdate, string todate, string status, string group)
        {
            try
            {
                SqlCommand cmd = services.CreateSqlConnection("sp_taskListWithFilter");
                cmd.Parameters.AddWithValue("@fromDate", fromdate);
                cmd.Parameters.AddWithValue("@toDate", todate);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@group", group);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    count = 0;
                    count = gvTaskList.Rows.Count - 1;
                    gvTaskList.DataSource = dt;
                }
                else
                {
                    count = 0;
                    gvTaskList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedItem != null && cmbgroup.SelectedItem != null)
                {
                    if (cmbStatus.SelectedIndex != 0 && cmbgroup.SelectedIndex != 0)
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, cmbStatus.SelectedValue.ToString(), cmbgroup.Text.ToString());
                    }
                    else
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, "All", "All");
                    }
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedItem != null && cmbgroup.SelectedItem != null)
                {
                    if (cmbStatus.SelectedIndex != 0 && cmbgroup.SelectedIndex != 0)
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, cmbStatus.SelectedValue.ToString(), cmbgroup.Text.ToString());
                    }
                    else
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, "All", "All");
                    }
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }

        private void cmbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedItem != null && cmbgroup.SelectedItem != null)
                {
                    if (cmbStatus.SelectedIndex != 0 && cmbgroup.SelectedIndex != 0)
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, cmbStatus.SelectedValue.ToString(), cmbgroup.Text.ToString());
                    }
                    else
                    {
                        loadTask(dtpFrom.Text, dtpTo.Text, "All", "All");
                    }
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "All Tasks List.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                ToCsV(gvTaskList, sfd.FileName);
            }
        }

        public void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);

            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }
    }
}
