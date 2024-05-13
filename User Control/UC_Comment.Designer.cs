namespace KhachSan.User_Control
{
    partial class UC_Comment
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.rs_Value = new Guna.UI2.WinForms.Guna2RatingStar();
            this.txt_Comment = new System.Windows.Forms.RichTextBox();
            this.pictureBox_i2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_i1 = new System.Windows.Forms.PictureBox();
            this.picturebox_User = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_i2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_i1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(70, 27);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(188, 23);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Nguyễn Văn A";
            // 
            // rs_Value
            // 
            this.rs_Value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rs_Value.BorderColor = System.Drawing.Color.Yellow;
            this.rs_Value.Location = new System.Drawing.Point(74, 63);
            this.rs_Value.Name = "rs_Value";
            this.rs_Value.RatingColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rs_Value.ReadOnly = true;
            this.rs_Value.Size = new System.Drawing.Size(120, 28);
            this.rs_Value.TabIndex = 3;
            this.rs_Value.Value = 4.2F;
            // 
            // txt_Comment
            // 
            this.txt_Comment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comment.Location = new System.Drawing.Point(574, 18);
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(672, 117);
            this.txt_Comment.TabIndex = 5;
            this.txt_Comment.Text = "Comment";
            // 
            // pictureBox_i2
            // 
            this.pictureBox_i2.Location = new System.Drawing.Point(409, 18);
            this.pictureBox_i2.Name = "pictureBox_i2";
            this.pictureBox_i2.Size = new System.Drawing.Size(122, 117);
            this.pictureBox_i2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_i2.TabIndex = 6;
            this.pictureBox_i2.TabStop = false;
            // 
            // pictureBox_i1
            // 
            this.pictureBox_i1.Location = new System.Drawing.Point(281, 18);
            this.pictureBox_i1.Name = "pictureBox_i1";
            this.pictureBox_i1.Size = new System.Drawing.Size(122, 117);
            this.pictureBox_i1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_i1.TabIndex = 6;
            this.pictureBox_i1.TabStop = false;
            // 
            // picturebox_User
            // 
            this.picturebox_User.Image = global::KhachSan.Properties.Resources.account;
            this.picturebox_User.ImageRotate = 0F;
            this.picturebox_User.Location = new System.Drawing.Point(19, 18);
            this.picturebox_User.Name = "picturebox_User";
            this.picturebox_User.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picturebox_User.Size = new System.Drawing.Size(45, 45);
            this.picturebox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_User.TabIndex = 1;
            this.picturebox_User.TabStop = false;
            // 
            // UC_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox_i2);
            this.Controls.Add(this.pictureBox_i1);
            this.Controls.Add(this.txt_Comment);
            this.Controls.Add(this.rs_Value);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.picturebox_User);
            this.Name = "UC_Comment";
            this.Size = new System.Drawing.Size(1287, 156);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_i2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_i1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox picturebox_User;
        private System.Windows.Forms.Label lbl_Name;
        private Guna.UI2.WinForms.Guna2RatingStar rs_Value;
        private System.Windows.Forms.RichTextBox txt_Comment;
        private System.Windows.Forms.PictureBox pictureBox_i1;
        private System.Windows.Forms.PictureBox pictureBox_i2;
    }
}
