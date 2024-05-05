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
    public partial class UC_Pay : UserControl
    {
        public UC_Pay()
        {
            InitializeComponent();
        }
        Room r;
        public UC_Pay(Room room, Search search)
        {
            InitializeComponent();
            string room_and_night = search.number_of_room.ToString() + " phòng, " + search.spendnight.ToString() + " đêm";
            this.r = room;
            this.lbl_NameHotel.Text = room.hotelname;
            this.lbl_NameHotel2.Text = room.hotelname;
            this.lbl_RoomName.Text = room.name;
            this.lbl_Price.Text = room.price.ToString() + " VND";
            this.lbl_OldPrice.Text = "Giá cũ: " + room.oldprice.ToString() + " VND";
            this.btn_Bed.Text = room.bed;
            this.btn_Guest.Text = room.guest_number;
            this.lbl_Night.Text = search.spendnight.ToString() + " đêm";
            this.lbl_RoomAndNight.Text = room_and_night;
            lbl_ReceiveRoom.Text = search.startday.ToString();
            lbl_ReturnRoom.Text = search.startday.AddDays(search.spendnight).ToString();
        }

        private void UC_Pay_Load(object sender, EventArgs e)
        {
            
        }
    }
}
