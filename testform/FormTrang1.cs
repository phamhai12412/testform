using System;
using System.Windows.Forms;

namespace testform
{
    public partial class FormTrang1 : Form
    {
        public event EventHandler BtnFormMainClick;
        public event EventHandler BtnTrang2Click;
        public event EventHandler BtnTrang3Click;

        public FormTrang1()
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

        private void btnTrang3_Click(object sender, EventArgs e)
        {
            BtnTrang3Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
