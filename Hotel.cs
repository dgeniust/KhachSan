using KhachSan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KhachSan
{
    public class Hotel
    {
        public string email;
        public string id;
        public string name;
        public string address;
        public string type;
        public string detailaddress;
        public string star;
        public double price;
        public double oldprice;
        public string rate;
        public string tienich1;
        public string tienich2;
        public string tienich3;
        public string phone;
        public string mota;
        public string picture;
        public string p1;
        public string p2;
        public string p3;
        public string p4;
        public string p5;
        public string p6;
        public string uudai;
        public Hotel(DataRow dr)
        {
            this.email = dr[0].ToString(); 
            this.id = dr[1].ToString();
            this.name = dr[2].ToString();
            this.address = dr[3].ToString();
            this.type = dr[4].ToString();
            this.detailaddress = dr[5].ToString();
            this.star = dr[6].ToString();
            this.price = Convert.ToDouble(dr[7]);
            this.oldprice = Convert.ToDouble(dr[8]);
            this.rate = dr[9].ToString();
            this.tienich1 = dr[10].ToString();
            this.tienich2 = dr[11].ToString();
            this.tienich3 = dr[12].ToString();
            this.phone = dr[13].ToString();
            this.mota = dr[14].ToString();
            this.picture = dr[15].ToString();
            this.p1 = dr[16].ToString();
            this.p2 = dr[17].ToString();
            this.p3 = dr[18].ToString();
            this.p4 = dr[19].ToString();
            this.p5 = dr[20].ToString();
            this.p6 = dr[21].ToString();
            this.uudai = dr[22].ToString();
        }

        public Hotel(string email, string id, string name, string address, string type, string detailaddress, string star, double price, double oldprice, string rate, string tienich1, string tienich2, string tienich3, string phone, string mota, string picture, string p1, string p2, string p3, string p4, string p5, string p6, string uudai)
        {
            this.email = email;
            this.id = id;
            this.name = name;
            this.address = address;
            this.type = type;
            this.detailaddress = detailaddress;
            this.star = star;
            this.price = price;
            this.oldprice = oldprice;
            this.rate = rate;
            this.tienich1 = tienich1;
            this.tienich2 = tienich2;
            this.tienich3 = tienich3;
            this.phone = phone;
            this.mota = mota;
            this.picture = picture;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.uudai = uudai;
        }
    }
}

