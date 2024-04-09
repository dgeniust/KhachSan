using KhachSan.User_Control;
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
    public partial class FPay : Form
    {
        DBConnection db = new DBConnection();
        DatPhongDAO dpDao = new DatPhongDAO();
        Search search;
        Room room;
        DatPhong dp;
        public FPay()
        {
            InitializeComponent();
        }

        public FPay(Room ROOM, Search search)
        {
            InitializeComponent();
            this.room = ROOM;
            this.search = search;
        }
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            DatPhong dt = new DatPhong(txt_Name_Guest.Text, txt_Email_Guest.Text, txt_Phone_Guest.Text,room.hotelname, room.name, room.price, search.startday, search.endday, search.spendnight,search.guest, room.bed, room.p1);
            dpDao.Add(dt);
            this.dp = dt;
            string query = string.Format("SELECT * FROM DATPHONG WHERE Email='" + dp.email + "'");
            string name = dp.hoten;
            FMyBook fmb = new FMyBook(dp,name, query);
            fmb.Show();
            this.Hide();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            Panel_DetailHotelPay.Controls.Clear();
            string query = "SELECT * FROM PHONG WHERE TENPHONG ='" + room.name + "'";
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                Room room = new Room(dr);
                UC_Pay pay = new UC_Pay(room, search);
                Panel_DetailHotelPay.Controls.Add(pay);
                pay.Dock = DockStyle.Fill;
            }
            this.lbl_Pay_Price.Text = room.price + " VND";
            int result = Convert.ToInt32(room.price) + 31905;
            this.lbl_Pay_Total.Text = Convert.ToString(result) + " VND";
        }
    }
}
