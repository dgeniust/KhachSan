using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan.Account
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        DBConnection db = new DBConnection();
        public List<TaiKhoan> taiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();   
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(sqlDataReader.GetString(0), sqlDataReader.GetString(1), "", "", "", "", "", "", "", "", "", ""));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query)
        {
            using(SqlConnection sqlConnection=Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void UpdateAccount(TaiKhoan tk)
        {
            string thongbao = "Thêm thông tin thành công";
            string update = string.Format("UPDATE TAIKHOAN SET HOTEN=N'{0}', NGAYSINH='{1}', GIOITINH=N'{2}', DIACHI=N'{3}', SDT='{4}', CCCD='{5}', OWNERIMAGE='{6}', FRONTCCCD='{7}', BACKCCCD='{8}' WHERE EMAIL='{9}'", tk.hoten, tk.ngaysinh, tk.gioitinh, tk.diachi, tk.sdt, tk.cccd, tk.ownerimage, tk.frontcccd, tk.backcccd, tk.email);
            db.ThucThi(update, thongbao);
        }
    }
}
