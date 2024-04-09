using KhachSan.Account;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class DangNhap : Form
    {
        Modify modify = new Modify();
        public DangNhap()
        {
            InitializeComponent();
            uC_Login1.BTN_LOGIN.Click += LoginAccount;
            uC_Register1.BTN_REGISTER.Click += RegisterAccount;
            Timer tm = new Timer();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();

            uC_Register1.link_Login1.Click += showLogin;            //ấn vào show User Control Đăng nhập
            uC_Register1.pbox_Register_Exit.Click += Exit_Register; //nút thoát App của Đăng kí

            uC_Login1.link_Register1.Click += showRegister;         //ấn vào show User Control Đăng kí
            uC_Login1.pbox_Login_Exit.Click += Exit_Login;          //nút thoát App của Đăng nhập 
        }

        public void LoginAccount(object sender, EventArgs e)
        {
            string tentaikhoan = uC_Login1.TXT_USERNAME.Text;
            string matkhau = uC_Login1.TXT_PASSWORD.Text;
            if (tentaikhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập vào ô trống", "Thông báo");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập vào ô trống", "Thông báo");
            }
            else
            {
                string query = "SELECT * FROM TAIKHOAN WHERE TenTaiKhoan ='" + tentaikhoan + "' and MatKhau = '" + matkhau + "'";

                FBookRoom fbr = new FBookRoom(tentaikhoan);
                if (modify.taiKhoans(query).Count != 0)
                {
                    fbr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không chính xác!");
                }
            }
        }
        public void RegisterAccount(object sender, EventArgs e)
        {
            string tentaikhoan_dangky = uC_Register1.TXT_USERNAME_RGT.Text;
            string matkhau_dangky = uC_Register1.TXT_PASSWORD_RGT.Text;
            string gmail_dangky = uC_Register1.TXT_GMAIL.Text;

            if (modify.taiKhoans("SELECT * FROM TAIKHOAN WHERE Email = '" + gmail_dangky + "'").Count != 0)
            {
                MessageBox.Show("Email đã tồn tại, vui lòng nhập 1 email khác");
                return;
            }
            else
            {
                try
                {
                    string query = "INSERT INTO TAIKHOAN VALUES('" + tentaikhoan_dangky + "', '" + matkhau_dangky + "', '" + gmail_dangky + "','','','','','','','','','')";
                    modify.Command(query);
                    if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        uC_Register1.Visible = false;
                        uC_Login1.Visible = true;
                        uC_Login1.BringToFront();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("lỗi :" + ex);
                }
            }
        }
        private void Exit_Login(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Register(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> images = new List<Bitmap>();
            images.Add(Properties.Resources.login_photo1);
            images.Add(Properties.Resources.login_photo3);
            images.Add(Properties.Resources.login_photo4);
            int index = DateTime.Now.Second % images.Count;
            //this.pictureBox1.Image = images[index];

        }

        public void showLogin(object sender, EventArgs e)
        {
            uC_Login1.Visible = true;
            uC_Register1.Visible = false;
            uC_Login1.BringToFront();
        }
        public void showRegister(object sender, EventArgs e)
        {
            uC_Register1.Visible = true;
            uC_Login1.Visible = false;
            uC_Register1.BringToFront();
        }
    }
}
