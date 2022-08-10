
namespace View
{
    partial class frm_Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ele_Account = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pic_Trash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_Like = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_Lightning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.grp_Account = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pic_Show = new System.Windows.Forms.PictureBox();
            this.pic_Hide = new System.Windows.Forms.PictureBox();
            this.cbo_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_Account = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.grp_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // ele_Account
            // 
            this.ele_Account.BorderRadius = 20;
            this.ele_Account.TargetControl = this;
            // 
            // pic_Trash
            // 
            this.pic_Trash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Trash.Image = global::View.Properties.Resources.trash;
            this.pic_Trash.ImageRotate = 0F;
            this.pic_Trash.Location = new System.Drawing.Point(466, 261);
            this.pic_Trash.Name = "pic_Trash";
            this.pic_Trash.Size = new System.Drawing.Size(45, 45);
            this.pic_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Trash.TabIndex = 33;
            this.pic_Trash.TabStop = false;
            this.pic_Trash.Click += new System.EventHandler(this.pic_Trash_Click);
            // 
            // pic_Like
            // 
            this.pic_Like.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Like.BackColor = System.Drawing.Color.White;
            this.pic_Like.Image = global::View.Properties.Resources.like;
            this.pic_Like.ImageRotate = 0F;
            this.pic_Like.Location = new System.Drawing.Point(19, 125);
            this.pic_Like.MaximumSize = new System.Drawing.Size(100, 100);
            this.pic_Like.MinimumSize = new System.Drawing.Size(50, 70);
            this.pic_Like.Name = "pic_Like";
            this.pic_Like.Size = new System.Drawing.Size(100, 100);
            this.pic_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Like.TabIndex = 14;
            this.pic_Like.TabStop = false;
            // 
            // pic_Lightning
            // 
            this.pic_Lightning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Lightning.BackColor = System.Drawing.Color.White;
            this.pic_Lightning.Image = global::View.Properties.Resources.lightning;
            this.pic_Lightning.ImageRotate = 0F;
            this.pic_Lightning.Location = new System.Drawing.Point(19, 122);
            this.pic_Lightning.MaximumSize = new System.Drawing.Size(100, 100);
            this.pic_Lightning.Name = "pic_Lightning";
            this.pic_Lightning.Size = new System.Drawing.Size(100, 100);
            this.pic_Lightning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Lightning.TabIndex = 12;
            this.pic_Lightning.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.AutoRoundedCorners = true;
            this.btn_Search.BorderRadius = 21;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(827, 261);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 45);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(519, 261);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search Text";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(300, 45);
            this.txt_Search.TabIndex = 31;
            // 
            // pic_Exit
            // 
            this.pic_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Exit.Image = global::View.Properties.Resources.x;
            this.pic_Exit.Location = new System.Drawing.Point(961, 13);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(30, 30);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 30;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // grp_Account
            // 
            this.grp_Account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Account.BorderColor = System.Drawing.Color.Black;
            this.grp_Account.BorderRadius = 20;
            this.grp_Account.Controls.Add(this.pic_Show);
            this.grp_Account.Controls.Add(this.pic_Hide);
            this.grp_Account.Controls.Add(this.cbo_Type);
            this.grp_Account.Controls.Add(this.lbl_Type);
            this.grp_Account.Controls.Add(this.lbl_Password);
            this.grp_Account.Controls.Add(this.txt_Password);
            this.grp_Account.Controls.Add(this.lbl_Username);
            this.grp_Account.Controls.Add(this.txt_Username);
            this.grp_Account.Controls.Add(this.pic_Like);
            this.grp_Account.Controls.Add(this.lbl_Status);
            this.grp_Account.Controls.Add(this.pic_Lightning);
            this.grp_Account.Controls.Add(this.btn_Update);
            this.grp_Account.Controls.Add(this.btn_Add);
            this.grp_Account.Controls.Add(this.btn_Renew);
            this.grp_Account.Controls.Add(this.btn_Delete);
            this.grp_Account.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grp_Account.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Account.ForeColor = System.Drawing.Color.White;
            this.grp_Account.Location = new System.Drawing.Point(13, 17);
            this.grp_Account.Margin = new System.Windows.Forms.Padding(6);
            this.grp_Account.MinimumSize = new System.Drawing.Size(938, 189);
            this.grp_Account.Name = "grp_Account";
            this.grp_Account.Size = new System.Drawing.Size(939, 235);
            this.grp_Account.TabIndex = 29;
            this.grp_Account.Text = "Thông Tin Tài Khoản";
            this.grp_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_Show
            // 
            this.pic_Show.BackColor = System.Drawing.Color.White;
            this.pic_Show.Image = global::View.Properties.Resources.show;
            this.pic_Show.Location = new System.Drawing.Point(424, 49);
            this.pic_Show.Name = "pic_Show";
            this.pic_Show.Size = new System.Drawing.Size(25, 25);
            this.pic_Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Show.TabIndex = 35;
            this.pic_Show.TabStop = false;
            this.pic_Show.Click += new System.EventHandler(this.pic_Show_Click);
            // 
            // pic_Hide
            // 
            this.pic_Hide.BackColor = System.Drawing.Color.White;
            this.pic_Hide.Image = global::View.Properties.Resources.hide;
            this.pic_Hide.Location = new System.Drawing.Point(424, 49);
            this.pic_Hide.Name = "pic_Hide";
            this.pic_Hide.Size = new System.Drawing.Size(25, 25);
            this.pic_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hide.TabIndex = 34;
            this.pic_Hide.TabStop = false;
            this.pic_Hide.Click += new System.EventHandler(this.pic_Hide_Click);
            // 
            // cbo_Type
            // 
            this.cbo_Type.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Type.ItemHeight = 30;
            this.cbo_Type.Items.AddRange(new object[] {
            "",
            "Master",
            "Admin",
            "Staff",
            "Guest"});
            this.cbo_Type.Location = new System.Drawing.Point(624, 80);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(298, 36);
            this.cbo_Type.TabIndex = 21;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.BackColor = System.Drawing.Color.White;
            this.lbl_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Type.Location = new System.Drawing.Point(619, 46);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(151, 28);
            this.lbl_Type.TabIndex = 20;
            this.lbl_Type.Text = "Loại tài khoản:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.White;
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(311, 46);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(107, 28);
            this.lbl_Password.TabIndex = 18;
            this.lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(316, 80);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PlaceholderText = "Enter Text";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(298, 36);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.White;
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(3, 46);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(145, 28);
            this.lbl_Username.TabIndex = 16;
            this.lbl_Username.Text = "Tên tài khoản:";
            // 
            // txt_Username
            // 
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Location = new System.Drawing.Point(8, 80);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Username.MaxLength = 20;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderText = "Enter Text";
            this.txt_Username.SelectedText = "";
            this.txt_Username.Size = new System.Drawing.Size(298, 36);
            this.txt_Username.TabIndex = 15;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.White;
            this.lbl_Status.ForeColor = System.Drawing.Color.Black;
            this.lbl_Status.Location = new System.Drawing.Point(125, 125);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(71, 28);
            this.lbl_Status.TabIndex = 13;
            this.lbl_Status.Text = "Status";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.AutoRoundedCorners = true;
            this.btn_Update.BorderRadius = 21;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(739, 187);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(122, 45);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.AutoRoundedCorners = true;
            this.btn_Add.BorderRadius = 21;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(602, 187);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(131, 45);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm Mới";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Renew
            // 
            this.btn_Renew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Renew.AutoRoundedCorners = true;
            this.btn_Renew.BorderRadius = 21;
            this.btn_Renew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Renew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Renew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Renew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Renew.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Renew.ForeColor = System.Drawing.Color.White;
            this.btn_Renew.Location = new System.Drawing.Point(479, 187);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(117, 45);
            this.btn_Renew.TabIndex = 9;
            this.btn_Renew.Text = "Làm Mới";
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.AutoRoundedCorners = true;
            this.btn_Delete.BorderRadius = 21;
            this.btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(867, 187);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 45);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_Account
            // 
            this.dgv_Account.AllowUserToAddRows = false;
            this.dgv_Account.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Account.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Account.ColumnHeadersHeight = 60;
            this.dgv_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Account,
            this.Username,
            this.Type,
            this.Password,
            this.Account_Status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Account.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Account.EnableHeadersVisualStyles = false;
            this.dgv_Account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Account.Location = new System.Drawing.Point(13, 315);
            this.dgv_Account.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.ReadOnly = true;
            this.dgv_Account.RowHeadersVisible = false;
            this.dgv_Account.RowTemplate.Height = 25;
            this.dgv_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Account.Size = new System.Drawing.Size(939, 251);
            this.dgv_Account.TabIndex = 34;
            this.dgv_Account.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Account.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Account.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Account.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Account.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Account.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Account.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Account.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Account.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Account.ThemeStyle.HeaderStyle.Height = 60;
            this.dgv_Account.ThemeStyle.ReadOnly = true;
            this.dgv_Account.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgv_Account.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Account.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Account.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Account.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_Account.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgv_Account.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Account.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellDoubleClick_1);
            // 
            // Id_Account
            // 
            this.Id_Account.DataPropertyName = "Id_Account";
            this.Id_Account.HeaderText = "ID";
            this.Id_Account.Name = "Id_Account";
            this.Id_Account.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tài Khoản";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại TK";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // Account_Status
            // 
            this.Account_Status.DataPropertyName = "Account_Status";
            this.Account_Status.HeaderText = "Status";
            this.Account_Status.Name = "Account_Status";
            this.Account_Status.ReadOnly = true;
            this.Account_Status.Visible = false;
            // 
            // frm_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(649F, 1446F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.dgv_Account);
            this.Controls.Add(this.pic_Trash);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.grp_Account);
            this.Font = new System.Drawing.Font("Segoe UI", 815.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(324, 334, 324, 334);
            this.MinimumSize = new System.Drawing.Size(1004, 581);
            this.Name = "frm_Account";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.grp_Account.ResumeLayout(false);
            this.grp_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_Account;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Trash;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.PictureBox pic_Exit;
        private Guna.UI2.WinForms.Guna2GroupBox grp_Account;
        private System.Windows.Forms.Label lbl_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Like;
        private System.Windows.Forms.Label lbl_Status;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Lightning;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Type;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Password;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.PictureBox pic_Show;
        private System.Windows.Forms.PictureBox pic_Hide;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Status;
    }
}