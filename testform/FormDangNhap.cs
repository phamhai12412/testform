using System;
using System.Windows.Forms;
using testform;

namespace testform
{
    public partial class FormDangNhap : Form
    {
        public event EventHandler DangNhapThanhCongEvent;
        public event EventHandler DangKyEvent;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            if (taiKhoan == "hai" && matKhau == "123")
            {
               
                DangNhapThanhCongEvent?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DangKyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
