namespace testform
{
    partial class FormTrang2
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
            btnFormMain = new Button();
            btnTrang3 = new Button();
            btnTrang1 = new Button();
            SuspendLayout();
            // 
            // btnFormMain
            // 
            btnFormMain.Location = new Point(80, 169);
            btnFormMain.Name = "btnFormMain";
            btnFormMain.Size = new Size(75, 23);
            btnFormMain.TabIndex = 0;
            btnFormMain.Text = "FormMain";
            btnFormMain.UseVisualStyleBackColor = true;
            btnFormMain.Click += btnFormMain_Click;
            // 
            // btnTrang3
            // 
            btnTrang3.Location = new Point(191, 169);
            btnTrang3.Name = "btnTrang3";
            btnTrang3.Size = new Size(75, 23);
            btnTrang3.TabIndex = 1;
            btnTrang3.Text = "Trang3";
            btnTrang3.UseVisualStyleBackColor = true;
            btnTrang3.Click += btnTrang3_Click;
            // 
            // btnTrang1
            // 
            btnTrang1.Location = new Point(338, 179);
            btnTrang1.Name = "btnTrang1";
            btnTrang1.Size = new Size(75, 23);
            btnTrang1.TabIndex = 2;
            btnTrang1.Text = "Trang1";
            btnTrang1.UseVisualStyleBackColor = true;
            btnTrang1.Click += btnTrang1_Click;
            // 
            // FormTrang2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTrang1);
            Controls.Add(btnTrang3);
            Controls.Add(btnFormMain);
            Name = "FormTrang2";
            Text = "Trang2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFormMain;
        private Button btnTrang3;
        private Button btnTrang1;
    }
}