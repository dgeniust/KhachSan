using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan
{
    public class DatPhong
    {
        public string hoten;
        public string email;
        public string sdt;
        public string hotelname;
        public string roomname;
        public double price;
        public DateTime ngaynhan;
        public DateTime ngaytra;
        public int sodem;
        public int guest;
        public string giuong;
        public string image;

        public DatPhong(string hoten, string email, string sdt, string hotelname, string roomname, double price, DateTime ngaynhan, DateTime ngaytra, int sodem,int guest, string giuong, string image)
        {
            this.hoten = hoten;
            this.email = email;
            this.sdt = sdt;
            this.hotelname = hotelname;
            this.roomname = roomname;
            this.price = price;
            this.ngaynhan = ngaynhan;
            this.ngaytra = ngaytra;
            this.sodem = sodem;
            this.guest = guest;
            this.giuong = giuong;
            this.image = image;
        }
        public DatPhong(DataRow dr)
        {
            this.hoten = dr[0].ToString();
            this.email = dr[1].ToString();
            this.sdt = dr[2].ToString();
            this.hotelname = dr[3].ToString();  
            this.roomname= dr[4].ToString();    
            this.price = Convert.ToDouble(dr[5].ToString());
            this.ngaynhan = Convert.ToDateTime(dr[6].ToString());
            this.ngaytra = Convert.ToDateTime(dr[7].ToString());
            this.sodem = Convert.ToInt32(dr[8].ToString());
            this.guest = Convert.ToInt32(dr[9].ToString());
            this.giuong = dr[10].ToString(); 
            this.image = dr[11].ToString(); 
        }
    }
}
