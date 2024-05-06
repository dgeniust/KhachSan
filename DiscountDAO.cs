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
    public class DiscountDAO
    {
        DBConnection db = new DBConnection();
        public void GenerateDiscountPanel(string query, Panel storage_panel, string tentk)
        {
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(240, 80),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Discount dc = new Discount(dr);
                x += 82;
                UC_Discount disc = new UC_Discount(dc,tentk);
                panel.Controls.Add(disc);
                storage_panel.Controls.Add(panel);
            }
        }
    }
}
