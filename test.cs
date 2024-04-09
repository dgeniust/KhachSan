using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace KhachSan
{
    public partial class test : Form
    {
        DBConnection db = new DBConnection();
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to, pass, content, subject;
            subject = " Hello World! ";
            from = "abcn35183@gmail.com";
            to = txt_Receive.Text.Trim();
            pass = "dngmuirvtbmfpdgs";
            content = txt_Content.Text.Trim();
            try
            {
                using (MailMessage mail = new MailMessage(from, to, subject, content))
                {
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                    {
                        smtp.Port = 587;
                        /*smtp.UseDefaultCredentials = false;*/
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        smtp.Send(mail);
                        MessageBox.Show("Email gửi thành công");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }


        }
    }
}
