
namespace View
{
    partial class frm_ForgetPassword
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
            this.ele_ForgetPassword = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_SendOTP = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ele_ForgetPassword
            // 
            this.ele_ForgetPassword.BorderRadius = 20;
            this.ele_ForgetPassword.TargetControl = this;
            // 
            // btn_SendOTP
            // 
            this.btn_SendOTP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SendOTP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SendOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SendOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SendOTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SendOTP.ForeColor = System.Drawing.Color.White;
            this.btn_SendOTP.Location = new System.Drawing.Point(131, 398);
            this.btn_SendOTP.Name = "btn_SendOTP";
            this.btn_SendOTP.Size = new System.Drawing.Size(180, 45);
            this.btn_SendOTP.TabIndex = 0;
            this.btn_SendOTP.Text = "Nhận OTP";
            this.btn_SendOTP.Click += new System.EventHandler(this.btn_SendOTP_Click);
            // 
            // frm_ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(442, 552);
            this.Controls.Add(this.btn_SendOTP);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frm_ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_ForgetPassword;
        private Guna.UI2.WinForms.Guna2Button btn_SendOTP;
    }
}