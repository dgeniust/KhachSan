using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace KhachSan.User_Control
{
    partial class UC_Discount
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
            this.txt_Content = new System.Windows.Forms.RichTextBox();
            this.btn_Take = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbl_Name.Location = new System.Drawing.Point(12, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(216, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Mã giảm giá";
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Content.ForeColor = System.Drawing.Color.Black;
            this.txt_Content.Location = new System.Drawing.Point(16, 35);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(187, 52);
            this.txt_Content.TabIndex = 1;
            this.txt_Content.Text = "Đây là mã giảm giá của khách sạn này";
            // 
            // btn_Take
            // 
            this.btn_Take.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Take.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Take.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Take.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Take.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_Take.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Take.ForeColor = System.Drawing.Color.White;
            this.btn_Take.Location = new System.Drawing.Point(209, 62);
            this.btn_Take.Name = "btn_Take";
            this.btn_Take.Size = new System.Drawing.Size(89, 25);
            this.btn_Take.TabIndex = 2;
            this.btn_Take.Text = "Lấy mã";
            this.btn_Take.Click += new System.EventHandler(this.btn_Take_Click);
            // 
            // UC_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Take);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.lbl_Name);
            this.Name = "UC_Discount";
            this.Size = new System.Drawing.Size(305, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.RichTextBox txt_Content;
        private Guna.UI2.WinForms.Guna2Button btn_Take;

        
    }
}
