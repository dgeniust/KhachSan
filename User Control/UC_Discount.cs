using Guna.UI2.WinForms;
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
    public partial class UC_Discount : UserControl
    {
        public Label Lbl_Name { get => lbl_Name; set => lbl_Name = value; }
        public RichTextBox Txt_Content { get => txt_Content; set => txt_Content = value; }
        public Guna2Button Btn_Take { get => btn_Take; set => btn_Take = value; }
        Discount dc;
        DBConnection db = new DBConnection();
        string tentk;
        public UC_Discount(Discount DC, string TENTK)
        {
            InitializeComponent();
            this.dc = DC;
            this.lbl_Name.Text = DC.MaGG;
            this.txt_Content.Text = DC.NoiDung;
            this.tentk = TENTK;
            if(DC.TinhTrang == "Available")
            {
                this.lbl_Name.ForeColor = Color.FromArgb(30, 40, 45);
                this.txt_Content.ForeColor = Color.Black;
                this.btn_Take.FillColor = Color.RoyalBlue;
            }
            else
            {
                this.lbl_Name.ForeColor = Color.DimGray;
                this.txt_Content.ForeColor = Color.DimGray;
                this.btn_Take.FillColor = Color.DimGray;
            }
        }

        private void btn_Take_Click(object sender, EventArgs e)
        {
            /*string query = string.Format("Update Magiamgia set Nguoisohuu ='{0}' where MaGG ='{1}'", tentk, this.lbl_Name.Text);
            string thongbao = "Lấy mã thành công !";
            db.ThucThi(query, thongbao);*/
            this.lbl_Name.ForeColor = Color.DimGray;
            this.txt_Content.ForeColor = Color.DimGray;
            this.btn_Take.FillColor = Color.DimGray;
        }
    }
}
