namespace DOANLTMCB1
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            label1 = new Label();
            textBox_TenTaiKhoan = new TextBox();
            pictureBox2 = new PictureBox();
            textBox_MatKhau = new TextBox();
            label2 = new Label();
            textBox_NLMatKhau = new TextBox();
            label3 = new Label();
            textBox_Email = new TextBox();
            label4 = new Label();
            button_DangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 450);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản:";
            label1.Click += label1_Click;
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TenTaiKhoan.Location = new Point(412, 443);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(309, 44);
            textBox_TenTaiKhoan.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(470, 387);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MatKhau.Location = new Point(412, 516);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '*';
            textBox_MatKhau.Size = new Size(309, 44);
            textBox_MatKhau.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 523);
            label2.Name = "label2";
            label2.Size = new Size(167, 37);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu :";
            // 
            // textBox_NLMatKhau
            // 
            textBox_NLMatKhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NLMatKhau.Location = new Point(412, 590);
            textBox_NLMatKhau.Name = "textBox_NLMatKhau";
            textBox_NLMatKhau.PasswordChar = '*';
            textBox_NLMatKhau.Size = new Size(309, 44);
            textBox_NLMatKhau.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 597);
            label3.Name = "label3";
            label3.Size = new Size(287, 37);
            label3.TabIndex = 6;
            label3.Text = "Nhập lại mật khẩu:";
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Email.Location = new Point(412, 667);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(309, 44);
            textBox_Email.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 670);
            label4.Name = "label4";
            label4.Size = new Size(106, 37);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // button_DangKy
            // 
            button_DangKy.AutoSize = true;
            button_DangKy.BackColor = SystemColors.HotTrack;
            button_DangKy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_DangKy.ForeColor = SystemColors.ButtonFace;
            button_DangKy.Location = new Point(295, 748);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(199, 58);
            button_DangKy.TabIndex = 10;
            button_DangKy.Text = "Đăng Ký";
            button_DangKy.UseVisualStyleBackColor = false;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 867);
            Controls.Add(button_DangKy);
            Controls.Add(textBox_Email);
            Controls.Add(label4);
            Controls.Add(textBox_NLMatKhau);
            Controls.Add(label3);
            Controls.Add(textBox_MatKhau);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(label1);
            Name = "DangKy";
            Text = "DangKi";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox_TenTaiKhoan;
        private PictureBox pictureBox2;
        private TextBox textBox_MatKhau;
        private Label label2;
        private TextBox textBox_NLMatKhau;
        private Label label3;
        private TextBox textBox_Email;
        private Label label4;
        private Button button_DangKy;
    }
}