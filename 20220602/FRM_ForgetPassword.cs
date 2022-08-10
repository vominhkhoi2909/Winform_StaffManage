using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frm_ForgetPassword : Form
    {
        public frm_ForgetPassword()
        {
            InitializeComponent();
        }

        protected void SendEmail(string _subject, string _from, string _to, string _body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(_from); //enter whatever email you are sending from here 
                mail.To.Add(_to); //Text box that the user enters their email address 
                mail.Subject = _subject; //enter whatever subject you would like 
                mail.Body = _body;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(_from, 587)) //enter the same email that the message is sending from along with port 587
                {
                    smtp.Credentials = new NetworkCredential(_from, "merimoki55"); //Enter email with password 
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }

            }
        }

        private void btn_SendOTP_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int otp = rd.Next(9999);
            SendEmail("OTP", "merimoki55@gmail.com", "minhkhoivo1999@gmail.com", otp.ToString());
            MessageBox.Show("Da send","thong bao");
        }
    }
}
