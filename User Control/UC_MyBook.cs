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
    }
}
