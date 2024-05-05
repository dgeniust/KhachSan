using KhachSan.User_Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KhachSan
{
    public class RoomDAO
    {
        DBConnection db = new DBConnection();
        ItemDAO itemDAO = new ItemDAO();    
        public void Add(Room room)
        {
            string thongbao = $"Thêm phòng {room.name} thành công";
            string query = string.Format("INSERT INTO PHONG VALUES(N'{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}','{6}','{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}','{14}','{15}','{16}','{17}')", room.email, room.hotelname, room.name, room.area, room.bed, room.guest_number, room.price, room.oldprice, room.tienich1, room.tienich2, room.tienich3,room.tienich4,room.dodung1, room.dodung2, room.p1, room.p2, room.p3, room.p4);
            db.ThucThi(query, query);
        }
        public void GeneratePicture(string imageLocation, List<PictureBox> pictureBoxes)
        {
            itemDAO.GeneratePicture(imageLocation, pictureBoxes);
        }
        public void GeneratePanel(string query, Panel storage_panel, Search sr)
        {
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(963, 340),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Room room = new Room(dr);

                x += 345;
                UC_DetailHotel dtht = new UC_DetailHotel(room, sr);
                panel.Controls.Add(dtht);
                dtht.Dock = DockStyle.Fill;
                storage_panel.Controls.Add(panel);
            }
        }
    }
}
