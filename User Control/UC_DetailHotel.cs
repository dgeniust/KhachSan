﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan.User_Control
{
    public partial class UC_DetailHotel : UserControl
    {
        Room room;
        Search search;
        HotelDAO htDAO = new HotelDAO();
        DBConnection db = new DBConnection();
        string tentk;
        public UC_DetailHotel()
        {
            InitializeComponent();
        }
        
        public UC_DetailHotel(Room ROOM, Search search, string TENTK)
        {
            InitializeComponent();
            this.room = ROOM;
            this.lbl_Name.Text = ROOM.name;
            this.lbl_Name2.Text = ROOM.name;
            this.btn_Bed.Text = ROOM.bed;
            this.btn_area.Text = ROOM.area;
            this.btn_Guest.Text = ROOM.guest_number + " khách"; 
            this.lbl_Price.Text = ROOM.price.ToString()+" VND";
            this.btn_Tienich1.Text = ROOM.tienich1;
            this.btn_Tienich2.Text = ROOM.tienich2;
            this.btn_Tienich3.Text = ROOM.tienich3;
            this.btn_Tienich4.Text = ROOM.tienich4;
            this.btn_Dodung1.Text = ROOM.dodung1;
            this.btn_Dodung2.Text = ROOM.dodung2;
            this.pictureBox1.Image = htDAO.LoadImageFromFile(ROOM.p1);
            this.pictureBox2.Image = htDAO.LoadImageFromFile(ROOM.p2);
            this.pictureBox3.Image = htDAO.LoadImageFromFile(ROOM.p3);
            this.pictureBox4.Image = htDAO.LoadImageFromFile(ROOM.p4);
            this.lbl_OldPrice.Text = "Giá cũ: "+ ROOM.oldprice.ToString()+" VND";
            this.search = search;
            this.tentk = TENTK;
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {
            string query = "Select * from datphong where tentk='" + tentk + "'";
            DataTable dt = new DataTable();
            int s = 0;
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                DatPhong dp = new DatPhong(dr);
                if (dp.roomname == room.name || dp.ngaynhan == search.startday || dp.ngaytra == search.endday)
                {
                    s++;
                }
            }
            if(s > 0)
            {
                MessageBox.Show($"Bạn đã đặt phòng này vào ngày " + search.startday + " rồi");
            }
            else
            {
                FPay pay = new FPay(room, search, tentk);
                pay.Show();
            }
        }
    }
}
