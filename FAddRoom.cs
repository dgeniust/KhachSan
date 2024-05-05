using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class FAddRoom : Form
    {
        Hotel hotel;
        RoomDAO roomDAO = new RoomDAO();
        Search sr;
        private List<PictureBox> pictureBoxes = new List<PictureBox>(); 
        string imageLocation = "";
        public FAddRoom()
        {
            InitializeComponent();

        }
        public FAddRoom(Hotel HOTEL)
        {
            InitializeComponent();
            this.hotel = HOTEL;
            this.txt_HotelName.Text = HOTEL.name;
        }
        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room(hotel.email,hotel.name,txt_RoomName.Text, txt_DienTich.Text, txt_Bed.Text, txt_Guest.Text,0, Convert.ToDouble(txt_Price.Text),txt_TienIch1.Text,txt_TienIch2.Text, txt_TienIch3.Text,txt_TienIch4.Text,txt_DoDung1.Text, txt_DoDung2.Text, pictureBox1.ImageLocation, pictureBox4.ImageLocation, pictureBox2.ImageLocation, pictureBox3.ImageLocation);
            roomDAO.Add(room);
            string query = "SELECT * FROM PHONG WHERE TenKhachSan= '" + hotel.name + "'";
            roomDAO.GeneratePanel(query, Panel_Hotel, sr);
            this.Refresh();
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            roomDAO.GeneratePicture(imageLocation, pictureBoxes);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FAddRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
