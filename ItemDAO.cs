using KhachSan.User_Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.Expando;

namespace KhachSan
{
    public class ItemDAO
    {
        DBConnection db = new DBConnection();
        bool expand = false;
        public Image LoadImageFromFile(string filePath)
        {
            try
            {
                return Image.FromFile(filePath);
            }
            catch (FileNotFoundException)
            {
                // Handle file not found exception (e.g., display error message)
                MessageBox.Show("Error: Image file not found!");
                return null;
            }
        }
        public void GeneratePicture(string imageLocation, List<PictureBox> pictureBoxes)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";


                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;
                        pictureBoxes[i].ImageLocation = imageLocation;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SendEmail(Room room, Search search, string emailto)
        {
            string from, to, pass, content, subject;
            subject = $"Xin chào";
            from = "abcn35183@gmail.com";
            to = emailto;
            pass = "dngmuirvtbmfpdgs";
            content = $"Bạn đã đặt phòng {room.name} của chúng tôi thành công.\n" +
                $"Check in: {search.startday}\nCheck out: {search.endday}\n" +
                $"Tổng chi phí bao gồm thuế của bạn là: {room.price} VND";

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
        public void ShowInfomation(FlowLayoutPanel dragdownCon, Timer timer1)
        {
            if (expand == false)
            {
                dragdownCon.Height += 20;
                if (dragdownCon.Height >= dragdownCon.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                dragdownCon.Height -= 20;
                if (dragdownCon.Height <= dragdownCon.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }
    }
}
