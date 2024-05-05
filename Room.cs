using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan
{
    public class Room
    {
        public string email;
        public string hotelname;
        public string name;
        public string area;
        public string bed;
        public string guest_number;
        public double oldprice;
        public double price;

        public string tienich1;
        public string tienich2;
        public string tienich3;
        public string tienich4;

        public string dodung1;
        public string dodung2;

        public string p1;
        public string p2;
        public string p3;
        public string p4;


        /*public Room(DataRow dr)
        {
            this.email = dr[0].ToString();
            this.hotelname = dr[1].ToString();
            this.name = dr[2].ToString();
            this.area = dr[3].ToString();
            this.bed = dr[4].ToString();
            this.guest_number = dr[5].ToString();
            this.oldprice = Convert.ToDouble(dr[7]);
            this.price = Convert.ToDouble(dr[6]);
            this.tienich1 = dr[8].ToString();
            this.tienich2 = dr[9].ToString();
            this.tienich3 = dr[10].ToString();
            this.p1 = dr[11].ToString();
            this.p2 = dr[12].ToString();
            this.p3 = dr[13].ToString();
            this.p4 = dr[14].ToString();
        }*/

        /*public Room(string email, string hotelname, string name, string area, string bed, string guest_number, double oldprice, double price, string tienich1, string tienich2, string tienich3, string p1, string p2, string p3, string p4)
        {
            this.email = email;
            this.hotelname = hotelname;
            this.name = name;
            this.area = area;
            this.bed = bed;
            this.guest_number = guest_number;
            this.oldprice = oldprice;
            this.price = price;
            this.tienich1 = tienich1;
            this.tienich2 = tienich2;
            this.tienich3 = tienich3;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }*/

        public Room(DataRow dr)
        {
            this.email = dr[0].ToString();
            this.hotelname = dr[1].ToString();
            this.name = dr[2].ToString();
            this.area = dr[3].ToString();
            this.bed = dr[4].ToString();
            this.guest_number = dr[5].ToString();
            this.oldprice = Convert.ToDouble(dr[7]);
            this.price = Convert.ToDouble(dr[6]);
            this.tienich1 = dr[8].ToString();
            this.tienich2 = dr[9].ToString();
            this.tienich3 = dr[10].ToString();
            this.tienich4 = dr[11].ToString();
            this.dodung1 = dr[12].ToString();
            this.dodung2 = dr[13].ToString();
            this.p1 = dr[14].ToString();
            this.p2 = dr[15].ToString();
            this.p3 = dr[16].ToString();
            this.p4 = dr[17].ToString();
        }
        public Room(string email, string hotelname, string name, string area, string bed, string guest_number, double oldprice, double price, string tienich1, string tienich2, string tienich3, string tienich4, string dodung1, string dodung2, string p1, string p2, string p3, string p4)
        {
            this.email = email;
            this.hotelname = hotelname;
            this.name = name;
            this.area = area;
            this.bed = bed;
            this.guest_number = guest_number;
            this.oldprice = oldprice;
            this.price = price;
            this.tienich1 = tienich1;
            this.tienich2 = tienich2;
            this.tienich3 = tienich3;
            this.tienich4 = tienich4;
            this.dodung1 = dodung1;
            this.dodung2 = dodung2;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
    }
}
