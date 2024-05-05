using KhachSan.Account;
using KhachSan.User_Control;
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
    public partial class FMyBook : Form
    {
        DatPhong dp;
        //TaiKhoan tk;
        DatPhongDAO dpDAO = new DatPhongDAO();
        string query = "";
        string name = "";
        public FMyBook()
        {
            InitializeComponent();
        }
        public FMyBook(DatPhong DP,string NAME, string QUERY)
        {
            InitializeComponent();
            this.dp = DP;
            this.query = QUERY;
            this.name = NAME;
            this.lbl_Hello.Text = "Xin chào " + NAME;
        }
        
        private void FMyBook_Load(object sender, EventArgs e)
        {
            /*string query = string.Format("SELECT * FROM DATPHONG WHERE Email='" + email + "'");*/
            /*string query = string.Format("SELECT * FROM DATPHONG WHERE Email='hdq@gmail.com'");*/
            dpDAO.GenerateBookPanel(query,Panel_MyRoom);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
