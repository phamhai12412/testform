namespace testform
{
    partial class FormDangKy
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
            btnDangKy = new Button();
            SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(391, 67);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(100, 23);
            txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(391, 109);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(100, 23);
            txtMatKhau.TabIndex = 1;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(407, 149);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(75, 23);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "button1";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Name = "FormDangKy";
            Text = "FormDangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangKy;
    }
}