using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CAManager
{
    public partial class Home : MaterialSkin.Controls.MaterialForm
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
     
        public Home()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlSidebar.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        Services services = new Services();
        private void Form1_Load(object sender, EventArgs e)
        {
   btnCompFee.Visible = false;

            if (Services.User.role == "HOD")
            {
                btnUserRegistration.Visible = false;
                btnFirm.Visible = false;
                btnAllTask.Visible = false;
                btnReport.Visible = false;
                btnRegistration.Visible = false;
                btnCompany.Visible = false;
                btnMaster.Visible = false;
                btnFrmInvc.Visible = false;
            }
            else if (Services.User.role == "RECEPTIONIST")
            {
                btnFirm.Visible = false;
                btnAllTask.Visible = false;
                btnReport.Visible = false;
                btnActivities.Visible = false;
                btnFrmInvc.Visible = false;
                btnUserRegistration.Visible = false;
            }
            else if (Services.User.role == "PROCESS")
            {
                btnUserRegistration.Visible = false;
                btnFirm.Visible = false;
                btnReport.Visible = false;
                btnRegistration.Visible = false;
                btnCompany.Visible = false;
                btnMaster.Visible = false;
                btnFrmInvc.Visible = false;
            }
            else if (Services.User.role == "BILLING CLERK")
            {
                btnUserRegistration.Visible = false;
                btnFirm.Visible = false;
                btnAllTask.Visible = false;
                btnRegistration.Visible = false;
                btnCompany.Visible = false;
                btnMaster.Visible = false;
                btnActivities.Visible = false;
            }
            else if (Services.User.role == "ADMIN")
            {
                btnCompFee.Visible = false;
            }

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Primary.Teal500, MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.WHITE);

            statuslbl_dept.Text = "Department: " + Services.User.department;
            statuslbl_name.Text = "Name: " + Services.User.name;
            statuslbl_Role.Text = "Role: " + Services.User.role;
            //if (Services.User.role == "REGISTER")
            //{
            //    btnUserRegistration.Visible = false;
            //    btnActivities.Visible = false;
            //    btnAllTask.Visible = false;
            //    btnExit.Location = new Point(3, 254);
            //}
            //else if (Services.User.role != "ADMIN")
            //{
            //    btnAllTask.Visible = false;
            //    btnExit.Location = new Point(0, 380);
            //}
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(191, 215, 234);
            public static Color color2 = Color.FromArgb(191, 215, 234);
            public static Color color3 = Color.FromArgb(191, 215, 234);
            public static Color color4 = Color.FromArgb(191, 215, 234);
            public static Color color5 = Color.FromArgb(191, 215, 234);
            public static Color color6 = Color.FromArgb(191, 215, 234);
            public static Color color7 = Color.FromArgb(191, 215, 234);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                currentChildForm = childForm;
                //End
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelBody.Controls.Add(childForm);
                panelBody.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTitleChildForm.Text = childForm.Text;
            }
            catch (Exception ex)
            {
                services.MessageBoxError(ex);
            }
        }



        private void btnTransaction_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color2);
            //OpenChildForm(new frmTransaction());

        }

        private void btnChallanDetails_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color3);
            //OpenChildForm(new frmChallan());
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.ForeColor = Color.MediumPurple;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form c in this.MdiChildren)
                    c.Close();
                this.Close();

                Services.User = null;
                Login page = new Login();
                page.Show();
            }
        }

        private void pnlTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmDetailMaster());
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmRegistration());
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmCompany());
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmActivity());
            lblnotofication.Text = frmActivity.count.ToString();
            frmActivity.count = 0;
        }

        private void btnCompFee_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new frmCompanyFees());
        }

        private void btnAllTask_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTaskList());
            lblnotofication.Text = frmTaskList.count.ToString();
            frmTaskList.count = 0;
        }

        private void btnchPWD(object sender, EventArgs e)
        {

        }

        private void btnUserRegistration_Click_1(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmUserRegister());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmReport());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmFirm());
        }

        private void frmInvoice_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmInvoice());
        }
    }
}
