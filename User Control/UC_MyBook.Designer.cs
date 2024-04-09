namespace KhachSan.User_Control
{
    partial class UC_MyBook
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
            this.lbl_HotelName = new System.Windows.Forms.Label();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.pictureBox_Room = new System.Windows.Forms.PictureBox();
            this.lbl_DateReceive = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_DateReturn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_HotelName
            // 
            this.lbl_HotelName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HotelName.Location = new System.Drawing.Point(238, 17);
            this.lbl_HotelName.Name = "lbl_HotelName";
            this.lbl_HotelName.Size = new System.Drawing.Size(348, 28);
            this.lbl_HotelName.TabIndex = 1;
            this.lbl_HotelName.Text = "Tên khách sạn";
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomName.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_RoomName.Location = new System.Drawing.Point(238, 60);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(348, 28);
            this.lbl_RoomName.TabIndex = 1;
            this.lbl_RoomName.Text = "Tên phòng";
            // 
            // pictureBox_Room
            // 
            this.pictureBox_Room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Room.Location = new System.Drawing.Point(13, 14);
            this.pictureBox_Room.Name = "pictureBox_Room";
            this.pictureBox_Room.Size = new System.Drawing.Size(219, 124);
            this.pictureBox_Room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Room.TabIndex = 0;
            this.pictureBox_Room.TabStop = false;
            // 
            // lbl_DateReceive
            // 
            this.lbl_DateReceive.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateReceive.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_DateReceive.Location = new System.Drawing.Point(592, 19);
            this.lbl_DateReceive.Name = "lbl_DateReceive";
            this.lbl_DateReceive.Size = new System.Drawing.Size(440, 28);
            this.lbl_DateReceive.TabIndex = 1;
            this.lbl_DateReceive.Text = "Ngày nhận";
            // 
            // lbl_Info
            // 
            this.lbl_Info.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Info.Location = new System.Drawing.Point(238, 101);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(466, 28);
            this.lbl_Info.TabIndex = 1;
            this.lbl_Info.Text = "Thông tin phòng";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderRadius = 5;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(848, 102);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(140, 36);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy phòng";
            // 
            // lbl_DateReturn
            // 
            this.lbl_DateReturn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateReturn.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_DateReturn.Location = new System.Drawing.Point(592, 60);
            this.lbl_DateReturn.Name = "lbl_DateReturn";
            this.lbl_DateReturn.Size = new System.Drawing.Size(440, 28);
            this.lbl_DateReturn.TabIndex = 1;
            this.lbl_DateReturn.Text = "Ngày trả";
            // 
            // UC_MyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_DateReturn);
            this.Controls.Add(this.lbl_DateReceive);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_RoomName);
            this.Controls.Add(this.lbl_HotelName);
            this.Controls.Add(this.pictureBox_Room);
            this.Name = "UC_MyBook";
            this.Size = new System.Drawing.Size(1035, 154);
            this.Load += new System.EventHandler(this.UC_MyBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Room;
        private System.Windows.Forms.Label lbl_HotelName;
        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.Label lbl_DateReceive;
        private System.Windows.Forms.Label lbl_Info;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private System.Windows.Forms.Label lbl_DateReturn;
    }
}
