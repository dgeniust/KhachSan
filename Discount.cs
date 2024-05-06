using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan
{
    public class Discount
    {
        public string MaGG;
        public string NoiDung;
        public string TenKhachSan;
        public string TinhTrang;

        public Discount(string maGG, string noiDung, string tenKhachSan, string tinhTrang, string nguoiSoHuu)
        {
            this.MaGG = maGG;
            this.NoiDung = noiDung;
            this.TenKhachSan = tenKhachSan;
            this.TinhTrang = tinhTrang;
        }
        public Discount(DataRow dr, string nguoiSoHuu = null)
        {
            this.MaGG = dr[0].ToString();
            this.NoiDung = dr[1].ToString();
            this.TenKhachSan = dr[2].ToString();
            this.TinhTrang = dr[3].ToString();
        }
    }
}
