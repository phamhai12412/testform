namespace testform
{
    partial class FormTrang1
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
            btnTrang2 = new Button();
            btnTrang3 = new Button();
            SuspendLayout();
            // 
            // btnFormMain
            // 
            btnFormMain.Location = new Point(71, 120);
            btnFormMain.Name = "btnFormMain";
            btnFormMain.Size = new Size(75, 23);
            btnFormMain.TabIndex = 0;
            btnFormMain.Text = "FormMain";
            btnFormMain.UseVisualStyleBackColor = true;
            btnFormMain.Click += btnFormMain_Click;
            // 
            // btnTrang2
            // 
            btnTrang2.Location = new Point(240, 127);
            btnTrang2.Name = "btnTrang2";
            btnTrang2.Size = new Size(75, 23);
            btnTrang2.TabIndex = 1;
            btnTrang2.Text = "Trang2";
            btnTrang2.UseVisualStyleBackColor = true;
            btnTrang2.Click += btnTrang2_Click;
            // 
            // btnTrang3
            // 
            btnTrang3.Location = new Point(359, 134);
            btnTrang3.Name = "btnTrang3";
            btnTrang3.Size = new Size(75, 23);
            btnTrang3.TabIndex = 2;
            btnTrang3.Text = "Trang3";
            btnTrang3.UseVisualStyleBackColor = true;
            btnTrang3.Click += btnTrang3_Click;
            // 
            // FormTrang1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTrang3);
            Controls.Add(btnTrang2);
            Controls.Add(btnFormMain);
            Name = "FormTrang1";
            Text = "Trangchu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFormMain;
        private Button btnTrang2;
        private Button btnTrang3;
    }
}