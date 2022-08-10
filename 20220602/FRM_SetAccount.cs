using Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class frm_SetAccount : Form
    {
        #region Var Form
        //Biến kết nới csdl để gọi các hàm xử lý.
        NhanVien nhanVien = new NhanVien();
        TaiKhoan taiKhoan = new TaiKhoan();
        //Lưu thông tin tk đang sử dụng hệ thống.
        tAccount tk = new tAccount();
        //Lưu lại thông cần cập nhật lên csdl
        tAccount data = new tAccount();
        tStaff nv = new tStaff();
        #endregion

        #region Constructor
        //Khởi tạo mặc định dùng cho việc test form.
        public frm_SetAccount()
        {
            InitializeComponent();
            reNew();
            mess(0, "");
        }

        //Khởi tạo mặc định với thông tin đăng nhập từ người dùng.
        public frm_SetAccount(tAccount log)
        {
            InitializeComponent();
            tk = log;
            reNew();
            mess(0, "");
        }
        #endregion

        #region Support Func
        //Hàm làm mới các trường nhập liệu và button xử lý của hệ thống.
        private void reNew()
        {
            txt_Username.Text = "";
            txt_SearchStaff.Text = "";
            txt_SearchAccount.Text = "";
            txt_Staff.Text = "";
            cbo_Type.Text = "";
            chk_DaCoTK.Checked = false;

            taiKhoan.showDgv(dgv_Account);
            nhanVien.showDgv_Room(dgv_Staff);
        }

        //Hàm kiểm tra xem dữ liệu nhập vào có thỏa điều kiện chức năng.
        private bool checkInfo()
        {
            //Kiểm tra các trường dữ liệu đã có đủ chưa.
            if(txt_Username.Text == "" || cbo_Type.Text == "")
            {
                mess(1, "Vui lòng lựa chọn tài khoản.");
                return false;
            }
            if (txt_Staff.Text == "")
            {
                mess(1, "Vui lòng lựa chọn nhân viên.");
                return false;
            }
            //Kiểm tra xem tài khoản đã có ng sử dụng chưa.
            if (nhanVien.CheckInfo(data.Id_Account))
            {
                mess(1, "Tài khoản đã có người sử dụng.");
                return false;
            }

            return true;
        }

        //Hàm hiển thị thông báo.
        private void mess(int type, string mess)
        {
            //Làm mới lại thông báo.
            if (type == 0)
            {
                pic_Lightning.Hide();
                pic_Like.Hide();
                lbl_Status.Hide();
            }
            //Hiển thị thông báo lỗi.
            else if (type == 1)
            {
                lbl_Status.ForeColor = Color.Red;
                pic_Lightning.Show();
                pic_Like.Hide();
                lbl_Status.Text = mess;
                lbl_Status.Show();
            }
            //Hiển thị thông báo thành công.
            else if (type == 2)
            {
                lbl_Status.ForeColor = Color.Green;
                pic_Lightning.Hide();
                pic_Like.Show();
                lbl_Status.Text = mess;
                lbl_Status.Show();
            }
        }
        #endregion

        #region Button Func
        //Hàm làm mới lại các trường dữ liệu.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            reNew();
            mess(0, "");
        }

        //Hàm xử lý cập nhật thông tin người dùng.
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                //Lưu lại thông tin và gọi hàm xử lý cập nhật để cập nhật csdl.
                nhanVien.Update(nv.Id_Staff, data.Id_Account);

                //Hiển thị thông báo và làm mới giao diện.
                mess(2, "Cập nhật tài khoản cho nhân viên thành công.");
                reNew();
            }
        }

        //Hàm xử lý tìm kiếm.
        private void btn_SearchStaff_Click(object sender, EventArgs e)
        {
            nhanVien.Search(dgv_Staff, txt_SearchStaff.Text, 0);
        }

        //Hàm xử lý tìm kiếm.
        private void btn_SearchAccount_Click(object sender, EventArgs e)
        {
            taiKhoan.Search(dgv_Account, txt_SearchAccount.Text, 0);
        }

        //Hàm xử lý đóng giao diện hiện tại.
        private void pic_Exit_Click(object sender, EventArgs e)
        {
            //Hiển thị thông báo cho người dùng, nếu ng dùng ấn yes sẽ đóng giao diện hiện tại.
            var mes = MessageBox.Show("Bạn muốn đóng tính năng hiện tại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (mes == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Other
        //Hàm đẩy dữ liệu lên cá txt cbo nhập liệu khi ng dùng nhấp double click.
        private void dgv_Account_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Lưu thông tin phòng ban của dòng đã chọn trên dgv.     
                txt_Username.Text = dgv_Account.SelectedRows[0].Cells["Username"].Value.ToString();
                cbo_Type.Text = dgv_Account.SelectedRows[0].Cells["Type"].Value.ToString();

                data.Id_Account = Convert.ToInt32(dgv_Account.SelectedRows[0].Cells["Id_Account"].Value);
            }
            catch
            {

            }
        }

        //Hàm đẩy dữ liệu lên cá txt cbo nhập liệu khi ng dùng nhấp double click.
        private void dgv_Staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!chk_DaCoTK.Checked)
                {
                    //Lưu thông tin nhân viên của dòng đã chọn trên dgv.     
                    txt_Staff.Text = dgv_Staff.SelectedRows[0].Cells["Staff_Name"].Value.ToString();

                nv.Id_Staff = Convert.ToInt32(dgv_Staff.SelectedRows[0].Cells["Id_Staff"].Value);
                }
            }
            catch
            {

            }
        }

        //Checkbox để hiển thị các nhân viên đã có tk.
        private void chk_DaCoTK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_DaCoTK.Checked == true)
            {
                nhanVien.showDgv_Account(dgv_Staff);
            }
            else
            {
                nhanVien.showDgv_Room(dgv_Staff);
            }
        }
        #endregion
    }
}
