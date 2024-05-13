using Guna.UI2.WinForms;
using KhachSan.Account;
using KhachSan.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class FNewHotel : Form
    {
        DBConnection db = new DBConnection();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        HotelDAO htDAO = new HotelDAO();
        string imageLocation = "";
        TaiKhoan tk;
        int id = 10;
        public Guna2TextBox TXT_HotelName => txt_HotelName;
        public FNewHotel(TaiKhoan TK)
        {
            InitializeComponent();
            string query = "Select * from khachsan where email ='" + TK.email + "'";
            this.tk = TK;
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                Hotel hotel = new Hotel(dr);
                this.txt_Email.Text = dr[0].ToString();
                this.txt_HotelName.Text = dr[2].ToString();
                this.txt_Address.Text = dr[3].ToString();
                this.cmb_Type.Text = dr[4].ToString();
                this.txt_DetailAddress.Text = dr[5].ToString();
                this.cmb_Star.Text = dr[6].ToString();
                this.txt_Price.Text = dr[7].ToString();
                this.cmb_Rate.Text = dr[9].ToString();
                this.txt_TienIch1.Text = dr[10].ToString();
                this.txt_TienIch2.Text = dr[11].ToString();
                this.txt_TienIch3.Text = dr[12].ToString();
                this.txt_Phone.Text = dr[13].ToString();
                this.txt_Desc.Text = dr[14].ToString();
            }

        }
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
                Convert.ToInt32(txt_Price.Text),
                0,
                cmb_Rate.Text,
                txt_TienIch1.Text,
                txt_TienIch2.Text,
                txt_TienIch3.Text,
                txt_Phone.Text,
                txt_Desc.Text,
                pictureBox1.ImageLocation,
                pictureBox2.ImageLocation,
                pictureBox3.ImageLocation,
                pictureBox4.ImageLocation,
                pictureBox5.ImageLocation,
                pictureBox6.ImageLocation,
                pictureBox7.ImageLocation,
                ""
                );
                htDAO.Add(hotel);
                id++;

                FAddRoom far = new FAddRoom(hotel, tk.taikhoan);
                far.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email bạn nhập không tồn tại! Vui lòng nhập đúng email bạn đã sử dụng để đăng kí tài khoản này", "Thông báo");
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
