using System;
using System.Windows.Forms;

namespace testform
{
    public partial class FormTrang2 : Form
    {
        public event EventHandler BtnTrang1Click;
        public event EventHandler BtnTrang3Click;
        public event EventHandler BtnFormMainClick;

        public FormTrang2()
        {
            InitializeComponent();
        }

        private void btnTrang1_Click(object sender, EventArgs e)
        {
            BtnTrang1Click?.Invoke(this, EventArgs.Empty);
        }

        private void btnTrang3_Click(object sender, EventArgs e)
        {
            BtnTrang3Click?.Invoke(this, EventArgs.Empty);
        }

        private void btnFormMain_Click(object sender, EventArgs e)
        {
            BtnFormMainClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
