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
        TaiKhoan tk;
        DatPhong dp;
        string value;
        public FBookRoom()
        {
            InitializeComponent();
        }
        public FBookRoom(string VALUE)
        {
            InitializeComponent();
            this.value = VALUE;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Information.Text = value;
            string query = string.Format("Select * from taikhoan where tentaikhoan='" + value + "'");
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                TaiKhoan TK = new TaiKhoan(dr);
                this.tk = TK;
            }
        }
        bool expand = false;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dragdownCon.Height += 20;
                if (dragdownCon.Height >= dragdownCon.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                dragdownCon.Height -= 20;
                if (dragdownCon.Height <= dragdownCon.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void dragdownCon_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int date, month, year;
        string endday = "";

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            FInfoOwner fi = new FInfoOwner(tk);
            fi.BTN_CONTINUE.Visible = false;
            fi.Show();
        }

        private void btn_OwnBook_Click(object sender, EventArgs e)
        {
            string name = tk.hoten;
            string query = string.Format("SELECT * FROM DATPHONG WHERE Email='" + tk.email + "'");
            FMyBook fmb = new FMyBook(dp,name,query);
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

        int p, k, people;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            p = Convert.ToInt32(cmb_People.Text);
            k = Convert.ToInt32(cmb_Kid.Text);
            people = p + k;
            //Search sr = new Search(datetimepicker_ReceiveRoom.Value.Date,Convert.ToInt32(cmb_Night.Text), cmb_Location.Text);
            Search sr = new Search(datetimepicker_ReceiveRoom.Value.Date,Convert.ToDateTime(endday), Convert.ToInt32(cmb_Night.Text), cmb_Location.Text, people);
            FSearch fs = new FSearch(sr);
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
