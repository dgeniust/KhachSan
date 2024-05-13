using KhachSan.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class DetailHotel : Form
    {
        DBConnection db = new DBConnection();
        Hotel ht;
        Search sr;
        string tentk;
        HotelDAO htDAO = new HotelDAO();
        RoomDAO roomDAO = new RoomDAO();
        CommentDAO commentDAO = new CommentDAO();
        public DetailHotel()
        {
            InitializeComponent();
        }
    
        public DetailHotel(Hotel HOTEL, Search SEARCH, string tentk)
        {
            InitializeComponent();
            this.ht = HOTEL;
            this.sr = SEARCH;
            this.tentk = tentk;
        }
        private void DetailHotel_Load(object sender, EventArgs e)
        {
            this.lbl_HotelName.Text = lbl_HotelName_small.Text = ht.name;
            this.lbl_Price.Text = Convert.ToString(ht.price) + " VND";
            this.btn_TypeOf.Text = ht.type;
            this.btn_Address.Text = ht.detailaddress;
            this.lbl_Desc.Text = ht.mota;
            this.pictureBox1.Image = htDAO.LoadImageFromFile(ht.p1);
            this.pictureBox2.Image = htDAO.LoadImageFromFile(ht.p2);
            this.pictureBox3.Image = htDAO.LoadImageFromFile(ht.p3);
            this.pictureBox4.Image = htDAO.LoadImageFromFile(ht.p4);
            this.pictureBox5.Image = htDAO.LoadImageFromFile(ht.p5);
            this.pictureBox6.Image = htDAO.LoadImageFromFile(ht.p6);

            roomDAO.GeneratePanel(ht.name, Panel_EachRoom,sr,tentk);

            commentDAO.GenerateComment(Panel_Comment, ht.name);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
