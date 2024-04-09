using Guna.UI2.WinForms;
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
    public partial class FHotel : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FHotel()
        {
            InitializeComponent();
        }
        /*int value;
        public FHotel(string Value)
        {
            InitializeComponent();
            *//*this.value = int.Parse(Value);*//*
        }*/
        DBConnection db = new DBConnection();
        public Label LBL_NAMEOFHOTEL => lbl_NameOfHotel;
        public Guna2HtmlLabel LBL_PHONE => lbl_Phone;
        public Label LBL_INFOOFHOTEL=> lbl_InfoOfHotel;
        public Label LBL_ADDRESS=> lbl_Address;
        public Guna2RatingStar RATING_STAR => rating_star;

        private void FHotel_Load_2(object sender, EventArgs e)
        {
            /*string query = "SELECT * FROM PHONG WHERE IDCON = '" + value + "'";
            this.dvg_Room.DataSource = db.LoadData(conn, query);*/
            /*MessageBox.Show("Query: " + "SELECT * FROM PHONG WHERE IDCON = '" + value + "'");*/
        }
    }
}
