using System.Linq;
using System.Windows.Forms;

namespace Controller
{
    public class NhanVien
    {
        //Connet database.
        DB_QuanLyNhanVienDataContext context = new DB_QuanLyNhanVienDataContext();

        #region Data List
        //Hiển thị danh sách cho chức năng quản lý nhân viên.
        public void showDgv_Room(DataGridView dgv)
        {
            //Kết bản giữa nhân viên và phòng ban.
            var res = context.tStaffs.Where(s => s.Staff_Status == true).Join(context.tRooms, s => s.Id_Room, r => r.Id_Room, (st, ro) => new
            {
                Id_Staff = st.Id_Staff,
                Staff_Name = st.Staff_Name,
                Phone = st.Phone,
                Address = st.Address,
                Gender = st.Gender,
                Id_Room = st.Id_Room,
                Room_Name = ro.Room_Name,
            });

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        //Hiển thị danh sách cho chức năng quản lý account.
        public void showDgv_Account(DataGridView dgv)
        {
            //Kết bản giữa nhân viên và tài khoản.
            var res = context.tStaffs.Where(s => s.Staff_Status == true).Join(context.tAccounts, s => s.Id_Account, a => a.Id_Account, (st, ac) => new
            {
                Id_Staff = st.Id_Staff,
                Staff_Name = st.Staff_Name,
                Phone = st.Phone,
                Username = ac.Username,
            });

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        //Hiển thị danh sách nhân viên đã bị xóa.
        public void showDgv_Trash(DataGridView dgv)
        {
            //Kết bản giữa nhân viên và phòng ban.
            var res = context.tStaffs.Where(s => s.Staff_Status == false).Join(context.tRooms, s => s.Id_Room, r => r.Id_Room, (st, ro) => new
            {
                Id_Staff = st.Id_Staff,
                Staff_Name = st.Staff_Name,
                Phone = st.Phone,
                Address = st.Address,
                Gender = st.Gender,
                Id_Room = st.Id_Room,
                Room_Name = ro.Room_Name,
            });

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        //Hiển thị danh sách nhân viên dưới dạng combobox.
        public void showCbo(ComboBox cbo)
        {
            //Lấy sách nhân viên.
            var res = context.tStaffs.Where(s => s.Staff_Status == true);

            //Gán dữ liệu truy vấn được vào cbo với giá trị = id và hiển thị = tên nhân viên.
            cbo.DataSource = res;
            cbo.DisplayMember = "Staff_Name";
            cbo.ValueMember = "Id_Staff";
        }

        //Hiển thị danh sách nhân viên với điều kiện search.
        public void Search(DataGridView dgv, string key, int type)
        {
            //Type = 1 là ds chưa bị xóa.
            if(type == 1)
            {
                //Kết bản giữa nhân viên và phòng ban.
                var res = context.tStaffs.Where(s => (s.Staff_Name.Contains(key) || s.Phone.Contains(key)) && s.Staff_Status == true).Join(context.tRooms, s => s.Id_Room, r => r.Id_Room, (st, ro) => new
                {
                    Id_Staff = st.Id_Staff,
                    Staff_Name = st.Staff_Name,
                    Phone = st.Phone,
                    Address = st.Address,
                    Gender = st.Gender,
                    Id_Room = st.Id_Room,
                    Room_Name = ro.Room_Name,
                });

                //Gán dữ liệu truy vấn được vào dgv.
                dgv.DataSource = res;
            }
            //Type = 0 là danh sách bị xóa tạm.
            else
            {
                //Kết bản giữa nhân viên và phòng ban.
                var res = context.tStaffs.Where(s => (s.Staff_Name.Contains(key) || s.Phone.Contains(key)) && s.Staff_Status == false).Join(context.tRooms, s => s.Id_Room, r => r.Id_Room, (st, ro) => new
                {
                    Id_Staff = st.Id_Staff,
                    Staff_Name = st.Staff_Name,
                    Phone = st.Phone,
                    Address = st.Address,
                    Gender = st.Gender,
                    Id_Room = st.Id_Room,
                    Room_Name = ro.Room_Name,
                });

                //Gán dữ liệu truy vấn được vào dgv.
                dgv.DataSource = res;
            }
        }
        #endregion

        #region Data Processing
        //Hàm thêm mới nhân viên.
        public void Add(tStaff data)
        {
            try
            {
                //Gọi hàm thêm 1 nhân viên.
                context.tStaffs.InsertOnSubmit(data);

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Cập nhật thông tin của nhân viên.
        public void Update(tStaff data)
        {
            try
            {
                //tStaff staff = context.tStaffs.Single(s => s.Id_Staff == data.Id_Staff);

                //Lấy ra giá của nhân viên dựa trên khóa chính và gán lại thông tin nhân viên đó băng giá trị được truyền vào hàm.
                tStaff staff = context.tStaffs.Where(s => s.Id_Staff == data.Id_Staff).FirstOrDefault();
                staff.Staff_Name = data.Staff_Name;
                staff.Phone = data.Phone;
                staff.Address = data.Address;
                staff.Gender = data.Gender;
                staff.Id_Room = data.Id_Room;

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Cập nhật thông tin tài khoảncủa nhân viên.
        public void Update(int idStaff, int idAccount)
        {
            try
            {
                //tStaff staff = context.tStaffs.Single(s => s.Id_Staff == data.Id_Staff);

                //Lấy ra giá của nhân viên dựa trên khóa chính và gán lại thông tin nhân viên đó băng giá trị được truyền vào hàm.
                tStaff staff = context.tStaffs.Where(s => s.Id_Staff == idStaff).FirstOrDefault();
                staff.Id_Account = idAccount;

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Xóa tạm thông tin nhân viên.
        public void Delete(int id)
        {
            try
            {
                //Xóa tạm (Gán lại status = false để ẩn khỏi list chính)
                tStaff staff = context.tStaffs.Where(s => s.Id_Staff == id).FirstOrDefault();
                staff.Staff_Status = false;

                //Dùng khi xóa vĩnh viễn.
                //tStaff staff = context.tStaffs.Single(s => s.Id_Staff == id);
                //context.tStaffs.DeleteOnSubmit(staff);

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
                //Kiểm tra xem sdt đã tồn tại trong csdl hay chưa.
                var res = context.tStaffs.Single(a => a.Phone == data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm check xem dữ liệu nhập vào đã tồn tại trong csdl chưa.
        public bool CheckInfo(int id)
        {
            try
            {
                //Kiểm tra xem tài khoản đã có ng sử dụng chưa.
                var res = context.tStaffs.Single(a => a.Id_Account == id);
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
