using Guna.UI2.WinForms;
using KhachSan.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KhachSan
{
    public partial class FSearch : Form
    {
        HotelDAO htDAO = new HotelDAO();
        DiscountDAO dcD = new DiscountDAO();
        Search search;
        string tentk;
        public FSearch()
        {
            InitializeComponent();
        }
        public FSearch(Search sr,string TENTK)
        {
            InitializeComponent();
            this.search = sr;
            this.tentk = TENTK;
        }
        private void FSearch_Load(object sender, EventArgs e)
        {
            /*string query = "SELECT * FROM KHACHSAN WHERE DIACHI = '" + search.address + "'";*/
            string query = "SELECT * FROM KHACHSAN ";
            htDAO.GeneratePanel(query, Panel_Hotel, search);
            string disc = "Select * from MaGiamGia";
            dcD.GenerateDiscountPanel(disc, Panel_Discount,tentk);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KHACHSAN WHERE DIACHI = '" + cmb_Location.Text + "'";
            htDAO.GeneratePanel(query, Panel_Hotel, search);
            search.startday = dtp_DateTake.Value.Date;
            search.guest = Convert.ToInt32(cmb_People.Text);
            this.Refresh();
        }

        private void btn_SaleBirthday_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KHACHSAN WHERE UUDAI = N'Sale sinh nhật'";
            htDAO.GeneratePanel(query, Panel_Hotel, search);
        }

        private void btn_SpecialDiscount_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM KHACHSAN WHERE UUDAI = N'Ưu đãi đặc biệt'";
            htDAO.GeneratePanel(query, Panel_Hotel, search);
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            FSearch_Load(sender, e);
        }
    }
}
