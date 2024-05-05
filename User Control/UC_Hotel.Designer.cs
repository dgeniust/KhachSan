namespace KhachSan.User_Control
{
    partial class UC_Hotel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btn_ChooseRoom = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_OldPrice = new System.Windows.Forms.Label();
            this.lbl_HotelName = new System.Windows.Forms.Label();
            this.ratingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.btn_TienIch1 = new System.Windows.Forms.Button();
            this.btn_TienIch2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_TypeOf = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Rate = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_Hotel = new System.Windows.Forms.PictureBox();
            this.btn_Edition = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(663, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 129);
            this.guna2VSeparator1.TabIndex = 1;
            // 
            // btn_ChooseRoom
            // 
            this.btn_ChooseRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChooseRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChooseRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChooseRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChooseRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ChooseRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseRoom.ForeColor = System.Drawing.Color.White;
            this.btn_ChooseRoom.Location = new System.Drawing.Point(743, 86);
            this.btn_ChooseRoom.Name = "btn_ChooseRoom";
            this.btn_ChooseRoom.Size = new System.Drawing.Size(128, 40);
            this.btn_ChooseRoom.TabIndex = 3;
            this.btn_ChooseRoom.Text = "Chọn phòng";
            this.btn_ChooseRoom.Click += new System.EventHandler(this.btn_ChooseRoom_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Price.Location = new System.Drawing.Point(728, 38);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(155, 33);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "giá hiện tại";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_OldPrice
            // 
            this.lbl_OldPrice.AutoSize = true;
            this.lbl_OldPrice.Location = new System.Drawing.Point(736, 13);
            this.lbl_OldPrice.Name = "lbl_OldPrice";
            this.lbl_OldPrice.Size = new System.Drawing.Size(43, 16);
            this.lbl_OldPrice.TabIndex = 5;
            this.lbl_OldPrice.Text = "giá cũ";
            // 
            // lbl_HotelName
            // 
            this.lbl_HotelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HotelName.Location = new System.Drawing.Point(228, 13);
            this.lbl_HotelName.Name = "lbl_HotelName";
            this.lbl_HotelName.Size = new System.Drawing.Size(304, 23);
            this.lbl_HotelName.TabIndex = 6;
            this.lbl_HotelName.Text = "Tên khách sạn";
            // 
            // ratingStar
            // 
            this.ratingStar.BackColor = System.Drawing.Color.Transparent;
            this.ratingStar.BorderColor = System.Drawing.Color.Gold;
            this.ratingStar.Location = new System.Drawing.Point(397, 43);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.RatingColor = System.Drawing.Color.Yellow;
            this.ratingStar.Size = new System.Drawing.Size(120, 28);
            this.ratingStar.TabIndex = 7;
            // 
            // btn_TienIch1
            // 
            this.btn_TienIch1.Location = new System.Drawing.Point(232, 91);
            this.btn_TienIch1.Name = "btn_TienIch1";
            this.btn_TienIch1.Size = new System.Drawing.Size(175, 25);
            this.btn_TienIch1.TabIndex = 8;
            this.btn_TienIch1.Text = "Tiện ích 1";
            this.btn_TienIch1.UseVisualStyleBackColor = true;
            // 
            // btn_TienIch2
            // 
            this.btn_TienIch2.Location = new System.Drawing.Point(423, 91);
            this.btn_TienIch2.Name = "btn_TienIch2";
            this.btn_TienIch2.Size = new System.Drawing.Size(182, 25);
            this.btn_TienIch2.TabIndex = 8;
            this.btn_TienIch2.Text = "Tiện ích 2";
            this.btn_TienIch2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "4+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_TypeOf
            // 
            this.btn_TypeOf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TypeOf.BackColor = System.Drawing.Color.Transparent;
            this.btn_TypeOf.BorderRadius = 15;
            this.btn_TypeOf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TypeOf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TypeOf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TypeOf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TypeOf.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_TypeOf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TypeOf.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_TypeOf.Image = global::KhachSan.Properties.Resources.hotel;
            this.btn_TypeOf.Location = new System.Drawing.Point(231, 39);
            this.btn_TypeOf.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TypeOf.Name = "btn_TypeOf";
            this.btn_TypeOf.Size = new System.Drawing.Size(149, 32);
            this.btn_TypeOf.TabIndex = 2;
            this.btn_TypeOf.Text = "Loại hình";
            // 
            // btn_Rate
            // 
            this.btn_Rate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Rate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Rate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Rate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Rate.FillColor = System.Drawing.Color.Transparent;
            this.btn_Rate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Rate.Image = global::KhachSan.Properties.Resources.main_logo;
            this.btn_Rate.Location = new System.Drawing.Point(538, 0);
            this.btn_Rate.Name = "btn_Rate";
            this.btn_Rate.Size = new System.Drawing.Size(125, 45);
            this.btn_Rate.TabIndex = 2;
            this.btn_Rate.Text = "Đánh giá";
            // 
            // pictureBox_Hotel
            // 
            this.pictureBox_Hotel.Image = global::KhachSan.Properties.Resources.davue_front_img;
            this.pictureBox_Hotel.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Hotel.Name = "pictureBox_Hotel";
            this.pictureBox_Hotel.Size = new System.Drawing.Size(198, 101);
            this.pictureBox_Hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Hotel.TabIndex = 0;
            this.pictureBox_Hotel.TabStop = false;
            // 
            // btn_Edition
            // 
            this.btn_Edition.AnimatedGIF = true;
            this.btn_Edition.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edition.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Edition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edition.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Edition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Edition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Edition.ForeColor = System.Drawing.Color.White;
            this.btn_Edition.Location = new System.Drawing.Point(13, 91);
            this.btn_Edition.Name = "btn_Edition";
            this.btn_Edition.Size = new System.Drawing.Size(198, 25);
            this.btn_Edition.TabIndex = 9;
            this.btn_Edition.Text = "Sale sinh nhật";
            // 
            // UC_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Edition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_TienIch2);
            this.Controls.Add(this.btn_TienIch1);
            this.Controls.Add(this.ratingStar);
            this.Controls.Add(this.lbl_HotelName);
            this.Controls.Add(this.lbl_OldPrice);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.btn_ChooseRoom);
            this.Controls.Add(this.btn_TypeOf);
            this.Controls.Add(this.btn_Rate);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.pictureBox_Hotel);
            this.Name = "UC_Hotel";
            this.Size = new System.Drawing.Size(908, 148);
            this.Click += new System.EventHandler(this.UC_Hotel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Hotel;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btn_Rate;
        private Guna.UI2.WinForms.Guna2Button btn_ChooseRoom;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_OldPrice;
        private System.Windows.Forms.Label lbl_HotelName;
        private Guna.UI2.WinForms.Guna2Button btn_TypeOf;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar;
        private System.Windows.Forms.Button btn_TienIch1;
        private System.Windows.Forms.Button btn_TienIch2;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Edition;
    }
}
