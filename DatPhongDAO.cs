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

namespace KhachSan
{
    public class DatPhongDAO
    {
        DBConnection db = new DBConnection();
        public void Add(DatPhong dt)
        {
            string thongbao = $"Đặt phòng {dt.roomname} khách sạn {dt.hotelname} thành công";
            string query = string.Format("INSERT INTO DATPHONG VALUES(N'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}','{11}')", dt.hoten, dt.email, dt.sdt, dt.hotelname, dt.roomname, dt.price, dt.ngaynhan, dt.ngaytra, dt.sodem,dt.guest, dt.giuong,dt.image);
            db.ThucThi(query, thongbao);
        }
        public void GeneratePanel(string query, Panel storage_panel)
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
                x += 132;
                panel.Controls.Add(uC_MyBook);
                storage_panel.Controls.Add(panel);
            }
        }
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
    }
}
