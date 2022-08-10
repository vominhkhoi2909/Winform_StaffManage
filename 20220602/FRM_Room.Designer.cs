
namespace View
{
    partial class frm_Room
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
            this.lbl_Room = new System.Windows.Forms.Label();
            this.txt_Room = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.grp_Room = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pic_Like = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_Lightning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgv_Room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ele_Room = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pic_Trash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.grp_Room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Trash)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.BackColor = System.Drawing.Color.White;
            this.lbl_Room.ForeColor = System.Drawing.Color.Black;
            this.lbl_Room.Location = new System.Drawing.Point(3, 46);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(116, 28);
            this.lbl_Room.TabIndex = 16;
            this.lbl_Room.Text = "Tên phòng:";
            // 
            // txt_Room
            // 
            this.txt_Room.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Room.DefaultText = "";
            this.txt_Room.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Room.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Room.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Room.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Room.Location = new System.Drawing.Point(8, 80);
            this.txt_Room.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Room.Name = "txt_Room";
            this.txt_Room.PasswordChar = '\0';
            this.txt_Room.PlaceholderText = "Enter Text";
            this.txt_Room.SelectedText = "";
            this.txt_Room.Size = new System.Drawing.Size(430, 36);
            this.txt_Room.TabIndex = 15;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.White;
            this.lbl_Status.ForeColor = System.Drawing.Color.Black;
            this.lbl_Status.Location = new System.Drawing.Point(552, 46);
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
            this.btn_Update.Location = new System.Drawing.Point(739, 141);
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
            this.btn_Add.Location = new System.Drawing.Point(602, 141);
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
            this.btn_Renew.Location = new System.Drawing.Point(479, 141);
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
            this.btn_Delete.Location = new System.Drawing.Point(867, 141);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 45);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Search.Location = new System.Drawing.Point(831, 214);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 45);
            this.btn_Search.TabIndex = 26;
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
            this.txt_Search.Location = new System.Drawing.Point(523, 214);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search Text";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(300, 45);
            this.txt_Search.TabIndex = 25;
            // 
            // grp_Room
            // 
            this.grp_Room.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Room.BorderColor = System.Drawing.Color.Black;
            this.grp_Room.BorderRadius = 20;
            this.grp_Room.Controls.Add(this.lbl_Room);
            this.grp_Room.Controls.Add(this.txt_Room);
            this.grp_Room.Controls.Add(this.pic_Like);
            this.grp_Room.Controls.Add(this.lbl_Status);
            this.grp_Room.Controls.Add(this.pic_Lightning);
            this.grp_Room.Controls.Add(this.btn_Update);
            this.grp_Room.Controls.Add(this.btn_Add);
            this.grp_Room.Controls.Add(this.btn_Renew);
            this.grp_Room.Controls.Add(this.btn_Delete);
            this.grp_Room.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grp_Room.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Room.ForeColor = System.Drawing.Color.White;
            this.grp_Room.Location = new System.Drawing.Point(14, 16);
            this.grp_Room.Margin = new System.Windows.Forms.Padding(6);
            this.grp_Room.MinimumSize = new System.Drawing.Size(938, 189);
            this.grp_Room.Name = "grp_Room";
            this.grp_Room.Size = new System.Drawing.Size(939, 189);
            this.grp_Room.TabIndex = 23;
            this.grp_Room.Text = "Thông Tin Phòng Ban";
            this.grp_Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_Like
            // 
            this.pic_Like.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Like.BackColor = System.Drawing.Color.White;
            this.pic_Like.Image = global::View.Properties.Resources.like;
            this.pic_Like.ImageRotate = 0F;
            this.pic_Like.Location = new System.Drawing.Point(446, 46);
            this.pic_Like.MaximumSize = new System.Drawing.Size(100, 100);
            this.pic_Like.MinimumSize = new System.Drawing.Size(50, 70);
            this.pic_Like.Name = "pic_Like";
            this.pic_Like.Size = new System.Drawing.Size(100, 70);
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
            this.pic_Lightning.Location = new System.Drawing.Point(446, 43);
            this.pic_Lightning.MaximumSize = new System.Drawing.Size(100, 100);
            this.pic_Lightning.Name = "pic_Lightning";
            this.pic_Lightning.Size = new System.Drawing.Size(100, 73);
            this.pic_Lightning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Lightning.TabIndex = 12;
            this.pic_Lightning.TabStop = false;
            // 
            // dgv_Room
            // 
            this.dgv_Room.AllowUserToAddRows = false;
            this.dgv_Room.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Room.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Room.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Room.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Room.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Room.ColumnHeadersHeight = 60;
            this.dgv_Room.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Room,
            this.Room_Name,
            this.Room_Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Room.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Room.EnableHeadersVisualStyles = false;
            this.dgv_Room.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Room.Location = new System.Drawing.Point(15, 271);
            this.dgv_Room.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_Room.Name = "dgv_Room";
            this.dgv_Room.ReadOnly = true;
            this.dgv_Room.RowHeadersVisible = false;
            this.dgv_Room.RowTemplate.Height = 25;
            this.dgv_Room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Room.Size = new System.Drawing.Size(939, 295);
            this.dgv_Room.TabIndex = 22;
            this.dgv_Room.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Room.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Room.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgv_Room.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Room.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Room.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Room.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Room.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Room.ThemeStyle.HeaderStyle.Height = 60;
            this.dgv_Room.ThemeStyle.ReadOnly = true;
            this.dgv_Room.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgv_Room.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Room.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Room.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Room.ThemeStyle.RowsStyle.Height = 25;
            this.dgv_Room.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgv_Room.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Room.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Room_CellDoubleClick);
            // 
            // Id_Room
            // 
            this.Id_Room.DataPropertyName = "Id_Room";
            this.Id_Room.HeaderText = "ID";
            this.Id_Room.Name = "Id_Room";
            this.Id_Room.ReadOnly = true;
            // 
            // Room_Name
            // 
            this.Room_Name.DataPropertyName = "Room_Name";
            this.Room_Name.HeaderText = "Tên Phòng Ban";
            this.Room_Name.Name = "Room_Name";
            this.Room_Name.ReadOnly = true;
            // 
            // Room_Status
            // 
            this.Room_Status.DataPropertyName = "Room_Status";
            this.Room_Status.HeaderText = "Status";
            this.Room_Status.Name = "Room_Status";
            this.Room_Status.ReadOnly = true;
            this.Room_Status.Visible = false;
            // 
            // ele_Room
            // 
            this.ele_Room.BorderRadius = 20;
            this.ele_Room.TargetControl = this;
            // 
            // pic_Exit
            // 
            this.pic_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Exit.Image = global::View.Properties.Resources.x;
            this.pic_Exit.Location = new System.Drawing.Point(962, 12);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(30, 30);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 24;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // pic_Trash
            // 
            this.pic_Trash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Trash.Image = global::View.Properties.Resources.trash;
            this.pic_Trash.ImageRotate = 0F;
            this.pic_Trash.Location = new System.Drawing.Point(470, 214);
            this.pic_Trash.Name = "pic_Trash";
            this.pic_Trash.Size = new System.Drawing.Size(45, 45);
            this.pic_Trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Trash.TabIndex = 27;
            this.pic_Trash.TabStop = false;
            this.pic_Trash.Click += new System.EventHandler(this.pic_Trash_Click);
            // 
            // frm_Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.pic_Trash);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.grp_Room);
            this.Controls.Add(this.dgv_Room);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1004, 581);
            this.Name = "frm_Room";
            this.grp_Room.ResumeLayout(false);
            this.grp_Room.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Lightning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Room)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Trash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Room;
        private Guna.UI2.WinForms.Guna2TextBox txt_Room;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Like;
        private System.Windows.Forms.Label lbl_Status;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Lightning;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2Button btn_Renew;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.PictureBox pic_Exit;
        private Guna.UI2.WinForms.Guna2GroupBox grp_Room;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Room;
        private Guna.UI2.WinForms.Guna2Elipse ele_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Status;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Trash;
    }
}