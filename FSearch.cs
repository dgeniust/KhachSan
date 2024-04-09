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
        DBConnection db = new DBConnection();
        UC_Hotel hotel = new UC_Hotel();
        HotelDAO htDAO = new HotelDAO(); 

        Search search;
        public FSearch()
        {
            InitializeComponent();
        }


        /*string value;
        public FSearch(string VALUE)
        {
            InitializeComponent();
            value = VALUE;
        }*/
        public FSearch(Search VALUE)
        {
            InitializeComponent();
            search = VALUE;
        }
        private void FSearch_Load(object sender, EventArgs e)
        {
            /*Panel_Hotel.Controls.Clear();
            string query = "SELECT * FROM KHACHSAN WHERE DIACHI = '" + search.address + "'";
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(685, 110),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Hotel ht = new Hotel(dr);

                UC_Hotel hotel = new UC_Hotel(ht, search);
                x += 109;
                panel.Controls.Add(hotel);
                Panel_Hotel.Controls.Add(panel);
            }*/
            string query = "SELECT * FROM KHACHSAN WHERE DIACHI = '" + search.address + "'";
            htDAO.GeneratePanel(query, Panel_Hotel, search);
        }


    }
}
