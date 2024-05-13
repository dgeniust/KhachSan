using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan
{
    public class Comment
    {
        public string username;
        public string hotelname;
        public string imageuser;
        public string image1;
        public string image2;
        public double star;
        public string usercomment;

        public Comment(string username, string hotelname, string imageuser, string image1, string image2, double star, string usercomment)
        {
            this.username = username;
            this.hotelname = hotelname;
            this.imageuser = imageuser;
            this.image1 = image1;
            this.image2 = image2;
            this.star = star;
            this.usercomment = usercomment;
        }
        public Comment(DataRow dr)
        {
            this.username = dr[0].ToString();
            this.hotelname = dr[1].ToString();
            this.imageuser = dr[2].ToString();
            this.image1 = dr[3].ToString();
            this.image2 = dr[4].ToString();
            this.star = Convert.ToDouble(dr[5].ToString());
            this.usercomment = dr[6].ToString();
        }
    }
}
