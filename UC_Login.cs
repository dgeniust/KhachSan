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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }
        public LinkLabel link_Register1
        { get { return link_Register; } }
        public PictureBox pbox_Login_Exit
        { get { return pbox_btn_Exit; } }
        public Guna2Button BTN_LOGIN => btn_Login;
        public Guna2TextBox TXT_USERNAME => txt_Username;
        public Guna2TextBox TXT_PASSWORD => txt_Password;
        private void UC_Login_Load(object sender, EventArgs e)
        {

        }

        private void pbox_btn_Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
