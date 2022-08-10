
namespace View
{
    partial class frm_LoadingScreen
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
            this.ele_LoadingScreen = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pgb_Loading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CreateBy = new System.Windows.Forms.Label();
            this.pgb_Loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // ele_LoadingScreen
            // 
            this.ele_LoadingScreen.BorderRadius = 20;
            this.ele_LoadingScreen.TargetControl = this;
            // 
            // pgb_Loading
            // 
            this.pgb_Loading.BackColor = System.Drawing.Color.Transparent;
            this.pgb_Loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pgb_Loading.Controls.Add(this.lbl_Value);
            this.pgb_Loading.Controls.Add(this.label2);
            this.pgb_Loading.FillColor = System.Drawing.Color.White;
            this.pgb_Loading.FillThickness = 15;
            this.pgb_Loading.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pgb_Loading.ForeColor = System.Drawing.Color.White;
            this.pgb_Loading.Location = new System.Drawing.Point(103, 187);
            this.pgb_Loading.Minimum = 1;
            this.pgb_Loading.Name = "pgb_Loading";
            this.pgb_Loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pgb_Loading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pgb_Loading.ProgressThickness = 15;
            this.pgb_Loading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pgb_Loading.Size = new System.Drawing.Size(221, 221);
            this.pgb_Loading.TabIndex = 0;
            this.pgb_Loading.Value = 1;
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbl_Value.Location = new System.Drawing.Point(143, 99);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(41, 28);
            this.lbl_Value.TabIndex = 3;
            this.lbl_Value.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loading...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading Screen";
            // 
            // lbl_CreateBy
            // 
            this.lbl_CreateBy.AutoSize = true;
            this.lbl_CreateBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbl_CreateBy.Location = new System.Drawing.Point(177, 518);
            this.lbl_CreateBy.Name = "lbl_CreateBy";
            this.lbl_CreateBy.Size = new System.Drawing.Size(63, 25);
            this.lbl_CreateBy.TabIndex = 2;
            this.lbl_CreateBy.Text = "V.M.K";
            // 
            // frm_LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(442, 552);
            this.Controls.Add(this.lbl_CreateBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgb_Loading);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pgb_Loading.ResumeLayout(false);
            this.pgb_Loading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_LoadingScreen;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pgb_Loading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_CreateBy;
    }
}