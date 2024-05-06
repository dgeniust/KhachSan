using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using KhachSan.User_Control;
using System.Net.Mail;
using System.Net;

namespace KhachSan
{
    public class DatPhongDAO
    {
        DBConnection db = new DBConnection();
        ItemDAO itemDAO = new ItemDAO();    
        public void Add(DatPhong dt)
        {
            string thongbao = $"Đặt phòng {dt.roomname} khách sạn {dt.hotelname} thành công";
            string query = string.Format("INSERT INTO DATPHONG VALUES(N'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}','{11}')", dt.hoten, dt.email, dt.sdt, dt.hotelname, dt.roomname, dt.price, dt.ngaynhan, dt.ngaytra, dt.sodem,dt.guest, dt.giuong,dt.image);
            db.ThucThi(query, thongbao);
        }
        public void Delete(DatPhong dt)
        {
            string thongbao = $"Hủy phòng {dt.roomname} khách sạn {dt.hotelname} thành công";
            string query = string.Format("DELETE FROM DATPHONG WHERE TenKhachSan = '{0}' AND Email='{1}'", dt.hotelname,dt.email);
            db.ThucThi(query, thongbao);
        }
        public void GenerateBookPanel(string query, Panel storage_panel)
        {
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(775, 130),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };
                DatPhong dp = new DatPhong(dr);
                UC_MyBook uC_MyBook = new UC_MyBook(dp);
                uC_MyBook.BTN_CANCLE.Click += Cancel;
                x += 132;
                panel.Controls.Add(uC_MyBook);
                storage_panel.Controls.Add(panel);
            }
        }
        public void Cancel(object sender, EventArgs e)
        {
        }
        public Image LoadImageFromFile(string filePath)
        {
            return itemDAO.LoadImageFromFile(filePath);
        }
        public void SendEmail(Room room, Search search, string emailto)
        {
            itemDAO.SendEmail(room, search, emailto);   
        }
    }
}
