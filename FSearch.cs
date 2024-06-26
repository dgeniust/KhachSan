﻿using Guna.UI2.WinForms;
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
        ItemDAO itemDAO = new ItemDAO();
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
            this.btn_Information.Text = TENTK;
        }
        private void FSearch_Load(object sender, EventArgs e)
        {
            htDAO.GeneratePanelHotel(search.address, Panel_Hotel, search, tentk);
            dcD.GenerateDiscountPanel(Panel_Discount,tentk);
            this.cmb_Location.Text = search.address;
            this.dtp_DateTake.Value = search.startday;
            this.dtp_DateBack.Value = search.endday;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            htDAO.GeneratePanelHotel(cmb_Location.Text, Panel_Hotel, search, tentk);
            search.startday = dtp_DateTake.Value.Date;
            search.endday = dtp_DateBack.Value.Date;
            var start = dtp_DateTake.Value.Day;
            var end = dtp_DateBack.Value.Day;
            search.spendnight = end - start;
            this.Refresh();
        }

        private void btn_SaleBirthday_Click(object sender, EventArgs e)
        {
            htDAO.GeneratePanelDiscount("Sale sinh nhật", Panel_Hotel, search, tentk);
        }

        private void btn_SpecialDiscount_Click(object sender, EventArgs e)
        {
            htDAO.GeneratePanelDiscount("Ưu đãi đặc biệt", Panel_Hotel, search, tentk);
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            FSearch_Load(sender, e);
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itemDAO.ShowInfomation(dragdownCon, timer1);
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_MyHotel_Click(object sender, EventArgs e)
        {

        }

        private void btn_OwnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
