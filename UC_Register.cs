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

namespace KhachSan
{
    public partial class UC_Register : UserControl
    {
        public UC_Register()
        {
            InitializeComponent();
        }
        public LinkLabel link_Login1
        { get { return link_Login; } }
        public PictureBox pbox_Register_Exit
        { get { return pbox_btn_Exit; } }
        public Guna2Button BTN_REGISTER => btn_Register;
        public Guna2TextBox TXT_USERNAME_RGT => txt_Username;
        public Guna2TextBox TXT_PASSWORD_RGT => txt_Password;
        public Guna2TextBox TXT_GMAIL => txt_Gmail;
        private void UC_Register_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
