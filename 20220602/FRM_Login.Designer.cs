
namespace View
{
    partial class frm_Login
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
            this.ele_Loign = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_LoginWith = new System.Windows.Forms.Label();
            this.pic_FB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_GG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_Password = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_Username = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_ForgotPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.pic_Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ele_Loign
            // 
            this.ele_Loign.BorderRadius = 20;
            this.ele_Loign.TargetControl = this;
            // 
            // txt_Password
            // 
            this.txt_Password.AutoRoundedCorners = true;
            this.txt_Password.BorderRadius = 21;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(115, 244);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PlaceholderText = "Enter password";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(260, 45);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            this.txt_Username.AutoRoundedCorners = true;
            this.txt_Username.BorderRadius = 21;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Location = new System.Drawing.Point(115, 187);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Username.MaxLength = 20;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderText = "Enter username";
            this.txt_Username.SelectedText = "";
            this.txt_Username.Size = new System.Drawing.Size(260, 45);
            this.txt_Username.TabIndex = 9;
            // 
            // lbl_LoginWith
            // 
            this.lbl_LoginWith.AutoSize = true;
            this.lbl_LoginWith.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginWith.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginWith.Location = new System.Drawing.Point(163, 462);
            this.lbl_LoginWith.Name = "lbl_LoginWith";
            this.lbl_LoginWith.Size = new System.Drawing.Size(112, 28);
            this.lbl_LoginWith.TabIndex = 12;
            this.lbl_LoginWith.Text = "Login with";
            // 
            // pic_FB
            // 
            this.pic_FB.Image = global::View.Properties.Resources.facebook;
            this.pic_FB.ImageRotate = 0F;
            this.pic_FB.Location = new System.Drawing.Point(166, 495);
            this.pic_FB.Name = "pic_FB";
            this.pic_FB.Size = new System.Drawing.Size(45, 45);
            this.pic_FB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_FB.TabIndex = 15;
            this.pic_FB.TabStop = false;
            // 
            // pic_GG
            // 
            this.pic_GG.Image = global::View.Properties.Resources.google;
            this.pic_GG.ImageRotate = 0F;
            this.pic_GG.Location = new System.Drawing.Point(221, 495);
            this.pic_GG.Name = "pic_GG";
            this.pic_GG.Size = new System.Drawing.Size(45, 45);
            this.pic_GG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_GG.TabIndex = 13;
            this.pic_GG.TabStop = false;
            // 
            // pic_Password
            // 
            this.pic_Password.Image = global::View.Properties.Resources.password;
            this.pic_Password.ImageRotate = 0F;
            this.pic_Password.Location = new System.Drawing.Point(62, 244);
            this.pic_Password.Name = "pic_Password";
            this.pic_Password.Size = new System.Drawing.Size(45, 45);
            this.pic_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Password.TabIndex = 11;
            this.pic_Password.TabStop = false;
            // 
            // pic_Username
            // 
            this.pic_Username.Image = global::View.Properties.Resources.user;
            this.pic_Username.ImageRotate = 0F;
            this.pic_Username.Location = new System.Drawing.Point(62, 187);
            this.pic_Username.Name = "pic_Username";
            this.pic_Username.Size = new System.Drawing.Size(45, 45);
            this.pic_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Username.TabIndex = 10;
            this.pic_Username.TabStop = false;
            // 
            // btn_ForgotPassword
            // 
            this.btn_ForgotPassword.AutoRoundedCorners = true;
            this.btn_ForgotPassword.BorderRadius = 21;
            this.btn_ForgotPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ForgotPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ForgotPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ForgotPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_ForgotPassword.ForeColor = System.Drawing.Color.White;
            this.btn_ForgotPassword.Image = global::View.Properties.Resources.forget;
            this.btn_ForgotPassword.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_ForgotPassword.Location = new System.Drawing.Point(62, 349);
            this.btn_ForgotPassword.Name = "btn_ForgotPassword";
            this.btn_ForgotPassword.Size = new System.Drawing.Size(313, 45);
            this.btn_ForgotPassword.TabIndex = 8;
            this.btn_ForgotPassword.Text = "Forgot Password";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoRoundedCorners = true;
            this.btn_Exit.BorderRadius = 21;
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::View.Properties.Resources.exit;
            this.btn_Exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Exit.Location = new System.Drawing.Point(62, 400);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(313, 45);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BorderRadius = 21;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = global::View.Properties.Resources.login_2;
            this.btn_Login.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Login.Location = new System.Drawing.Point(62, 298);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(313, 45);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = global::View.Properties.Resources.question;
            this.pic_Logo.ImageRotate = 0F;
            this.pic_Logo.Location = new System.Drawing.Point(120, 12);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(233, 166);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 2;
            this.pic_Logo.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(442, 552);
            this.Controls.Add(this.pic_FB);
            this.Controls.Add(this.pic_GG);
            this.Controls.Add(this.lbl_LoginWith);
            this.Controls.Add(this.pic_Password);
            this.Controls.Add(this.pic_Username);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_ForgotPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pic_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_FB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_Loign;
        private Guna.UI2.WinForms.Guna2Button btn_ForgotPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Logo;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Password;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2PictureBox pic_FB;
        private Guna.UI2.WinForms.Guna2PictureBox pic_GG;
        private System.Windows.Forms.Label lbl_LoginWith;
    }
}