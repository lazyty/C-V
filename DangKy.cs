using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace DOANLTMCB1
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac) // checkk tai khoan va matkhau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em) //check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string nlmatkhau = textBox_NLMatKhau.Text;
            string email = textBox_Email.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập maạt khẩu dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (nlmatkhau != matkhau) { MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập lại email!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng kí, vui lòng sử dụng email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thôn báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult)
                {
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng đằng kí tên tài khoản khác!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
