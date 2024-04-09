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
        HotelDAO htDAO = new HotelDAO();
        public DetailHotel()
        {
            InitializeComponent();
        }
    
        public DetailHotel(Hotel HOTEL, Search SEARCH)
        {
            InitializeComponent();
            this.ht = HOTEL;
            this.sr = SEARCH;
        }
        private void DetailHotel_Load(object sender, EventArgs e)
        {
            this.lbl_HotelName.Text = lbl_HotelName_small.Text = ht.name;
            this.lbl_Price.Text = Convert.ToString(ht.price);
            this.btn_TypeOf.Text = ht.type;
            this.btn_Address.Text = ht.detailaddress;
            this.pictureBox1.Image = htDAO.LoadImageFromFile(ht.p1);
            this.pictureBox2.Image = htDAO.LoadImageFromFile(ht.p2);
            this.pictureBox3.Image = htDAO.LoadImageFromFile(ht.p3);
            this.pictureBox4.Image = htDAO.LoadImageFromFile(ht.p4);
            this.pictureBox5.Image = htDAO.LoadImageFromFile(ht.p5);
            this.pictureBox6.Image = htDAO.LoadImageFromFile(ht.p6);

            Panel_EachRoom.Controls.Clear();
            string query = "SELECT * FROM PHONG WHERE TenKhachSan= '" + ht.name + "'";
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach(DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(963, 340),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Room room = new Room(dr);

                x += 345;
                UC_DetailHotel dtht = new UC_DetailHotel(room,sr);
                panel.Controls.Add(dtht);
                dtht.Dock = DockStyle.Fill;
                Panel_EachRoom.Controls.Add(panel);
            }
        }
    }
}
