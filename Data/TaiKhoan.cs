using System.Linq;
using System.Windows.Forms;

namespace Controller
{
    public class TaiKhoan
    {
        //Connect database.
        DB_QuanLyNhanVienDataContext context = new DB_QuanLyNhanVienDataContext();

        #region Data List
        //Hiển thị danh sách cho chức năng quản lý tài khoản.
        public void showDgv(DataGridView dgv)
        {
            //Lấy ra ds tài khoản chưa bị xóa.
            var res = context.tAccounts.Where(a => a.Account_Status == true);

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        //Hiển thị danh sách tài khoản đã bị xóa.
        public void showDgv_Trash(DataGridView dgv)
        {
            //Lấy ra ds tài khoản bị xóa tạm.
            var res = context.tAccounts.Where(a => a.Account_Status == false);

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        ////Hiển thị danh sách tài khoản dưới dạng combobox.
        public void showCbo(ComboBox cbo)
        {
            //Lấy ra ds tài khoản chưa bị xóa.
            var res = context.tAccounts.Where(a => a.Account_Status == true);

            //Gán dữ liệu truy vấn được vào cbo với giá trị = id và hiển thị = tên tài khoản.
            cbo.DataSource = res;
            cbo.DisplayMember = "Username";
            cbo.ValueMember = "Id_Account";
        }

        //Hiển thị danh sách tài khoản với điều kiện search.
        public void Search(DataGridView dgv, string key, int type)
        {
            //Type = 1 là ds chưa bị xóa.
            if (type == 1)
            {
                //Lấy ra ds tài khoản chưa bị xóa.
                var res = context.tAccounts.Where(a => a.Account_Status == true && (a.Username.Contains(key) || a.Type.Contains(key)));

                //Gán dữ liệu truy vấn được vào dgv.
                dgv.DataSource = res;
            }
            //Type = 0 là ds bị xóa.
            else
            {
                //Lấy ra ds tài khoản bị xóa tạm.
                var res = context.tAccounts.Where(a => a.Account_Status == false && (a.Username.Contains(key) || a.Type.Contains(key)));

                //Gán dữ liệu truy vấn được vào dgv.
                dgv.DataSource = res;
            }
        }
        #endregion

        #region Data Processing
        //Hàm thêm mới tài khoản.
        public void Add(tAccount data)
        {
            try
            {
                //Gọi hàm thêm 1 tài khoản.
                context.tAccounts.InsertOnSubmit(data);

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Cập nhật pass của tài khoản.
        public void UpdatePass(tAccount data)
        {
            try
            {
                //tAccount account = context.tAccounts.Single(a => a.Id_Account == data.Id_Account);

                //Lấy ra giá của tài khoản dựa trên khóa chính và gán lại thông tin tài khoản đó băng giá trị được truyền vào hàm.
                tAccount account = context.tAccounts.Where(a => a.Id_Account == data.Id_Account).FirstOrDefault();
                account.Password = data.Password;

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Cập nhật thông tin của tài khoản.
        public void Update(tAccount data)
        {
            try
            {
                //tAccount account = context.tAccounts.Single(a => a.Id_Account == data.Id_Account);

                //Lấy ra giá của tài khoản dựa trên khóa chính và gán lại thông tin tài khoản đó băng giá trị được truyền vào hàm.
                tAccount account = context.tAccounts.Where(a => a.Id_Account == data.Id_Account).FirstOrDefault();
                account.Username = data.Username;
                account.Type = data.Type;

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Xóa tạm thông tin tài khoản.
        public void Delete(int id)
        {
            try
            {
                //tAccount account = context.tAccounts.Single(a => a.Id_Account == id);

                //Xóa tạm (Gán lại status = false để ẩn khỏi list chính)
                tAccount account = context.tAccounts.Where(a => a.Id_Account == id).FirstOrDefault();
                account.Account_Status = false;

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }
        #endregion

        #region Other
        //Hàm check xem dữ liệu nhập vào đã tồn tại trong csdl chưa.
        public bool CheckInfo(string data)
        {
            try
            {
                //Kiểm tra xem username đã tồn tại trong csdl hay chưa.
                var res = context.tAccounts.Single(a => a.Username == data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm xử lý đăng nhập và lưu lại thông tin tài khoản.
        public bool Login(string us, string ps, tAccount tk, tStaff nv)
        {
            try
            {
                var res = context.tAccounts.Single(a => a.Username == us && a.Password == ps && a.Account_Status == true);
                tk.Password = res.Password;
                tk.Username = res.Username;
                tk.Type = res.Type;
                tk.Id_Account = res.Id_Account;

                var res2 = context.tStaffs.Single(s => s.Id_Account == tk.Id_Account);

                nv.Id_Staff = res2.Id_Staff;
                nv.Staff_Name = res2.Staff_Name;

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
