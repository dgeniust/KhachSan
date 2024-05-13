using Guna.UI2.WinForms;
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
    public partial class FInfoOwner : Form
    {
        HotelDAO htDAO = new HotelDAO();
        TaiKhoan tk;
        public Guna2Button BTN_CONTINUE => btn_Countinue;

        string imageLocation = "";

        public FInfoOwner(TaiKhoan TAIKHOAN)
        {
            InitializeComponent();
            this.tk = TAIKHOAN;
            this.txt_Email.Text = TAIKHOAN.email;
            this.txt_Name.Text = TAIKHOAN.hoten;
            this.txt_Address.Text = TAIKHOAN.diachi;
            this.txt_CCCD.Text = TAIKHOAN.cccd;
            this.txt_Phone.Text = TAIKHOAN.sdt;
            this.cmb_Gender.Text = TAIKHOAN.gioitinh;

        }

        private void FInfoOwner_Load(object sender, EventArgs e)
        {

        }

        private void btn_Countinue_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            TaiKhoan taikhoan = new TaiKhoan("", "", txt_Email.Text, txt_Name.Text, Convert.ToString(datetime_NgaySinh.Value.Date), cmb_Gender.Text, txt_Address.Text, txt_Phone.Text, txt_CCCD.Text, pictureBox_OwnerImage.ImageLocation, pictureBox_Front_CCCD.ImageLocation, pictureBox_Back_CCCD.ImageLocation);
            modify.UpdateAccount(taikhoan);
            FNewHotel fnh = new FNewHotel(taikhoan);
            this.Hide();
            fnh.Show();
        }
        public void LoadImageFromFile(string filepath)
        {
            htDAO.LoadImageFromFile(filepath);
        }

        private void btn_Upload_OwnerImage_Click(object sender, EventArgs e)
        {
            LoadImageFromFile(pictureBox_OwnerImage.ImageLocation);
        }

        private void btn_Upload_FrontCCCD_Click(object sender, EventArgs e)
        {
            LoadImageFromFile(pictureBox_Front_CCCD.ImageLocation);
        }

        private void btn_Upload_BackCCCD_Click(object sender, EventArgs e)
        {
            LoadImageFromFile(pictureBox_Back_CCCD.ImageLocation);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
