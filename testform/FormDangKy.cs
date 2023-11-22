
using Microsoft.IdentityModel.Tokens;

namespace testform
{
    public partial class FormDangKy : Form
    {
        public event EventHandler DangKyThanhCongEvent;

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            // Use constants or variables with meaningful names
            const string validUsername = "1";
            const string validPassword = "1";

            if (taiKhoan == validUsername && matKhau == validPassword)
            {
                DangKyThanhCongEvent?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng kiểm tra thông tin đăng ký.");
            }
        }
    }
}
