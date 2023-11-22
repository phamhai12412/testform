using System;
using System.Windows.Forms;

namespace testform
{
    public partial class FormMain : Form
    {
       
        public event EventHandler BtnTrang1Click;
        public event EventHandler BtnTrang2Click;
        public event EventHandler BtnTrang3Click;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTrang1_Click(object sender, EventArgs e)
        {
            BtnTrang1Click?.Invoke(this, EventArgs.Empty);
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
