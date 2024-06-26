﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace KhachSan.User_Control
{
    public partial class UC_Hotel : System.Windows.Forms.UserControl
    {
        Hotel ht;
        Search search;
        DBConnection db = new DBConnection();
        HotelDAO htDAO = new HotelDAO();
        string tentk;
        public UC_Hotel()
        {
            InitializeComponent();
        }

        public UC_Hotel(Hotel HOTEL, Search search, string TENTK)
        {
            InitializeComponent();
            this.ht = HOTEL;
            this.lbl_HotelName.Text = HOTEL.name;
            this.lbl_Price.Text = HOTEL.price.ToString() + " VND";
            this.lbl_OldPrice.Text = "Giá cũ: " + HOTEL.oldprice.ToString() + " VND";
            this.btn_Rate.Text = HOTEL.rate.ToString();
            this.btn_TienIch1.Text = HOTEL.tienich1;
            this.btn_TienIch2.Text = HOTEL.tienich2;
            this.btn_TypeOf.Text = HOTEL.type;
            this.pictureBox_Hotel.Image = htDAO.LoadImageFromFile(HOTEL.picture);
            this.search = search;
            this.tentk = TENTK;
            if (HOTEL.uudai == "Sale sinh nhật")
            {
                this.btn_Edition.Text = "Sale sinh nhật";
            }
            else if(HOTEL.uudai == "Ưu đãi đặc biệt")
            {
                this.btn_Edition.Text = "Ưu đãi đặc biệt";
            }
            else
            {
                this.btn_Edition.Visible = false;
            }
        }
        private void btn_ChooseRoom_Click(object sender, EventArgs e)
        {
                DetailHotel dh = new DetailHotel(ht, search, tentk);
                dh.Show();
        }

        public void UC_Hotel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên khách sạn: " + this.lbl_HotelName.Text);
        }
    }
}
