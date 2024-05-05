using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KhachSan.Account
{
    public class TaiKhoan
    {
        public string taikhoan;
        public string matkhau;
        public string email;
        public string hoten;
        public string ngaysinh;
        public string gioitinh;
        public string diachi;
        public string sdt;
        public string cccd;
        public string ownerimage;
        public string frontcccd;
        public string backcccd;
        public TaiKhoan() { }
        /*public TaiKhoan(string TK, string MK)
        {
            this.taikhoan = TK;
            this.matkhau = MK;  
        }*/

        public TaiKhoan(string TK, string MK, string email, string hoten, string ngaysinh, string gioitinh, string diachi, string sdt, string cccd, string ownerimage, string frontcccd, string backcccd)
        {
            this.taikhoan = TK;
            this.matkhau = MK;
            this.email = email;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.cccd = cccd;
            this.ownerimage = ownerimage;
            this.frontcccd = frontcccd;
            this.backcccd = backcccd;
        }
        public TaiKhoan(DataRow dr)
        {
            this.taikhoan = dr[0].ToString();
            this.email = dr[2].ToString();
            this.hoten = dr[3].ToString();  
            this.ngaysinh = dr[4].ToString();
            this.gioitinh = dr[5].ToString();
            this.diachi = dr[6].ToString();
            this.sdt = dr[7].ToString();
            this.cccd = dr[8].ToString();
            this.ownerimage = dr[9].ToString();
            this.frontcccd = dr[10].ToString();
            this.backcccd = dr[11].ToString();
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Email { get => email; set => email = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Ownerimage { get => ownerimage; set => ownerimage = value; }
        public string Frontcccd { get => frontcccd; set => frontcccd = value; }
        public string Backcccd { get => backcccd; set => backcccd = value; }
    }
}
