using System;
using System.Drawing;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class frm_Staff : Form
    {
        #region Var Form
        //Biến kết nới csdl để gọi các hàm xử lý.
        NhanVien nhanVien = new NhanVien(); 
        PhongBan phongBan = new PhongBan(); 
        tStaff nv = new tStaff(); //Lưu lại thông tin nv.
        tAccount tk = new tAccount(); //Lưu thông tin tk đang sử dụng hệ thống.
        bool checkTrash = false; //
        #endregion

        #region Constructor
        //Khởi tạo mặc định dùng cho việc test form.
        public frm_Staff()
        {
            InitializeComponent();
            renew();
            cbo_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            mess(0, "");
        }

        //Khởi tạo mặc định với thông tin đăng nhập từ người dùng.
        public frm_Staff(tAccount log)
        {
            InitializeComponent();
            tk = log; //Lưu lại thông tin tk hiện tại của hệ thống.
            renew();
            cbo_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            mess(0, "");
        }
        #endregion

        #region Support Func
        //Hàm làm mới các trường nhập liệu và button xử lý của hệ thống.
        private void renew()
        {
            txt_Address.Text = "";
            txt_Name.Text = "";
            txt_Phone.Text = "";
            txt_Search.Text = "";
            cbo_Gender.Text = "";
            nhanVien.showDgv_Room(dgv_Staff);
            phongBan.showCbo(cbo_Room);

            btn_Add.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            checkTrash = false;
        }

        //Hàm kiểm tra xem dữ liệu nhập vào có thỏa điều kiện chức năng.
        private bool checkInfo()
        {
            //Kiểm tra quyền hạn của tk.
            if(tk.Type == "Guest" || tk.Type == "Staff")
            {
                MessageBox.Show("Bạn không được cấp quyền để thực hiện chức năng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Kiểm tra các trường dữ liệu bắt buộc có rỗng không.
            if(txt_Name.Text == "")
            {
                mess(1, "Vui lòng nhập tên nhân viên.");
                return false;
            }
            if (txt_Phone.Text == "")
            {
                mess(1, "Vui lòng nhập số điện thoại.");
                return false;
            }
            if (cbo_Gender.Text == "")
            {
                mess(1, "Vui lòng chọn giới tính.");
                return false;
            }
            //Kiểm tra độ dài của sđt.
            if (txt_Phone.TextLength != 10)
            {
                mess(1, "Số điện thoại không hợp lệ.");
                return false;
            }
            if(nhanVien.CheckInfo(txt_Phone.Text) && btn_Add.Enabled == true)
            {
                mess(1, "Số điện thoại đã tồn tại.");
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
            renew();
            mess(0, "");
        }

        //Hàm xử lý thêm mới người dùng.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                //Lưu lại thông tin và gọi hàm xử lý thêm mới để cập nhật csdl.
                nv.Staff_Name = txt_Name.Text;
                nv.Phone = txt_Phone.Text;
                nv.Gender = cbo_Gender.Text;
                nv.Address = txt_Address.Text;
                nv.Id_Room = Convert.ToInt32(cbo_Room.SelectedValue);
                nv.Staff_Status = true;
                nhanVien.Add(nv);

                //Hiển thị thông báo và làm mới giao diện.
                mess(2, "Thêm mới nhân viên thành công.");
                renew();
            }
        }

        //Hàm xử lý cập nhật thông tin người dùng.
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                //Lưu lại thông tin và gọi hàm xử lý cập nhật để cập nhật csdl.
                nv.Staff_Name = txt_Name.Text;
                nv.Phone = txt_Phone.Text;
                nv.Gender = cbo_Gender.Text;
                nv.Address = txt_Address.Text;
                nv.Id_Room = Convert.ToInt32(cbo_Room.SelectedValue);
                nhanVien.Update(nv);

                //Hiển thị thông báo và làm mới giao diện.
                mess(2, "Cập nhật nhân viên thành công.");
                renew();
            }
        }

        //Hàm xử lý xóa người dùng.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản có đủ quyền hạn để chỉnh sửa dữ liệu của hệ thống.
            if (tk.Type == "Master" || tk.Type == "Admin")
            {
                //Hiển thị thông báo để người dùng xác nhận.
                var mes = MessageBox.Show("Bạn xác nhận muốn xóa thông tin nhân viên hiện tại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mes == DialogResult.Yes)
                {
                    //Gọi hàm xử lý xóa và cập nhật lại trên csdl.
                    nhanVien.Delete(nv.Id_Staff);

                    //Hiển thị thông báo và làm mới giao diện.
                    mess(2, "Xóa thông tin nhân viên thành công.");
                    renew();
                }
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền để thực hiện chức năng này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Hàm xử lý tìm kiếm.
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Dựa trên dgv hiện tại mà gọi hàm tìm kiếm. 0 là ds đã bị xóa, 1 là ds đang sử dụng.
            if (checkTrash)
            {
                nhanVien.Search(dgv_Staff, txt_Search.Text, 0);
            }
            else
            {
                nhanVien.Search(dgv_Staff, txt_Search.Text, 1);
            }
        }

        //Hiển thị danh sách dữ liệu đã bị xóa.
        private void pic_Trash_Click(object sender, EventArgs e)
        {
            nhanVien.showDgv_Trash(dgv_Staff);

            //Khóa tất cả button.
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;

            //Cập nhật trạng thái hiện tại của form là ds xóa.
            checkTrash = true;
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
        private void dgv_Staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nếu không phải ds xóa thì có thể thực thi.
                if (!checkTrash)
                {
                    //Lưu thông tin nhân viên của dòng đã chọn trên dgv.     
                    txt_Name.Text = dgv_Staff.SelectedRows[0].Cells["Staff_Name"].Value.ToString();
                    txt_Phone.Text = dgv_Staff.SelectedRows[0].Cells["Phone"].Value.ToString();
                    txt_Address.Text = dgv_Staff.SelectedRows[0].Cells["Address"].Value.ToString();
                    cbo_Gender.Text = dgv_Staff.SelectedRows[0].Cells["Gender"].Value.ToString();
                    cbo_Room.SelectedValue = Convert.ToInt32(dgv_Staff.SelectedRows[0].Cells["Id_Room"].Value);

                    nv.Id_Staff = Convert.ToInt32(dgv_Staff.SelectedRows[0].Cells["Id_Staff"].Value);
                    nv.Id_Room = Convert.ToInt32(dgv_Staff.SelectedRows[0].Cells["Id_Room"].Value);

                    //Cập nhật trạng thái button/textbox.
                    btn_Update.Enabled = true;
                    btn_Delete.Enabled = true;
                    btn_Add.Enabled = false;
                }
            }
            catch
            {

            }
        }

        //Hàm kiểm tra nhập liệu
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho phép nhập số đối vs ô sdt.
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
