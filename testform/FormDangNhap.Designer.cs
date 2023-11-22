namespace testform
{
    partial class FormDangNhap
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
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnDangKi = new Button();
            SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(361, 100);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(100, 23);
            txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(361, 143);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(100, 23);
            txtMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(294, 193);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnDangKi
            // 
            btnDangKi.Location = new Point(426, 193);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(75, 23);
            btnDangKi.TabIndex = 3;
            btnDangKi.Text = "Đăng ký";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKi);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnDangKi;
    }
}