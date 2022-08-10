using System;
using System.Windows.Forms;

namespace View
{
    public partial class frm_LoadingScreen : Form
    {
        //Hàm khởi tạo mặc định form.
        public frm_LoadingScreen()
        {
            InitializeComponent();
        }

        //Hàm xử lý mỗi giai đoạn của timer.
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Tăng giá trị progress bar theo thời gian timer và hiển thị giá trị.
            pgb_Loading.Value = pgb_Loading.Value + 1;
            lbl_Value.Text = pgb_Loading.Value.ToString() + '%';

            //timer || progress bar đạt full thì dừng timer và mở form đăng nhập.
            if (timer1.Interval >= 100 || pgb_Loading.Value >= 100)
            {
                timer1.Enabled = false;
                frm_Login frm = new frm_Login();
                this.Hide();
                frm.Show();
            }
        }
    }
}
