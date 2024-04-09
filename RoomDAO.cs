using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public class RoomDAO
    {
        DBConnection db = new DBConnection();
        public void Add(Room room)
        {
            string thongbao = $"Thêm phòng {room.name} thành công";
            string query = string.Format("INSERT INTO PHONG VALUES(N'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}','{11}','{12}','{13}','{14}')", room.email, room.hotelname, room.name, room.area, room.bed, room.guest_number, room.price, room.oldprice, room.tienich1, room.tienich2, room.tienich3, room.p1, room.p2, room.p3, room.p4);
            db.ThucThi(query, thongbao);
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
    }
}
