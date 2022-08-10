using Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class frm_Room : Form
    {
        #region Var Form
        PhongBan phongBan = new PhongBan(); //Biến liên kết tới csdl để gọi các hàm xử lý.
        tAccount tk = new tAccount(); //Biến lưu thông tin tk đang sử dụng hiện tại.
        tRoom pb = new tRoom(); //Biến lưu thông tin phòng ban.
        bool checkTrash = false;
        #endregion

        #region Constructor
        //Hàm khởi tạo mặc định sử dụng cho test form.
        public frm_Room()
        {
            InitializeComponent();
            reNew();
            mess(0, "");
        }

        //Hàm khởi tạo mặc định
        public frm_Room(tAccount log)
        {
            InitializeComponent();
            tk = log; //Lưu lại thông tin tk hiện tại của hệ thống.
            reNew();
            mess(0, "");
        }
        #endregion

        #region Support Func
        //Hàm làm mới các trường nhập liệu và button xử lý của hệ thống.
        private void reNew()
        {
            txt_Room.Text = "";
            txt_Search.Text = "";

            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            checkTrash = false;

            phongBan.showDgv(dgv_Room);
        }

        //Hàm kiểm tra xem dữ liệu nhập vào có thỏa điều kiện chức năng.
        private bool checkInfo()
        {
            //Kiểm tra textbox tên có bị rỗng.
            if(txt_Room.Text == "")
            {
                mess(1, "Vui lòng nhập tên phòng ban.");
                return false;
            }
            //Kiểm tra xem tên phòng có tồn tại chưa.
            if (phongBan.CheckInfo(txt_Room.Text) && btn_Add.Enabled == true)
            {
                mess(1, "Tên phòng ban đã tồn tại.");
                return false;
            }

            return true;
        }

        //Hàm hiển thị thông báo.
        private void mess(int type, string mess)
        {
            //Làm mới lại thông báo.
            if(type == 0)
            {
                pic_Lightning.Hide();
                pic_Like.Hide();
                lbl_Status.Hide();
            }
            //Hiển thị thông báo lỗi.
            else if(type == 1)
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
        //Hàm xử lý làm mới lại giao diện form.
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            reNew();
            mess(0, "");
        }

        //Hàm xử lý thêm mới phòng.
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản có đủ quyền hạn để chỉnh sửa dữ liệu của hệ thống.
            if (checkInfo() && (tk.Type == "Master" || tk.Type == "Admin"))
            {
                //Lưu lại thông tin và gọi hàm xử lý thêm mới để cập nhật csdl.
                pb.Room_Name = txt_Room.Text;
                pb.Room_Status = true;
                phongBan.Add(pb);

                //Hiển thị thông báo và làm mới giao diện.
                mess(2, "Thêm mới phòng ban thành công.");
                reNew();
            }
            else if (tk.Type == "Staff" || tk.Type == "Guest")
            {
                MessageBox.Show("Bạn không được cấp quyền để thực hiện chức năng này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Hàm xử lý cập nhật thông tin phòng.
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản có đủ quyền hạn để chỉnh sửa dữ liệu của hệ thống.
            if (checkInfo() && (tk.Type == "Master" || tk.Type == "Admin"))
            {
                //Lưu lại thông tin và gọi hàm xử lý cập nhật để cập nhật csdl.
                pb.Room_Name = txt_Room.Text;
                phongBan.Update(pb);

                //Hiển thị thông báo và làm mới giao diện.
                mess(2, "Cập nhật thông tin phòng ban thành công.");
                reNew();
            }            
            else if(tk.Type == "Staff" || tk.Type == "Guest")
            {
                MessageBox.Show("Bạn không được cấp quyền để thực hiện chức năng này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Hàm xử lý xóa thông tin phòng.
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản có đủ quyền hạn để chỉnh sửa dữ liệu của hệ thống.
            if (tk.Type == "Master" || tk.Type == "Admin")
            {
                //Hiển thị thông báo để người dùng xác nhận.
                var mes = MessageBox.Show("Bạn xác nhận muốn xóa phòng ban hiện tại?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mes == DialogResult.Yes)
                {
                    //Gọi hàm xử lý xóa và cập nhật lại trên csdl.
                    phongBan.Delete(pb.Id_Room);

                    //Hiển thị thông báo và làm mới giao diện.
                    mess(2, "Xóa phòng ban thành công.");
                    reNew();
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
                phongBan.Search(dgv_Room, txt_Search.Text, 0);
            }
            else
            {
                phongBan.Search(dgv_Room, txt_Search.Text, 1);
            }
        }

        //Hàm hiển thị danh sách dữ liệu đã bị xóa.
        private void pic_Trash_Click(object sender, EventArgs e)
        {
            phongBan.showDgv_Trash(dgv_Room);

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

        #region Other Func
        //Hàm đẩy dữ liệu lên cá txt cbo nhập liệu khi ng dùng nhấp double click.
        private void dgv_Room_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Nếu không phải ds xóa thì có thể thực thi.
                if(!checkTrash)
                {
                    //Lưu thông tin phòng ban của dòng đã chọn trên dgv.     
                    txt_Room.Text = dgv_Room.SelectedRows[0].Cells["Room_Name"].Value.ToString();

                    pb.Id_Room = Convert.ToInt32(dgv_Room.SelectedRows[0].Cells["Id_Room"].Value);

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
        #endregion
    }
}
