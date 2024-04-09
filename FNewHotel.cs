using KhachSan.Account;
using System;
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
    public partial class FNewHotel : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        HotelDAO htDAO = new HotelDAO();
        TaiKhoan tk;
        int id = 1;
        public FNewHotel()
        {
            InitializeComponent();
        }
        public FNewHotel(TaiKhoan TK)
        {
            InitializeComponent();
            this.tk = TK;
        }
        string imageLocation = "";
        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            htDAO.GeneratePicture(imageLocation, pictureBoxes);
        }
        private void btn_AddHotel_Click(object sender, EventArgs e)
        {
            if(tk.email == txt_Email.Text)
            {
                Hotel hotel = new Hotel(
                txt_Email.Text,
                id.ToString(),
                txt_HotelName.Text,
                txt_Address.Text,
                cmb_Type.Text,
                txt_DetailAddress.Text,
                cmb_Star.Text,
                0,
                0,
                cmb_Rate.Text,
                "",
                "",
                "",
                txt_Phone.Text,
                txt_Desc.Text,
                pictureBox1.ImageLocation,
                pictureBox2.ImageLocation,
                pictureBox3.ImageLocation,
                pictureBox4.ImageLocation,
                pictureBox5.ImageLocation,
                pictureBox6.ImageLocation,
                pictureBox7.ImageLocation);
                htDAO.Add(hotel);
                id++;

                FAddRoom far = new FAddRoom(hotel);
                far.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email bạn nhập không tồn tại! Vui lòng nhập đúng email bạn đã sử dụng để đăng kí tài khoản này", "Thông báo");
            }
            
        }
    }
}
