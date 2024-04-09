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
    public partial class UC_Hotels : UserControl
    {

        public UC_Hotels()
        {
            InitializeComponent();
        }
        public Label HotelName => lbl_HotelName;
        public Guna2Button Type => lbl_TypeOf;
        public Button TienIch1 => lbl_TienIch1;
        public Button TienIch2 => lbl_TienIch2;
        public Guna2Button Rate => lbl_Rate;
        public Label Pricr => lbl_Price;
        public Label OldPrice => lbl_OldPrice;
        public Guna2Button ChooseRoom => btn_ChooseRoom;
    }
}
