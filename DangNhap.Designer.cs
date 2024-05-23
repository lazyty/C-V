namespace DOANLTMCB1
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            textBox_TenTaiKhoan = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox_MatKhau = new TextBox();
            linkLabel_QuenMatKhau = new LinkLabel();
            linkLabel_DangKy = new LinkLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TenTaiKhoan.Location = new Point(392, 498);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(300, 49);
            textBox_TenTaiKhoan.TabIndex = 0;
            textBox_TenTaiKhoan.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(470, 387);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(222, 498);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(222, 597);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MatKhau.Location = new Point(392, 597);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '*';
            textBox_MatKhau.Size = new Size(300, 49);
            textBox_MatKhau.TabIndex = 4;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel_QuenMatKhau.Location = new Point(222, 709);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(258, 37);
            linkLabel_QuenMatKhau.TabIndex = 5;
            linkLabel_QuenMatKhau.TabStop = true;
            linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu?";
            linkLabel_QuenMatKhau.LinkClicked += linkLabel_QuenMatKhau_LinkClicked;
            // 
            // linkLabel_DangKy
            // 
            linkLabel_DangKy.AutoSize = true;
            linkLabel_DangKy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel_DangKy.Location = new Point(589, 709);
            linkLabel_DangKy.Name = "linkLabel_DangKy";
            linkLabel_DangKy.Size = new Size(139, 37);
            linkLabel_DangKy.TabIndex = 6;
            linkLabel_DangKy.TabStop = true;
            linkLabel_DangKy.Text = "Đăng Ký";
            linkLabel_DangKy.LinkClicked += linkLabel_DangKy_LinkClicked;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(349, 794);
            button1.Name = "button1";
            button1.Size = new Size(231, 47);
            button1.TabIndex = 7;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 898);
            Controls.Add(button1);
            Controls.Add(linkLabel_DangKy);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(textBox_MatKhau);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_TenTaiKhoan);
            Name = "DangNhap";
            Text = "Form1";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_TenTaiKhoan;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox_MatKhau;
        private LinkLabel linkLabel_QuenMatKhau;
        private LinkLabel linkLabel_DangKy;
        private Button button1;
    }
}
