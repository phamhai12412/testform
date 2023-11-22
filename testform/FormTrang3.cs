using System;
using System.Windows.Forms;

namespace testform
{
    public partial class FormTrang3 : Form
    {
        public event EventHandler BtnFormMainClick;
        public event EventHandler BtnTrang2Click;
        public event EventHandler BtnTrang1Click;

        public FormTrang3()
        {
            InitializeComponent();
        }

        private void btnFormMain_Click(object sender, EventArgs e)
        {
            BtnFormMainClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnTrang2_Click(object sender, EventArgs e)
        {
            BtnTrang2Click?.Invoke(this, EventArgs.Empty);
        }

        private void btnTrang1_Click(object sender, EventArgs e)
        {
            BtnTrang1Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
