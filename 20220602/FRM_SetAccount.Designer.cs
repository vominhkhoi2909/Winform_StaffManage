
namespace View
{
    partial class frm_SetAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Account_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Account = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.ele_Account = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_Like = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.pic_Lightning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SearchAccount = new Guna.UI2.WinForms.Guna2Button();
            this.txt_SearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.grp_Account = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.txt_Staff = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.dgv_Staff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id_Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SearchStaff = new Guna.UI2.WinForms.Guna2Button();
            this.txt_SearchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.chk_DaCoTK = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).BeginInit();
            this.grp_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // Account_Status
            // 
            this.Account_Status.DataPropertyName = "Account_Status";
            this.Account_Status.HeaderText = "Status";
            this.Account_Status.Name = "Account_Status";
            this.Account_Status.ReadOnly = true;
            this.Account_Status.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại TK";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tài Khoản";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Id_Account
            // 
            this.Id_Account.DataPropertyName = "Id_Account";
            this.Id_Account.HeaderText = "ID";
            this.Id_Account.Name = "Id_Account";
            this.Id_Account.ReadOnly = true;
            // 
            // dgv_Account
            // 
            this.dgv_Account.AllowUserToAddRows = false;
            this.dgv_Account.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Account.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Account.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Account.ColumnHeadersHeight = 60;
            this.dgv_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Account,
            this.Username,
            this.Type,
            this.Password,
            this.Account_Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Account.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Account.EnableHeadersVisualStyles = false;
            this.dgv_Account.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Account.Location = new System.Drawing.Point(580, 316);
            this.dgv_Account.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_Account.MinimumSize = new System.Drawing.Size(369, 250);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.ReadOnly = true;
            this.dgv_Account.RowHeadersVisible = false;
            this.dgv_Account.RowTemplate.Height = 25;
            this.dgv_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Account.Size = new System.Drawing.Size(369, 250);
            this.dgv_Account.TabIndex = 40;
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
            this.dgv_Account.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Account.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Account.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_Account.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgv_Account.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Account.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellDoubleClick);
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // cbo_Type
            // 
            this.cbo_Type.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Type.Enabled = false;
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
            this.cbo_Type.Location = new System.Drawing.Point(314, 80);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(298, 36);
            this.cbo_Type.TabIndex = 21;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.BackColor = System.Drawing.Color.White;
            this.lbl_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Type.Location = new System.Drawing.Point(309, 46);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(151, 28);
            this.lbl_Type.TabIndex = 20;
            this.lbl_Type.Text = "Loại tài khoản:";
            // 
            // ele_Account
            // 
            this.ele_Account.BorderRadius = 20;
            this.ele_Account.TargetControl = this;
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
            this.txt_Username.Enabled = false;
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
            this.btn_Update.Location = new System.Drawing.Point(814, 187);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(122, 45);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Lưu";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
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
            this.btn_Renew.Location = new System.Drawing.Point(691, 187);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(117, 45);
            this.btn_Renew.TabIndex = 9;
            this.btn_Renew.Text = "Làm Mới";
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // btn_SearchAccount
            // 
            this.btn_SearchAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchAccount.AutoRoundedCorners = true;
            this.btn_SearchAccount.BorderRadius = 21;
            this.btn_SearchAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SearchAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_SearchAccount.ForeColor = System.Drawing.Color.White;
            this.btn_SearchAccount.Location = new System.Drawing.Point(827, 262);
            this.btn_SearchAccount.Name = "btn_SearchAccount";
            this.btn_SearchAccount.Size = new System.Drawing.Size(122, 45);
            this.btn_SearchAccount.TabIndex = 38;
            this.btn_SearchAccount.Text = "Tìm Kiếm";
            this.btn_SearchAccount.Click += new System.EventHandler(this.btn_SearchAccount_Click);
            // 
            // txt_SearchAccount
            // 
            this.txt_SearchAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SearchAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchAccount.DefaultText = "";
            this.txt_SearchAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchAccount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchAccount.Location = new System.Drawing.Point(580, 262);
            this.txt_SearchAccount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_SearchAccount.Name = "txt_SearchAccount";
            this.txt_SearchAccount.PasswordChar = '\0';
            this.txt_SearchAccount.PlaceholderText = "Search Text";
            this.txt_SearchAccount.SelectedText = "";
            this.txt_SearchAccount.Size = new System.Drawing.Size(239, 45);
            this.txt_SearchAccount.TabIndex = 37;
            // 
            // grp_Account
            // 
            this.grp_Account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Account.BorderColor = System.Drawing.Color.Black;
            this.grp_Account.BorderRadius = 20;
            this.grp_Account.Controls.Add(this.lbl_Staff);
            this.grp_Account.Controls.Add(this.txt_Staff);
            this.grp_Account.Controls.Add(this.cbo_Type);
            this.grp_Account.Controls.Add(this.lbl_Type);
            this.grp_Account.Controls.Add(this.lbl_Username);
            this.grp_Account.Controls.Add(this.txt_Username);
            this.grp_Account.Controls.Add(this.pic_Like);
            this.grp_Account.Controls.Add(this.lbl_Status);
            this.grp_Account.Controls.Add(this.pic_Lightning);
            this.grp_Account.Controls.Add(this.btn_Update);
            this.grp_Account.Controls.Add(this.btn_Renew);
            this.grp_Account.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grp_Account.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Account.ForeColor = System.Drawing.Color.White;
            this.grp_Account.Location = new System.Drawing.Point(13, 18);
            this.grp_Account.Margin = new System.Windows.Forms.Padding(6);
            this.grp_Account.MinimumSize = new System.Drawing.Size(938, 189);
            this.grp_Account.Name = "grp_Account";
            this.grp_Account.Size = new System.Drawing.Size(939, 235);
            this.grp_Account.TabIndex = 35;
            this.grp_Account.Text = "Thông Tin Tài Khoản";
            this.grp_Account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.BackColor = System.Drawing.Color.White;
            this.lbl_Staff.ForeColor = System.Drawing.Color.Black;
            this.lbl_Staff.Location = new System.Drawing.Point(615, 46);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(114, 28);
            this.lbl_Staff.TabIndex = 23;
            this.lbl_Staff.Text = "Nhân viên:";
            // 
            // txt_Staff
            // 
            this.txt_Staff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Staff.DefaultText = "";
            this.txt_Staff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Staff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Staff.Enabled = false;
            this.txt_Staff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Staff.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Staff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Staff.Location = new System.Drawing.Point(620, 80);
            this.txt_Staff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Staff.MaxLength = 20;
            this.txt_Staff.Name = "txt_Staff";
            this.txt_Staff.PasswordChar = '\0';
            this.txt_Staff.PlaceholderText = "Enter Text";
            this.txt_Staff.SelectedText = "";
            this.txt_Staff.Size = new System.Drawing.Size(298, 36);
            this.txt_Staff.TabIndex = 22;
            // 
            // pic_Exit
            // 
            this.pic_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Exit.Image = global::View.Properties.Resources.x;
            this.pic_Exit.Location = new System.Drawing.Point(961, 14);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(30, 30);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 36;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.AllowUserToAddRows = false;
            this.dgv_Staff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Staff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Staff.ColumnHeadersHeight = 60;
            this.dgv_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Staff,
            this.Id_Room,
            this.dataGridViewTextBoxColumn1,
            this.Staff_Name,
            this.Phone,
            this.Gender,
            this.Address,
            this.Room_Name,
            this.Status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Staff.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Staff.EnableHeadersVisualStyles = false;
            this.dgv_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Staff.Location = new System.Drawing.Point(15, 316);
            this.dgv_Staff.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_Staff.MinimumSize = new System.Drawing.Size(553, 250);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.ReadOnly = true;
            this.dgv_Staff.RowHeadersVisible = false;
            this.dgv_Staff.RowTemplate.Height = 25;
            this.dgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Staff.Size = new System.Drawing.Size(553, 250);
            this.dgv_Staff.TabIndex = 41;
            this.dgv_Staff.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Staff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Staff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Staff.ThemeStyle.HeaderStyle.Height = 60;
            this.dgv_Staff.ThemeStyle.ReadOnly = true;
            this.dgv_Staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgv_Staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Staff.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_Staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgv_Staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Staff_CellDoubleClick);
            // 
            // Id_Staff
            // 
            this.Id_Staff.DataPropertyName = "Id_Staff";
            this.Id_Staff.HeaderText = "ID";
            this.Id_Staff.Name = "Id_Staff";
            this.Id_Staff.ReadOnly = true;
            // 
            // Id_Room
            // 
            this.Id_Room.DataPropertyName = "Id_Room";
            this.Id_Room.HeaderText = "Id_Room";
            this.Id_Room.Name = "Id_Room";
            this.Id_Room.ReadOnly = true;
            this.Id_Room.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Account";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Account";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Staff_Name
            // 
            this.Staff_Name.DataPropertyName = "Staff_Name";
            this.Staff_Name.HeaderText = "Họ Tên";
            this.Staff_Name.Name = "Staff_Name";
            this.Staff_Name.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "SĐT";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // Room_Name
            // 
            this.Room_Name.DataPropertyName = "Room_Name";
            this.Room_Name.HeaderText = "Phòng Ban";
            this.Room_Name.Name = "Room_Name";
            this.Room_Name.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Staff_Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // btn_SearchStaff
            // 
            this.btn_SearchStaff.AutoRoundedCorners = true;
            this.btn_SearchStaff.BorderRadius = 21;
            this.btn_SearchStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SearchStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SearchStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SearchStaff.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btn_SearchStaff.ForeColor = System.Drawing.Color.White;
            this.btn_SearchStaff.Location = new System.Drawing.Point(261, 262);
            this.btn_SearchStaff.Name = "btn_SearchStaff";
            this.btn_SearchStaff.Size = new System.Drawing.Size(122, 45);
            this.btn_SearchStaff.TabIndex = 43;
            this.btn_SearchStaff.Text = "Tìm Kiếm";
            this.btn_SearchStaff.Click += new System.EventHandler(this.btn_SearchStaff_Click);
            // 
            // txt_SearchStaff
            // 
            this.txt_SearchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchStaff.DefaultText = "";
            this.txt_SearchStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SearchStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SearchStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SearchStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchStaff.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SearchStaff.Location = new System.Drawing.Point(14, 262);
            this.txt_SearchStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_SearchStaff.Name = "txt_SearchStaff";
            this.txt_SearchStaff.PasswordChar = '\0';
            this.txt_SearchStaff.PlaceholderText = "Search Text";
            this.txt_SearchStaff.SelectedText = "";
            this.txt_SearchStaff.Size = new System.Drawing.Size(239, 45);
            this.txt_SearchStaff.TabIndex = 42;
            // 
            // chk_DaCoTK
            // 
            this.chk_DaCoTK.AutoSize = true;
            this.chk_DaCoTK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_DaCoTK.CheckedState.BorderRadius = 0;
            this.chk_DaCoTK.CheckedState.BorderThickness = 0;
            this.chk_DaCoTK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_DaCoTK.Location = new System.Drawing.Point(389, 275);
            this.chk_DaCoTK.Name = "chk_DaCoTK";
            this.chk_DaCoTK.Size = new System.Drawing.Size(180, 32);
            this.chk_DaCoTK.TabIndex = 44;
            this.chk_DaCoTK.Text = "Đã có tài khoản";
            this.chk_DaCoTK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_DaCoTK.UncheckedState.BorderRadius = 0;
            this.chk_DaCoTK.UncheckedState.BorderThickness = 0;
            this.chk_DaCoTK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_DaCoTK.CheckedChanged += new System.EventHandler(this.chk_DaCoTK_CheckedChanged);
            // 
            // frm_SetAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.chk_DaCoTK);
            this.Controls.Add(this.btn_SearchStaff);
            this.Controls.Add(this.txt_SearchStaff);
            this.Controls.Add(this.dgv_Staff);
            this.Controls.Add(this.dgv_Account);
            this.Controls.Add(this.btn_SearchAccount);
            this.Controls.Add(this.txt_SearchAccount);
            this.Controls.Add(this.grp_Account);
            this.Controls.Add(this.pic_Exit);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1004, 581);
            this.Name = "frm_SetAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).EndInit();
            this.grp_Account.ResumeLayout(false);
            this.grp_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Account;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Type;
        private System.Windows.Forms.Label lbl_Type;
        private Guna.UI2.WinForms.Guna2Elipse ele_Account;
        private System.Windows.Forms.Label lbl_Username;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Like;
        private System.Windows.Forms.Label lbl_Status;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Lightning;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private Guna.UI2.WinForms.Guna2Button btn_SearchAccount;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchAccount;
        private Guna.UI2.WinForms.Guna2GroupBox grp_Account;
        private System.Windows.Forms.PictureBox pic_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_SearchStaff;
        private Guna.UI2.WinForms.Guna2TextBox txt_SearchStaff;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Staff;
        private System.Windows.Forms.Label lbl_Staff;
        private Guna.UI2.WinForms.Guna2TextBox txt_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2CheckBox chk_DaCoTK;
    }
}