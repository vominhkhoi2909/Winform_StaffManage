using System.Linq;
using System.Windows.Forms;

namespace Controller
{
    public class PhongBan
    {
        //Connet database.
        DB_QuanLyNhanVienDataContext context = new DB_QuanLyNhanVienDataContext();

        #region Data List
        //Hiển thị danh sách cho chức năng quản lý phòng ban.
        public void showDgv(DataGridView dgv)
        {
            //Lấy ra ds phòng ban chưa bị xóa.
            var res = context.tRooms.Where(r => r.Room_Status == true);

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        //Hiển thị danh sách phòng ban đã bị xóa.
        public void showDgv_Trash(DataGridView dgv)
        {
            //Lấy ra ds phòng ban bị xóa tạm.
            var res = context.tRooms.Where(r => r.Room_Status == false);

            //Gán dữ liệu truy vấn được vào dgv.
            dgv.DataSource = res;
        }

        //Hiển thị danh sách phòng ban dưới dạng combobox.
        public void showCbo(ComboBox cbo)
        {
            //Lấy ra ds phòng ban chưa bị xóa.
            var res = context.tRooms.Where(r => r.Room_Status == true);

            //Gán dữ liệu truy vấn được vào cbo với giá trị = id và hiển thị = tên phòng ban.
            cbo.DataSource = res;
            cbo.DisplayMember = "Room_Name";
            cbo.ValueMember = "Id_Room";
        }

        //Hiển thị danh sách phòng ban với điều kiện search.
        public void Search(DataGridView dgv, string key, int type)
        {
            //Type = 1 là ds chưa bị xóa.
            if(type == 1)
            {
                //Lấy ra ds phòng ban chưa bị xóa.
                var res = context.tRooms.Where(r => r.Room_Status == true && r.Room_Name.Contains(key));

                //Gán dữ liệu truy vấn được vào dgv.
                dgv.DataSource = res;
            }
            //Type = 0 là ds bị xóa.
            else
            {
                //Lấy ra ds phòng ban bị xóa tạm.
                var res = context.tRooms.Where(r => r.Room_Status == false && r.Room_Name.Contains(key));

                //Gán dữ liệu truy vấn được vào dgv.
                dgv.DataSource = res;
            }
        }
        #endregion

        #region Data Processing
        //Hàm thêm mới phòng ban.
        public void Add(tRoom data)
        {
            try
            {
                //Gọi hàm thêm 1 phòng ban.
                context.tRooms.InsertOnSubmit(data);

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Cập nhật thông tin của phòng ban.
        public void Update(tRoom data)
        {
            try
            {
                //tRoom room = context.tRooms.Single(r => r.Id_Room == data.Id_Room);

                //Lấy ra giá của phòng ban dựa trên khóa chính và gán lại thông tin phòng ban đó băng giá trị được truyền vào hàm.
                tRoom room = context.tRooms.Where(r => r.Id_Room == data.Id_Room).FirstOrDefault();
                room.Room_Name = data.Room_Name;

                //Cập nhật lại db dựa trên dữ liệu đã thay đổi.
                context.SubmitChanges();
            }
            catch
            {

            }
        }

        //Xóa tạm thông tin phòng ban.
        public void Delete(int id)
        {
            try
            {
                //tRoom room = context.tRooms.Single(r => r.Id_Room == id);

                //Xóa tạm (Gán lại status = false để ẩn khỏi list chính)
                tRoom room = context.tRooms.Where(r => r.Id_Room == id).FirstOrDefault();
                room.Room_Status = false;

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
                //Kiểm tra xem tên phòng ban đã tồn tại trong csdl hay chưa.
                var res = context.tRooms.Single(r => r.Room_Name == data);
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
