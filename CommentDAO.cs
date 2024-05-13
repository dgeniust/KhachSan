using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using KhachSan.User_Control;
using System.Collections;
using System.Windows.Forms;
namespace KhachSan
{
    public class CommentDAO
    {
        DBConnection db = new DBConnection();
        ItemDAO itemDAO = new ItemDAO();
        public void AddComment(Comment cmt)
        {
            string thongbao = "Cảm ơn bạn đã đánh giá";
            string query = string.Format("Insert into Comment values ('{0}','{1}','{2}','{3}','{4}',{5},N'{6}')", cmt.username, cmt.hotelname, cmt.imageuser, cmt.image1, cmt.image2, cmt.star, cmt.usercomment);
            db.ThucThi(query,thongbao);
        }
        public Image LoadImageFromFile(string filePath)
        {
            return itemDAO.LoadImageFromFile(filePath);
        }
        public void GenerateComment(Panel storage_panel, string value)
        {
            string query = "SELECT * FROM COMMENT WHERE TENKHACHSAN = '" + value + "'";
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(1287, 135),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Comment cmt = new Comment(dr);
                UC_Comment uC_Comment = new UC_Comment(cmt);
                x += 157;
                panel.Controls.Add(uC_Comment);
                storage_panel.Controls.Add(panel);
            }
        }
    }
}
