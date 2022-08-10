
namespace View
{
    partial class frm_Staff
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
            this.ele_Staff = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgv_Staff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id_Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Staff = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbo_Room = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_Like = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.pic_Lightning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.pic_Trash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            this.grp_Staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // ele_Staff
            // 
            this.ele_Staff.BorderRadius = 20;
            this.ele_Staff.TargetControl = this;
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.AllowUserToAddRows = false;
            this.dgv_Staff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Staff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Staff.ColumnHeadersHeight = 60;
            this.dgv_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Staff,
            this.Id_Room,
            this.Id_Account,
            this.Staff_Name,
            this.Phone,
            this.Gender,
            this.Address,
            this.Room_Name,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Staff.EnableHeadersVisualStyles = false;
            this.dgv_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Staff.Location = new System.Drawing.Point(15, 359);
            this.dgv_Staff.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.ReadOnly = true;
            this.dgv_Staff.RowHeadersVisible = false;
            this.dgv_Staff.RowTemplate.Height = 25;
            this.dgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Staff.Size = new System.Drawing.Size(938, 207);
            this.dgv_Staff.TabIndex = 0;
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
            // Id_Account
            // 
            this.Id_Account.DataPropertyName = "Id_Account";
            this.Id_Account.HeaderText = "Id_Account";
            this.Id_Account.Name = "Id_Account";
            this.Id_Account.ReadOnly = true;
            this.Id_Account.Visible = false;
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
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
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
            // grp_Staff
            // 
            this.grp_Staff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Staff.BorderColor = System.Drawing.Color.Black;
            this.grp_Staff.BorderRadius = 20;
            this.grp_Staff.Controls.Add(this.cbo_Room);
            this.grp_Staff.Controls.Add(this.lbl_Room);
            this.grp_Staff.Controls.Add(this.lbl_Address);
            this.grp_Staff.Controls.Add(this.txt_Address);
            this.grp_Staff.Controls.Add(this.pic_Like);
            this.grp_Staff.Controls.Add(this.lbl_Status);
            this.grp_Staff.Controls.Add(this.pic_Lightning);
            this.grp_Staff.Controls.Add(this.btn_Update);
            this.grp_Staff.Controls.Add(this.btn_Add);
            this.grp_Staff.Controls.Add(this.btn_Renew);
            this.grp_Staff.Controls.Add(this.btn_Delete);
            this.grp_Staff.Controls.Add(this.cbo_Gender);
            this.grp_Staff.Controls.Add(this.lbl_Gender);
            this.grp_Staff.Controls.Add(this.txt_Phone);
            this.grp_Staff.Controls.Add(this.lbl_Phone);
            this.grp_Staff.Controls.Add(this.txt_Name);
            this.grp_Staff.Controls.Add(this.lbl_Name);
            this.grp_Staff.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grp_Staff.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Staff.ForeColor = System.Drawing.Color.White;
            this.grp_Staff.Location = new System.Drawing.Point(15, 15);
            this.grp_Staff.Margin = new System.Windows.Forms.Padding(6);
            this.grp_Staff.Name = "grp_Staff";
            this.grp_Staff.Size = new System.Drawing.Size(938, 284);
            this.grp_Staff.TabIndex = 1;
            this.grp_Staff.Text = "Thông Tin Nhân Viên";
            this.grp_Staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_Room
            // 
            this.cbo_Room.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Room.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Room.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Room.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.cbo_Room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Room.ItemHeight = 30;
            this.cbo_Room.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ",
            "Khác"});
            this.cbo_Room.Location = new System.Drawing.Point(314, 155);
            this.cbo_Room.Name = "cbo_Room";
            this.cbo_Room.Size = new System.Drawing.Size(300, 36);
            this.cbo_Room.TabIndex = 18;
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.BackColor = System.Drawing.Color.White;
            this.lbl_Room.ForeColor = System.Drawing.Color.Black;
            this.lbl_Room.Location = new System.Drawing.Point(309, 124);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(118, 28);
            this.lbl_Room.TabIndex = 17;
            this.lbl_Room.Text = "Phòng ban:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.White;
            this.lbl_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Address.Location = new System.Drawing.Point(619, 48);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(78, 28);
            this.lbl_Address.TabIndex = 16;
            this.lbl_Address.Text = "Địa chỉ";
            // 
            // txt_Address
            // 
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Location = new System.Drawing.Point(624, 82);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.PlaceholderText = "Enter Text";
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(300, 36);
            this.txt_Address.TabIndex = 15;
            // 
            // pic_Like
            // 
            this.pic_Like.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Like.BackColor = System.Drawing.Color.White;
            this.pic_Like.Image = global::View.Properties.Resources.like;
            this.pic_Like.ImageRotate = 0F;
            this.pic_Like.Location = new System.Drawing.Point(8, 197);
            this.pic_Like.MaximumSize = new System.Drawing.Size(100, 100);
            this.pic_Like.MinimumSize = new System.Drawing.Size(50, 70);
            this.pic_Like.Name = "pic_Like";
            this.pic_Like.Size = new System.Drawing.Size(100, 70);
            this.pic_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Like.TabIndex = 14;
            this.pic_Like.TabStop = false;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.White;
            this.lbl_Status.ForeColor = System.Drawing.Color.Black;
            this.lbl_Status.Location = new System.Drawing.Point(114, 197);
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
            this.pic_Lightning.Location = new System.Drawing.Point(8, 194);
            this.pic_Lightning.MaximumSize = new System.Drawing.Size(100, 100);
            this.pic_Lightning.Name = "pic_Lightning";
            this.pic_Lightning.Size = new System.Drawing.Size(100, 70);
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
            this.btn_Update.Location = new System.Drawing.Point(738, 236);
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
            this.btn_Add.Location = new System.Drawing.Point(601, 236);
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
            this.btn_Renew.Location = new System.Drawing.Point(478, 236);
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
            this.btn_Delete.Location = new System.Drawing.Point(866, 236);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 45);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cbo_Gender
            // 
            this.cbo_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_Gender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.cbo_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_Gender.ItemHeight = 30;
            this.cbo_Gender.Items.AddRange(new object[] {
            "",
            "Nam",
            "Nữ",
            "Khác"});
            this.cbo_Gender.Location = new System.Drawing.Point(8, 155);
            this.cbo_Gender.Name = "cbo_Gender";
            this.cbo_Gender.Size = new System.Drawing.Size(300, 36);
            this.cbo_Gender.TabIndex = 7;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.White;
            this.lbl_Gender.ForeColor = System.Drawing.Color.Black;
            this.lbl_Gender.Location = new System.Drawing.Point(3, 124);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 28);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "Giới tính:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(314, 82);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Phone.MaxLength = 10;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "Enter Number";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(300, 36);
            this.txt_Phone.TabIndex = 3;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.BackColor = System.Drawing.Color.White;
            this.lbl_Phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_Phone.Location = new System.Drawing.Point(309, 51);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(143, 28);
            this.lbl_Phone.TabIndex = 2;
            this.lbl_Phone.Text = "Số điện thoại:";
            // 
            // txt_Name
            // 
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(8, 82);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Name.MaxLength = 50;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PlaceholderText = "Enter Text";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(300, 36);
            this.txt_Name.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Name.Location = new System.Drawing.Point(3, 51);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(149, 28);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Tên nhân viên:";
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
            this.txt_Search.Location = new System.Drawing.Point(523, 305);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search Text";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(300, 45);
            this.txt_Search.TabIndex = 15;
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
            this.btn_Search.Location = new System.Drawing.Point(831, 305);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 45);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pic_Trash
            // 
            this.pic_Trash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Trash.Image = global::View.Properties.Resources.trash;
            this.pic_Trash.ImageRotate = 0F;
            this.pic_Trash.Location = new System.Drawing.Point(470, 305);
            this.pic_Trash.Name = "pic_Trash";
            this.pic_Trash.Size = new System.Drawing.Size(45, 45);
            this.pic_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Trash.TabIndex = 22;
            this.pic_Trash.TabStop = false;
            this.pic_Trash.Click += new System.EventHandler(this.pic_Trash_Click);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Exit.Image = global::View.Properties.Resources.x;
            this.pic_Exit.Location = new System.Drawing.Point(962, 12);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(30, 30);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 5;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.pic_Trash);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.grp_Staff);
            this.Controls.Add(this.dgv_Staff);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1004, 581);
            this.Name = "frm_Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            this.grp_Staff.ResumeLayout(false);
            this.grp_Staff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ele_Staff;
        private Guna.UI2.WinForms.Guna2GroupBox grp_Staff;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Staff;
        private System.Windows.Forms.PictureBox pic_Exit;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Like;
        private System.Windows.Forms.Label lbl_Status;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Lightning;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Address;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_Room;
        private System.Windows.Forms.Label lbl_Room;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Trash;
    }
}