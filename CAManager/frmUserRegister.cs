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
    public partial class frmUserRegister : MaterialSkin.Controls.MaterialForm
    {
        public frmUserRegister()
        {
            InitializeComponent();
        }
        Services services = new Services();
        private void frmUserRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sp_deptSelect' table. You can move, or remove it, as needed.
            this.sp_deptSelectTableAdapter.Fill(this.dataSet1.sp_deptSelect, null);
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);

            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Action";
            EditButtonColumn.Text = "Edit";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            gvUser.Columns.Add(EditButtonColumn);


            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn();
            DeleteButtonColumn.Name = "Status";
            DeleteButtonColumn.Text = "Active";
            DeleteButtonColumn.UseColumnTextForButtonValue = false;
            gvUser.Columns.Add(DeleteButtonColumn);

            loadUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") { txtName.Focus(); MessageBox.Show("Name cannot be blank.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtMobile.Text == "") { txtMobile.Focus(); MessageBox.Show("Mobile cannot be blank.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtPassword.Text == "" && txtId.Text == "") { txtPassword.Focus(); MessageBox.Show("Password cannot be blank.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txtUsername.Text == "") { txtUsername.Focus(); MessageBox.Show("Username cannot be blank.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cmbDepartment.SelectedValue == null) { cmbDepartment.Focus(); MessageBox.Show("Please select Department.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


            Services services = new Services();
            SqlCommand cmd = services.CreateSqlConnection("sp_userInsert");
            cmd.Connection.Open();
            try {
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@email", txtUsername.Text);
                if (txtPassword.Text != "")
                    cmd.Parameters.AddWithValue("@password", services.Encrypt(txtPassword.Text));
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@adharNo", txtAdharNo.Text);
                cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                cmd.Parameters.AddWithValue("@designation", cmbRole.Text);
                cmd.Parameters.AddWithValue("@department", cmbDepartment.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Saved Successfully");
                    txtAddress.Text = txtAdharNo.Text = txtMobile.Text = txtName.Text = txtPassword.Text = txtUsername.Text = "";
                    cmbDepartment.SelectedIndex = cmbRole.SelectedIndex = 0;

                    loadUser();
                }
                else
                    MessageBox.Show("Something Wrong");
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
            finally
            {
                cmd.Connection.Close();
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

        void loadUser()
        {
            SqlCommand cmd = services.CreateSqlConnection("[sp_selectUser]");
            cmd.Connection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        private void txtAdharNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
            if (txtAdharNo.Text.Length >= 12)
            {
                if (e.KeyChar == 8)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }



        private void gvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = gvUser.Rows[e.RowIndex];

                string status = selectedRow.Cells["status"].Value.ToString();

                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["E-mail"].Value.ToString();
                txtMobile.Text = selectedRow.Cells["Mobile"].Value.ToString();
                cmbRole.Text = selectedRow.Cells["Role"].Value.ToString();
                cmbDepartment.Text = selectedRow.Cells["Departmet"].Value.ToString();
                txtAdharNo.Text = selectedRow.Cells["Adhar"].Value.ToString();
            }
        }

        private void gvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = gvUser.Rows[e.RowIndex];
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)selectedRow.Cells[1];

                    SqlCommand cmdd = services.CreateSqlConnection("[sp_userInsert]");
                    cmdd.Connection.Open();
                    cmdd.Parameters.AddWithValue("@email", gvUser.CurrentRow.Cells[6].Value);

                    if (gvUser.Rows[e.RowIndex].Cells[11].Value.ToString() != "1")
                    {
                        gvUser.CurrentCell.Value = "Inactive";
                        gvUser.CurrentRow.Cells[11].Value = 1;
                        gvUser.CurrentRow.Cells[1].Style.BackColor = Color.Red;
                        cmdd.Parameters.AddWithValue("@status", 1);
                    }
                    else
                    {
                        gvUser.CurrentCell.Value = "Active";
                        gvUser.CurrentRow.Cells[11].Value = 0;
                        gvUser.CurrentRow.Cells[1].Style.BackColor = Color.Green;
                        cmdd.Parameters.AddWithValue("@status", 0);
                    }
                    cmdd.ExecuteNonQuery();

                cmdd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }

        private void gvUser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < gvUser.RowCount; i++)
            {
                if (gvUser.Rows[i].Cells[11].Value.ToString() == "1")
                {
                    gvUser.Rows[i].Cells[1].Value = "Inactive";
                    gvUser.Rows[i].Cells[1].Style.BackColor = Color.Red;
                }
                else
                {
                    gvUser.Rows[i].Cells[1].Value = "Active";
                    gvUser.Rows[i].Cells[1].Style.BackColor = Color.Green;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtMobile.Text = string.Empty;
            cmbRole.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            txtAdharNo.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
