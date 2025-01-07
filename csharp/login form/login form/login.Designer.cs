namespace login_form
{
    partial class frmlogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.imgFormBackground = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblLogin = new Guna.UI.WinForms.GunaLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.imgUsername = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblForgotPassword = new Guna.UI.WinForms.GunaLabel();
            this.lblCreateAccount = new Guna.UI.WinForms.GunaLabel();
            this.dragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgFormBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFormBackground
            // 
            this.imgFormBackground.BaseColor = System.Drawing.Color.White;
            this.imgFormBackground.Image = ((System.Drawing.Image)(resources.GetObject("imgFormBackground.Image")));
            this.imgFormBackground.Location = new System.Drawing.Point(-206, -178);
            this.imgFormBackground.Name = "imgFormBackground";
            this.imgFormBackground.Size = new System.Drawing.Size(576, 557);
            this.imgFormBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFormBackground.TabIndex = 0;
            this.imgFormBackground.TabStop = false;
            this.imgFormBackground.UseTransfarantBackground = false;
            // 
            // imgClose
            // 
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(657, 12);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(28, 27);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgClose.TabIndex = 1;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLogin.Location = new System.Drawing.Point(401, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(185, 53);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "User Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(442, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ShortcutsEnabled = false;
            this.txtUsername.Size = new System.Drawing.Size(223, 33);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = " Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(442, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(223, 33);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = " Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(64)))), ((int)(((byte)(26)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(408, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Size = new System.Drawing.Size(257, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgUsername
            // 
            this.imgUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.imgUsername.Image = ((System.Drawing.Image)(resources.GetObject("imgUsername.Image")));
            this.imgUsername.Location = new System.Drawing.Point(411, 99);
            this.imgUsername.Name = "imgUsername";
            this.imgUsername.Size = new System.Drawing.Size(28, 27);
            this.imgUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsername.TabIndex = 3;
            this.imgUsername.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUsername.Location = new System.Drawing.Point(408, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(34, 33);
            this.lblUsername.TabIndex = 1;
            // 
            // imgPassword
            // 
            this.imgPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.imgPassword.Image = ((System.Drawing.Image)(resources.GetObject("imgPassword.Image")));
            this.imgPassword.Location = new System.Drawing.Point(411, 149);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(28, 27);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPassword.TabIndex = 4;
            this.imgPassword.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPassword.Location = new System.Drawing.Point(408, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 33);
            this.lblPassword.TabIndex = 1;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(408, 259);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(257, 35);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.Text = "Forgot Username or Password?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(405, 316);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(257, 35);
            this.lblCreateAccount.TabIndex = 3;
            this.lblCreateAccount.Text = "Create Your Account ->";
            this.lblCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateAccount.MouseLeave += new System.EventHandler(this.lblCreateAccount_MouseLeave);
            this.lblCreateAccount.MouseHover += new System.EventHandler(this.lblCreateAccount_MouseHover);
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 366);
            this.ControlBox = false;
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.imgUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.imgClose);
            this.Controls.Add(this.imgFormBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFormBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox imgFormBackground;
        private System.Windows.Forms.PictureBox imgClose;
        private Guna.UI.WinForms.GunaLabel lblLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private System.Windows.Forms.PictureBox imgUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox imgPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI.WinForms.GunaLabel lblForgotPassword;
        private Guna.UI.WinForms.GunaLabel lblCreateAccount;
        private Guna.UI.WinForms.GunaDragControl dragControl;
    }
}

