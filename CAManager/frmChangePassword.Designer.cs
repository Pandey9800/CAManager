namespace CAManager
{
    partial class frmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRePassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMsg = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Hint = "new password";
            this.txtPassword.Location = new System.Drawing.Point(57, 122);
            this.txtPassword.MaximumSize = new System.Drawing.Size(346, 23);
            this.txtPassword.MinimumSize = new System.Drawing.Size(346, 23);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(346, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Hint = "username";
            this.txtUsername.Location = new System.Drawing.Point(57, 91);
            this.txtUsername.MaximumSize = new System.Drawing.Size(346, 25);
            this.txtUsername.MinimumSize = new System.Drawing.Size(346, 25);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(346, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Depth = 0;
            this.txtRePassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Hint = "new password, again";
            this.txtRePassword.Location = new System.Drawing.Point(57, 153);
            this.txtRePassword.MaximumSize = new System.Drawing.Size(346, 23);
            this.txtRePassword.MinimumSize = new System.Drawing.Size(346, 23);
            this.txtRePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '\0';
            this.txtRePassword.SelectedText = "";
            this.txtRePassword.SelectionLength = 0;
            this.txtRePassword.SelectionStart = 0;
            this.txtRePassword.Size = new System.Drawing.Size(346, 23);
            this.txtRePassword.TabIndex = 3;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.MouseLeave += new System.EventHandler(this.txtRePassword_MouseLeave);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Depth = 0;
            this.lblMsg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(102, 261);
            this.lblMsg.MaximumSize = new System.Drawing.Size(273, 19);
            this.lblMsg.MinimumSize = new System.Drawing.Size(273, 19);
            this.lblMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(273, 19);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconSize = 20;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUpdate.Location = new System.Drawing.Point(320, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(83, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 300);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnUpdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRePassword;
        private MaterialSkin.Controls.MaterialLabel lblMsg;
    }
}