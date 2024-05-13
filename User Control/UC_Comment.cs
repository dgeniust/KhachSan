using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan.User_Control
{
    public partial class UC_Comment : UserControl
    {
        CommentDAO cmtDAO = new CommentDAO();
        public UC_Comment()
        {
            InitializeComponent();
        }
        public UC_Comment(Comment cmt)
        {
            InitializeComponent();
            this.lbl_Name.Text = cmt.username;
            this.rs_Value.Value = (float)cmt.star;
            this.txt_Comment.Text = cmt.usercomment;
            this.pictureBox_i1.Image = cmtDAO.LoadImageFromFile(cmt.image1);
            this.pictureBox_i2.Image = cmtDAO.LoadImageFromFile(cmt.image2);
        }
    }
}
