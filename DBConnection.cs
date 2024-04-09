using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DataTable LoadData(string query)
        {
            string sqlStr = string.Format(query);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void ThucThi(string thucthi, string thongbao)
        {
            try
            {
                conn.Open();
                string sql = thucthi;
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(thongbao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
