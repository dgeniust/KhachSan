namespace KhachSan
{
    partial class test
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Receive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Content = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người nhận";
            // 
            // txt_Receive
            // 
            this.txt_Receive.Location = new System.Drawing.Point(192, 151);
            this.txt_Receive.Name = "txt_Receive";
            this.txt_Receive.Size = new System.Drawing.Size(423, 22);
            this.txt_Receive.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Content";
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(192, 224);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(423, 208);
            this.txt_Content.TabIndex = 2;
            this.txt_Content.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Receive);
            this.Controls.Add(this.label1);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Receive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_Content;
        private System.Windows.Forms.Button button1;
    }
}