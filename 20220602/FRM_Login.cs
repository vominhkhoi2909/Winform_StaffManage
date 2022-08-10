using Controller;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class frm_Login : Form
    {
        #region Var Func
        TaiKhoan taiKhoan = new TaiKhoan(); //Biến gọi hàm xử lý dữ liệu trên csdl.
        tAccount tk = new tAccount(); //Biến lưu thông tin login.
        tStaff nv = new tStaff();  //Biến lưu thông tin nv giữ account.
        #endregion

        #region Constructor
        //Hàm khởi tạo mặc định.
        public frm_Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Button Func
        //Hàm thực hiện xác nhận thông tin đăng nhập vào hệ thống.
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin đăng nhập người dùng nhập vào có khớp / csdl, nếu khớp sẽ lưu lại thông tin tk, nv.
            if (taiKhoan.Login(txt_Username.Text, txt_Password.Text, tk, nv))
            {
                frm_QuanLyNhanVien frm = new frm_QuanLyNhanVien(tk, nv);
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thật bại vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm tắt app.
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Xuất thông báo đến người dùng, nếu ng dùng ấn yes sẽ đóng app.
            var mes = MessageBox.Show("Bạn muốn đóng ứng dụng hiện tại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(mes == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
