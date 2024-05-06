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
        DatPhongDAO dpDao = new DatPhongDAO();
        PayDAO pd = new PayDAO();
        Search search;
        Room room;
        DatPhong dp;
        int result;
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
            DatPhong datphong = new DatPhong(txt_Name_Guest.Text, txt_Email_Guest.Text, txt_Phone_Guest.Text,room.hotelname, room.name, room.price, search.startday, search.endday, search.spendnight,search.guest, room.bed, room.p1);
            dpDao.Add(datphong);
            this.dp = datphong;
            string query = string.Format("SELECT * FROM DATPHONG WHERE Email='" + dp.email + "'");
            string name = dp.hoten;
            FMyBook fmb = new FMyBook(dp,name, query);
            fmb.Show();
            this.Hide();
            dpDao.SendEmail(room,search, dp.email);

            FSuccess fcc = new FSuccess();
            fcc.ShowDialog();
            this.Hide();
        }
        private void Pay_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHONG WHERE TENPHONG ='" + room.name + "'";
            pd.GeneratePayPanel(query, Panel_DetailHotelPay, search);
            this.lbl_Pay_Price.Text = room.price + " VND";
            result = Convert.ToInt32(room.price) + 31905;
            this.lbl_Pay_Total.Text = Convert.ToString(result) + " VND";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ApplyCode_Click(object sender, EventArgs e)
        {
            int ketquacuoicung = result - pd.CheckDiscountCode(txt_MaGG.Text, result);
            //MessageBox.Show(ketquacuoicung.ToString());
            if (ketquacuoicung != result)
            {
                MessageBox.Show("Bạn đã áp dụng mã " + txt_MaGG.Text + " thành công. Số tiền được giảm là: " + pd.CheckDiscountCode(txt_MaGG.Text, result) + " VND");
                this.lbl_Pay_Total.Text = ketquacuoicung.ToString() + " VND";
            }
            else
            {
                MessageBox.Show("Bạn không đủ điều kiện để áp dụng mã giảm giá");
            }

        }
    }
}
