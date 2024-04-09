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
            //this.datetime_NgaySinh.Value = Convert.ToDateTime(TAIKHOAN.ngaysinh);
            this.cmb_Gender.Text = TAIKHOAN.gioitinh;
            this.pictureBox_OwnerImage.Image = htDAO.LoadImageFromFile(TAIKHOAN.ownerimage);
            this.pictureBox_Front_CCCD.Image = htDAO.LoadImageFromFile(TAIKHOAN.frontcccd);
            this.pictureBox_Back_CCCD.Image = htDAO.LoadImageFromFile(TAIKHOAN.backcccd);

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
        public void TakeImage(PictureBox pb)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pb.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Upload_OwnerImage_Click(object sender, EventArgs e)
        {
            TakeImage(pictureBox_OwnerImage);
        }

        private void btn_Upload_FrontCCCD_Click(object sender, EventArgs e)
        {
            TakeImage(pictureBox_Front_CCCD);
        }

        private void btn_Upload_BackCCCD_Click(object sender, EventArgs e)
        {
            TakeImage(pictureBox_Back_CCCD);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
