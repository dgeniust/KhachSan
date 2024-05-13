using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan.User_Control
{
    public partial class UC_MyBook : UserControl
    {
        DatPhong dp;
        DatPhongDAO dpDAO = new DatPhongDAO();
        public Guna2Button BTN_CANCLE => btn_Cancel;
        public UC_MyBook(DatPhong DP)
        {
            InitializeComponent();
            string info = DP.guest + " khách, " + DP.giuong +" "+ DP.sodem + " đêm";
            this.dp = DP;
            //this.pictureBox_Room.Image = dpDAO.LoadImageFromFile(DP.image);
            this.lbl_HotelName.Text = DP.hotelname;
            this.lbl_RoomName.Text = DP.roomname;
            this.lbl_DateReceive.Text = DP.ngaynhan.ToString();
            this.lbl_DateReturn.Text = DP.ngaytra.ToString();
            this.lbl_Info.Text = info;
            this.pictureBox_Room.Image = dpDAO.LoadImageFromFile(DP.image);
        }

        private void UC_MyBook_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            string thongbao = $"Hủy phòng {dp.roomname} tại khách sạn {dp.hotelname} thành công";
            DatPhong dphong = new DatPhong(dp.hoten, dp.email, dp.sdt,dp.hotelname, dp.roomname, dp.price, dp.ngaynhan, dp.ngaytra, dp.sodem, dp.guest, dp.giuong, dp.image,dp.tentk);
            dpDAO.Delete(dphong,thongbao);
            MessageBox.Show("Phòng của bạn sẽ đc hủy trong 24h tới");
            this.btn_Cancel.FillColor = Color.DimGray;
            this.btn_Cancel.Text = "Đang hủy";
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string thongbao = $"Thanh toán phòng {dp.roomname} tại khách sạn {dp.hotelname} thành công";
            DatPhong dphong = new DatPhong(dp.hoten, dp.email, dp.sdt, dp.hotelname, dp.roomname, dp.price, dp.ngaynhan, dp.ngaytra, dp.sodem, dp.guest, dp.giuong, dp.image, dp.tentk);
            dpDAO.Delete(dphong,thongbao);
            RatingHotel rh = new RatingHotel(dp);
            rh.Show();
            this.btn_ThanhToan.FillColor = Color.DimGray;
            this.btn_Cancel.Enabled = false;
        }
    }
}
