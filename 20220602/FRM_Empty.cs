using System;
using System.Windows.Forms;

namespace View
{
    public partial class frm_Empty : Form
    {
        #region Constructor
        //Hàm khởi tạo mặc định sử dụng để test form.
        public frm_Empty()
        {
            InitializeComponent();
        }

        //Khởi tạo mặc định với tên form truyền vào sử dụng cho các chức năng rỗng.
        public frm_Empty(string text)
        {
            InitializeComponent();
            lbl_FormName.Text = text;
        }
        #endregion

        #region Button Func
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
    }
}
