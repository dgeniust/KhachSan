using KhachSan.User_Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace KhachSan
{
    public class PayDAO
    {
        DBConnection db = new DBConnection();
        public void GeneratePayPanel(string query, Panel panel, Search search)
        {
            panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                Room room = new Room(dr);
                UC_Pay pay = new UC_Pay(room, search);
                panel.Controls.Add(pay);
                pay.Dock = DockStyle.Fill;
            }
        }
        public int CheckDiscountCode(string code, int result)
        {
            if(code == "SALESINHNHAT" && result > 900000)
            {
                int max = 300000;
                int kq1 = result * 5 / 100;
                if(kq1 > max )
                {
                    kq1 = max;
                }
                return kq1;
            }
            else if(code == "UUDAIDACBIET" && result > 500000)
            {
                int max = 200000;
                int kq2 = result * 5 / 100;
                if (kq2 > max )
                {
                    kq2 = max;
                }
                return kq2;
            }
            else if( code == "XINCHAOKS")
            {
                return 200000;
            }
            else
            {
                return 0;
            }
        }
    }
}
