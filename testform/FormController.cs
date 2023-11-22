
namespace testform
{
    public class FormController
    {
        private FormMain formMain;
        private FormDangNhap formDangNhap;
        private FormDangKy formDangKy;
        private FormTrang1 formTrang1;
        private FormTrang2 formTrang2;
        private FormTrang3 formTrang3;

        public FormController()
        {
            formMain = new FormMain();
            formDangNhap = new FormDangNhap();
            formDangKy = new FormDangKy();
            formTrang1 = new FormTrang1();
            formTrang2 = new FormTrang2();
            formTrang3 = new FormTrang3();

            formDangNhap.DangNhapThanhCongEvent += FormDangNhap_DangNhapThanhCongEvent;
            formDangNhap.DangKyEvent += FormDangNhap_DangKyEvent;
            formDangKy.DangKyThanhCongEvent += FormDangKy_DangKyThanhCongEvent;

            formMain.BtnTrang1Click += FormMain_BtnTrang1Click;
            formMain.BtnTrang2Click += FormMain_BtnTrang2Click;
            formMain.BtnTrang3Click += FormMain_BtnTrang3Click;

            formTrang1.BtnFormMainClick += FormTrang1_BtnFormMainClick;
            formTrang1.BtnTrang2Click += FormTrang1_BtnTrang2Click;
            formTrang1.BtnTrang3Click += FormTrang1_BtnTrang3Click;

            formTrang2.BtnTrang1Click += FormTrang2_BtnTrang1Click;
            formTrang2.BtnTrang3Click += FormTrang2_BtnTrang3Click;
            formTrang2.BtnFormMainClick += FormTrang2_BtnFormMainClick;

            formTrang3.BtnFormMainClick += FormTrang3_BtnFormMainClick;
            formTrang3.BtnTrang2Click += FormTrang3_BtnTrang2Click;
            formTrang3.BtnTrang1Click += FormTrang3_BtnTrang1Click;
        }

        public void Run()
        {
            formDangNhap.Show();
            Application.Run(formDangNhap);
        }

        private void FormDangNhap_DangNhapThanhCongEvent(object sender, EventArgs e)
        {
            formDangNhap.Hide();
            formMain.Show();
        
        }

        private void FormDangNhap_DangKyEvent(object sender, EventArgs e)
        {
            formDangNhap.Hide();
            formDangKy.Show();
          
        }

        private void FormDangKy_DangKyThanhCongEvent(object sender, EventArgs e)
        {
            formDangKy.Hide();
            formDangNhap.Show();
        }

        private void FormMain_BtnTrang1Click(object sender, EventArgs e)
        {
            formMain.Hide();
            formTrang1.Show();
        }

        private void FormMain_BtnTrang2Click(object sender, EventArgs e)
        {
            formMain.Hide();
            formTrang2.Show();
        }

        private void FormMain_BtnTrang3Click(object sender, EventArgs e)
        {
            formMain.Hide();
            formTrang3.Show();
        }

        private void FormTrang1_BtnFormMainClick(object sender, EventArgs e)
        {
            formTrang1.Hide();
            formMain.Show();
        }

        private void FormTrang1_BtnTrang2Click(object sender, EventArgs e)
        {
            formTrang1.Hide();
            formTrang2.Show();
        }

        private void FormTrang1_BtnTrang3Click(object sender, EventArgs e)
        {
            formTrang1.Hide();
            formTrang3.Show();
        }

        private void FormTrang2_BtnTrang1Click(object sender, EventArgs e)
        {
            formTrang2.Hide();
            formTrang1.Show();
        }

        private void FormTrang2_BtnTrang3Click(object sender, EventArgs e)
        {
            formTrang2.Hide();
            formTrang3.Show();
        }

        private void FormTrang2_BtnFormMainClick(object sender, EventArgs e)
        {
            formTrang2.Hide();
            formMain.Show();
        }

        private void FormTrang3_BtnFormMainClick(object sender, EventArgs e)
        {
            formTrang3.Hide();
            formMain.Show();
        }

        private void FormTrang3_BtnTrang2Click(object sender, EventArgs e)
        {
            formTrang3.Hide();
            formTrang2.Show();
        }

        private void FormTrang3_BtnTrang1Click(object sender, EventArgs e)
        {
            formTrang3.Hide();
            formTrang1.Show();
        }
    }
}
