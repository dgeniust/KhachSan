using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class RatingHotel : Form
    {
        DatPhong dp;
        CommentDAO cmtDAO = new CommentDAO(); 
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        string imageLocation = "";
        HotelDAO hotelDAO = new HotelDAO();
        public RatingHotel(DatPhong DP)
        {
            InitializeComponent();
            this.dp = DP;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Comment cmt = new Comment(dp.tentk,dp.hotelname,"",pictureBox1.ImageLocation,pictureBox2.ImageLocation, rt_Value.Value,txt_Comment.Text);
            cmtDAO.AddComment(cmt);

            FSuccess fcc = new FSuccess();
            fcc.ShowDialog();
            this.Hide();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            hotelDAO.GeneratePicture(imageLocation, pictureBoxes);
        }
    }
}
