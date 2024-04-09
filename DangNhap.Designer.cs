namespace KhachSan
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UC_Register = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UC_Login = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Control_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_Register1 = new KhachSan.UC_Register();
            this.uC_Login1 = new KhachSan.UC_Login();
            this.guna2Panel1.SuspendLayout();
            this.Control_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Register
            // 
            this.UC_Register.TargetControl = this.Control_Panel;
            // 
            // UC_Login
            // 
            this.UC_Login.TargetControl = this.Control_Panel;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(1, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(596, 657);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Control_Panel
            // 
            this.Control_Panel.Controls.Add(this.uC_Login1);
            this.Control_Panel.Controls.Add(this.uC_Register1);
            this.Control_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Control_Panel.Location = new System.Drawing.Point(595, 0);
            this.Control_Panel.Name = "Control_Panel";
            this.Control_Panel.Size = new System.Drawing.Size(715, 620);
            this.Control_Panel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KhachSan.Properties.Resources.login_photo3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 657);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // uC_Register1
            // 
            this.uC_Register1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Register1.Location = new System.Drawing.Point(0, 0);
            this.uC_Register1.Name = "uC_Register1";
            this.uC_Register1.Size = new System.Drawing.Size(715, 620);
            this.uC_Register1.TabIndex = 0;
            // 
            // uC_Login1
            // 
            this.uC_Login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Login1.Location = new System.Drawing.Point(0, 0);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(715, 620);
            this.uC_Login1.TabIndex = 1;
            this.uC_Login1.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 620);
            this.Controls.Add(this.Control_Panel);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.guna2Panel1.ResumeLayout(false);
            this.Control_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse UC_Register;
        private Guna.UI2.WinForms.Guna2Elipse UC_Login;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel Control_Panel;
        private UC_Register uC_Register1;
        private UC_Login uC_Login1;
    }
}