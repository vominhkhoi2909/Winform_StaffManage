using Controller;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frm_QuanLyNhanVien : Form
    {
        #region Var Form
        tAccount tk = new tAccount(); //Lưu thông tin tk login hiện tại.
        tStaff nv = new tStaff(); //Lưu thông tin người sở hữu tài khoản hiện tại nếu có.
        #endregion

        #region Constructor
        //Hàm khởi tạo mặc định sử dụng cho test form.
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            customSubMenu(); 
            lbl_Type.Text += "";
            lbl_Account.Text += "";
            lbl_Name.Text += "";
        }

        //Hàm khởi tạo mặc định với thông tin tk với nv.
        public frm_QuanLyNhanVien(tAccount acc, tStaff sta)
        {
            InitializeComponent();
            customSubMenu();
            tk = acc; //Lưu lại thông tin login.
            nv = sta; //Lưu lại thông tin nv.

            //Hiển thị lên bản status.
            lbl_Type.Text += tk.Type;
            lbl_Account.Text += tk.Username;
            lbl_Name.Text += nv.Staff_Name;
        }
        #endregion

        #region Hide / Show SubMenu
        //Hàm ẩn tất cả submenu.
        private void customSubMenu()
        {
            pnl_SubDanhMuc.Visible = false;
            pnl_SubGiupDo.Visible = false;
            pnl_SubHeThong.Visible = false;
            pnl_SubHocSinh.Visible = false;
            pnl_SubThongKe.Visible = false;
        }

        //Hàm thực hiện ẩn/hiện submenu qua mỗi lần click.
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Hàm mở submenu tương ứng / button
        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_SubDanhMuc);
        }

        private void btn_QLHocSinh_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_SubHocSinh);
        }

        private void btn_BCThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_SubThongKe);
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_SubHeThong);
        }

        private void btn_GiupDo_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_SubGiupDo);
        }
        #endregion

        #region Child Form
        Form activeForm = null;
        //Hàm chèn form vào trong panel.
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_ChildForm.Controls.Add(childForm);
            pnl_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Button Func
        //Hàm mở form tương ứng / button.
        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_ChangePassword frm = new frm_ChangePassword(tk);
            openChildForm(frm);
        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frm_Staff frm = new frm_Staff(tk);
            openChildForm(frm);
        }

        private void btn_QuanLyPhongBan_Click(object sender, EventArgs e)
        {
            frm_Room frm = new frm_Room(tk);
            openChildForm(frm);
        }

        private void btn_QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if(tk.Type == "Master" || tk.Type == "Admin")
            {
                frm_Account frm = new frm_Account(tk);
                openChildForm(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm xử lý đăng xuất.
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            //Hiển thị thông báo để người dùng xác nhận.
            var mes = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mes == DialogResult.Yes)
            {
                frm_Login frm = new frm_Login();
                this.Hide();
                frm.Show();
            }
        }

        //Hàm thiết lập tài khoản cho người dùng.
        private void btn_ThietLapTaiKhoan_Click(object sender, EventArgs e)
        {
            if (tk.Type == "Master" || tk.Type == "Admin")
            {
                frm_SetAccount frm = new frm_SetAccount(tk);
                openChildForm(frm);
            }
            else
            {
                MessageBox.Show("Bạn không đủ quyền hạn để truy cập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm xử lý mở các form rỗng.
        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Điểm Danh");
            openChildForm(frm);
        }

        private void btn_KhenThuong_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Khen Thưởng");
            openChildForm(frm);
        }

        private void btn_KyLuat_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Kỷ Luật");
            openChildForm(frm);
        }

        private void btn_DanhSachLuong_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Danh Sách Lương");
            openChildForm(frm);
        }

        private void btn_BangLuong_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Bảng Lương");
            openChildForm(frm);
        }

        private void btn_VietBaoCao_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Viết Báo Cáo");
            openChildForm(frm);
        }

        private void btn_LichSuBaoCao_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Lịch Sử Báo Cáo");
            openChildForm(frm);
        }

        private void btn_DanhSachBaoCao_Click(object sender, EventArgs e)
        {
            frm_Empty frm = new frm_Empty("Danh Sách Báo Cáo");
            openChildForm(frm);
        }
        #endregion
    }
}
