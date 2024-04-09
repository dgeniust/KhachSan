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
    public partial class UC_DetailHotel : UserControl
    {
        public Guna2Button BookNow => btn_BookNow;
        Room room;
        Search search;
        HotelDAO htDAO = new HotelDAO();
        public UC_DetailHotel()
        {
            InitializeComponent();
        }
        
        public UC_DetailHotel(Room ROOM, Search search)
        {
            InitializeComponent();
            this.room = ROOM;
            this.lbl_Name.Text = ROOM.name;
            this.lbl_Name2.Text = ROOM.name;
            this.btn_Bed.Text = ROOM.bed;
            this.btn_area.Text = ROOM.area;
            this.btn_Guest.Text = ROOM.guest_number; 
            this.lbl_Price.Text = ROOM.price.ToString()+" VND";
            this.pictureBox1.Image = htDAO.LoadImageFromFile(ROOM.p1);
            this.pictureBox2.Image = htDAO.LoadImageFromFile(ROOM.p2);
            this.pictureBox3.Image = htDAO.LoadImageFromFile(ROOM.p3);
            this.pictureBox4.Image = htDAO.LoadImageFromFile(ROOM.p4);
            this.lbl_OldPrice.Text = "Giá cũ: "+ ROOM.oldprice.ToString()+" VND";
            this.search = search;
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {
            FPay pay = new FPay(room,search);
            pay.Show();
        }
    }
}
