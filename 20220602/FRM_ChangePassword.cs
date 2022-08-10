using Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class frm_ChangePassword : Form
    {
        #region Var Form
        TaiKhoan taiKhoan = new TaiKhoan(); //Biến kết nối với các hàm xử lý csdl.
        tAccount tk = new tAccount(); //Biến lưu tài khoản hiện.
        #endregion

        #region Constructor
        //Hàm khởi tạo mặc định dùng khi test form.
        public frm_ChangePassword()
        {
            InitializeComponent();
            reNew();
        }

        //Hàm khởi tạo mặc định kèm thông tin login của người dùng.
        public frm_ChangePassword(tAccount log)
        {
            InitializeComponent();
            tk = log; //Lưu lại thông tin tk truyền vào.
            reNew();
            mess(0, "");
        }
        #endregion

        #region Support Func
        //Hàm làm mới lại các trường nhập liệu.
        void reNew()
        {
            txt_NewPassword1.Text = "";
            txt_NewPassword2.Text = "";
            txt_OldPassword.Text = "";
            lbl_Status.Text = "";
            pic_Fail.Hide();
            pic_Like.Hide();

            pic_Show.Hide();
            pic_Hide.Show();
            txt_OldPassword.UseSystemPasswordChar = true;
            pic_ShowNew1.Hide();
            pic_HideNew1.Show();
            txt_NewPassword1.UseSystemPasswordChar = true;
            pic_ShowNew2.Hide();
            pic_HideNew2.Show();
            txt_NewPassword2.UseSystemPasswordChar = true;
        }

        //Hàm kiểm tra dữ liệu nhập vào có thỏa điều kiện chức năng.
        private bool checkInfo()
        {
            //Kiểm tra xem nhập đủ chưa.
            if (txt_OldPassword.Text == "" || txt_NewPassword1.Text == "" || txt_NewPassword2.Text == "")
            {
                mess(1, "Vui lòng nhập đủ các trường thông tin.");
                return false;
            }
            //Kiểm tra 2 pass mới có trùng không.
            if (txt_NewPassword1.Text != txt_NewPassword2.Text)
            {
                mess(1, "Mật khẩu mới 1 và 2 không trùng khớp.");
                return false;
            }
            //Kiểm tra pass mới củ có trung nhau không.
            if (txt_OldPassword.Text == txt_NewPassword1.Text)
            {
                mess(1, "Mật khẩu mới không được trùng với mật khẩu hiện tại.");
                return false;
            }

            return true;
        }

        //Hàm hiển thị thông báo.
        private void mess(int type, string mess)
        {
            //Làm mới thông báo.
            if (type == 0)
            {
                pic_Fail.Hide();
                pic_Like.Hide();
                lbl_Status.Hide();
            }
            //Thông báo lỗi.
            else if (type == 1)
            {
                lbl_Status.ForeColor = Color.Red;
                pic_Fail.Show();
                pic_Like.Hide();
                lbl_Status.Text = mess;
                lbl_Status.Show();
            }
            //Thông báo thành công.
            else if (type == 2)
            {
                lbl_Status.ForeColor = Color.Green;
                pic_Fail.Hide();
                pic_Like.Show();
                lbl_Status.Text = mess;
                lbl_Status.Show();
            }
        }
        #endregion

        #region Button Func
        //Hàm gọi hàm renew để làm mới giao diện.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            reNew();
            mess(0, "");
        }

        //Hàm xử lý nhận dữ liệu thực hiện truy vấn update.
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                //Gán lại thông tin và gọi hàm để cập nhật để update lên csdl.
                tk.Password = txt_NewPassword1.Text;
                taiKhoan.UpdatePass(tk);

                mess(2, "Cập nhật mật khẩu thành công.");
            }
        }

        //Hàm xử lý tắt giao diện hiện tại.
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

        #region Hide / Show Password
        private void pic_Show_Click(object sender, EventArgs e)
        {
            pic_Show.Hide();
            pic_Hide.Show();
            txt_OldPassword.UseSystemPasswordChar = true;
        }

        private void pic_Hide_Click(object sender, EventArgs e)
        {
            pic_Show.Show();
            pic_Hide.Hide();
            txt_OldPassword.UseSystemPasswordChar = false;
            txt_OldPassword.PasswordChar = '\0';
        }

        private void pic_HideNew2_Click(object sender, EventArgs e)
        {
            pic_ShowNew2.Show();
            pic_HideNew2.Hide();
            txt_NewPassword2.UseSystemPasswordChar = false;
            txt_NewPassword2.PasswordChar = '\0';
        }

        private void pic_ShowNew1_Click(object sender, EventArgs e)
        {
            pic_ShowNew1.Hide();
            pic_HideNew1.Show();
            txt_NewPassword1.UseSystemPasswordChar = true;
        }

        private void pic_ShowNew2_Click(object sender, EventArgs e)
        {
            pic_ShowNew2.Hide();
            pic_HideNew2.Show();
            txt_NewPassword2.UseSystemPasswordChar = true;
        }

        private void pic_HideNew1_Click(object sender, EventArgs e)
        {
            pic_ShowNew1.Show();
            pic_HideNew1.Hide();
            txt_NewPassword1.UseSystemPasswordChar = false;
            txt_NewPassword1.PasswordChar = '\0';
        }
        #endregion
    }
}
