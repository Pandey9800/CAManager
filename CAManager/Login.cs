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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Services services = new Services();
                SqlCommand cmd = services.CreateSqlConnection("sp_login");
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string username = txtUsername.Text;
                    string mobile = txtUsername.Text;
                    string password = services.Decrypt(dt.Rows[0]["password"].ToString());

                    Login login = new Login();
                    if (dt.Rows[0]["email"].ToString() == username && txtPassword.Text == password || dt.Rows[0]["mobile"].ToString() == mobile && txtPassword.Text == password)
                    {
                        DataRow row = dt.Rows[0];

                        User user = new User();
                        user.id = Convert.ToInt32(row["id"]);
                        user.name = row["name"].ToString();
                        user.email = row["email"].ToString();
                        user.password = row["password"].ToString();
                        user.mobile = row["mobile"].ToString();
                        user.adharNo = row["adharNo"].ToString();
                        user.address = row["address"].ToString();
                        user.designation = row["designation"].ToString();
                        user.department = row["department"].ToString();
                        
                        //user.status = Convert.ToInt32(row["status"].ToString());//TODO:
                        user.role = row["role"].ToString();                     
                            Services.User = user;
                            this.Hide();
                            Home master = new Home();
                            master.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void materialLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePassword page = new frmChangePassword();
            page.Show();
        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {
            //frmUserRegister page = new frmUserRegister();
            //this.Hide();
            //page.Show();
        }
    }
}
