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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KhachSan
{
    public partial class FBookRoom : Form
    {
        DBConnection db = new DBConnection();
        ItemDAO itemDAO = new ItemDAO();
        TaiKhoan tk;
        DatPhong dp;
        string tentk;
        int p, k, people;
        int date, month, year;
        string endday = "";
        public FBookRoom()
        {
            InitializeComponent();
        }
        public FBookRoom(string TENTK)
        {
            InitializeComponent();
            this.tentk = TENTK;
            this.datetimepicker_ReceiveRoom.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Information.Text = tentk;
            string query = string.Format("Select * from taikhoan where tentaikhoan='" + tentk + "'");
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                TaiKhoan TK = new TaiKhoan(dr);
                this.tk = TK;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            itemDAO.ShowInfomation(dragdownCon, timer1);
        }

        private void dragdownCon_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void btn_Profile_Click(object sender, EventArgs e)
        {
            FInfoOwner fi = new FInfoOwner(tk);
            fi.BTN_CONTINUE.Visible = false;
            fi.Show();
        }

        private void btn_OwnBook_Click(object sender, EventArgs e)
        {
            string name = tk.hoten;
            string query = "SELECT * FROM DATPHONG WHERE Email='" + tk.email + "'";
            FMyBook fmb = new FMyBook(dp, name, query);
            fmb.Show();
            this.Hide();
        }

        private void txt_DateBack_Click(object sender, EventArgs e)
        {
            date = datetimepicker_ReceiveRoom.Value.Day + Convert.ToInt32(cmb_Night.Text);
            month = datetimepicker_ReceiveRoom.Value.Month;
            year = datetimepicker_ReceiveRoom.Value.Year;
            DateTime result = new DateTime(year, month, date);
            txt_DateBack.Text = Convert.ToString(result) + ", " + cmb_Night.Text + " đêm";
            endday = result.ToString();
        }

        private void btn_AddHotel_Click(object sender, EventArgs e)
        {
            FInfoOwner fi = new FInfoOwner(tk);
            fi.BTN_CONTINUE.Visible = true;
            fi.Show();
        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            FChatBox fcb = new FChatBox(tentk);
            fcb.ShowDialog();
        }

        private void btn_MyHotel_Click(object sender, EventArgs e)
        {
            string query = "Select * from khachsan where email ='"+tk.email+"'";
            FNewHotel fnh = new FNewHotel(tk, query);
            fnh.Show();
            if (fnh.TXT_HotelName.Text == "")
            {
                MessageBox.Show("Bạn chưa sở hữu khách sạn!");
                fnh.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            p = Convert.ToInt32(cmb_People.Text);
            k = Convert.ToInt32(cmb_Kid.Text);
            people = p + k;
            //Search sr = new Search(datetimepicker_ReceiveRoom.Value.Date,Convert.ToInt32(cmb_Night.Text), cmb_Location.Text);
            Search sr = new Search(datetimepicker_ReceiveRoom.Value.Date,Convert.ToDateTime(endday), Convert.ToInt32(cmb_Night.Text), cmb_Location.Text, people, Convert.ToInt32(cmb_Room.Text));
            FSearch fs = new FSearch(sr,tentk);
            fs.Show();
            this.Hide();
        }

        private void cmb_Room_DropDownClosed(object sender, EventArgs e)
        {
            string people = cmb_People.Text;
            string kid = cmb_Kid.Text;
            string room = cmb_Room.Text;
            txt_GuestAndRoom.Text = people + " người lớn, " + kid + " trẻ em, " + room + " phòng";
        }
    }
}
