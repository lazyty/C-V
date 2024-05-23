using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANLTMCB1
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label1.Text = "";
        }
        Modify modify = new Modify();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

   
     private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim()== "") { MessageBox.Show("Vui lòn nhập email đăng kí!"); }
            else
            {
                string query = "Select + from Taikhoan where Emaill = '"+email+"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label1.ForeColor = Color.Blue;
                    label1.Text = "Mật khẩu:" + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Email này chưa được đăng kí!";
                }
            }
        }

        private void textBox_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
