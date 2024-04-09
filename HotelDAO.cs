﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web.UI;
using KhachSan.User_Control;

namespace KhachSan
{
    internal class HotelDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection db = new DBConnection();

        //Thêm khách sạn mới
        public void Add(Hotel ht)
        {
            string thongbao = "Thêm khách sạn thành công";
            string add = string.Format("INSERT INTO KHACHSAN VALUES('{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',N'{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}')",ht.email,ht.id,ht.name,ht.address,ht.type, ht.detailaddress, ht.star, ht.price, ht.oldprice, ht.rate, ht.tienich1, ht.tienich2, ht.tienich3, ht.phone, ht.mota, ht.picture, ht.p1, ht.p2, ht.p3, ht.p4, ht.p5, ht.p6);
            db.ThucThi(add, thongbao);
        }

        //Load ảnh từ file có sẵn
        public Image LoadImageFromFile(string filePath)
        {
            try
            {
                if(filePath != null)
                {
                    return Image.FromFile(filePath);
                }
                else
                {
                    return null;
                }
            }
            catch (FileNotFoundException)
            {
                // Handle file not found exception (e.g., display error message)
                MessageBox.Show("Error: Image file not found!");
                return null;
            }
        }

        //Tự tạo panel cho các Khách sạn tại địa điểm mình đã chọn
        public void GeneratePanel(string query, Panel storage_panel, Search sr)
        {
            storage_panel.Controls.Clear();
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

                UC_Hotel hotel = new UC_Hotel(ht, sr);
                x += 109;
                panel.Controls.Add(hotel);
                storage_panel.Controls.Add(panel);
            }
        }

        //Thêm ảnh cho khách sạn đang được tạo 
        public void GeneratePicture(string imageLocation, List<PictureBox> pictureBoxes)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";


                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLocation = dialog.FileName;
                        pictureBoxes[i].ImageLocation = imageLocation;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}