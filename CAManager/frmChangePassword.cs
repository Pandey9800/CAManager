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
    public partial class frmChangePassword : MaterialSkin.Controls.MaterialForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        Services services = new Services();
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = services.CreateSqlConnection("[sp_userInsert]");
            try
            {
                if (txtPassword.Text == "") { MessageBox.Show("password cannot be blank."); txtPassword.Focus(); return; } 
                if (txtUsername.Text == "") { MessageBox.Show("username cannot be blank"); txtUsername.Focus();  return; } 
                if (txtRePassword.Text == "") { MessageBox.Show("password cannot be blank."); txtRePassword.Focus(); return; } 
                
                cmd = services.CreateSqlConnection("[sp_userInsert]");
                cmd.Parameters.AddWithValue("@email", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", services.Encrypt(txtRePassword.Text));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Updated Successfully.", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login page = new Login();
                    page.Show();
                }
                else
                {
                    MessageBox.Show("Something wrong");
                }
            }
            catch(Exception ex)
            {
                services.MessageBoxError(ex);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        private void txtRePassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                lblMsg.Text = "password not match, please check.";
                lblMsg.ForeColor = Color.Red;
            }
            else
            {
                lblMsg.Text = "";
            }
                
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
