namespace testform
{
    partial class FormTrang3
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
            btnTrang1 = new Button();
            SuspendLayout();
            // 
            // btnFormMain
            // 
            btnFormMain.Location = new Point(149, 123);
            btnFormMain.Name = "btnFormMain";
            btnFormMain.Size = new Size(75, 23);
            btnFormMain.TabIndex = 0;
            btnFormMain.Text = "FormMain";
            btnFormMain.UseVisualStyleBackColor = true;
            btnFormMain.Click += btnFormMain_Click;
            // 
            // btnTrang2
            // 
            btnTrang2.Location = new Point(296, 123);
            btnTrang2.Name = "btnTrang2";
            btnTrang2.Size = new Size(75, 23);
            btnTrang2.TabIndex = 1;
            btnTrang2.Text = "Trang2";
            btnTrang2.UseVisualStyleBackColor = true;
            btnTrang2.Click += btnTrang2_Click;
            // 
            // btnTrang1
            // 
            btnTrang1.Location = new Point(442, 123);
            btnTrang1.Name = "btnTrang1";
            btnTrang1.Size = new Size(75, 23);
            btnTrang1.TabIndex = 2;
            btnTrang1.Text = "Trang1";
            btnTrang1.UseVisualStyleBackColor = true;
            btnTrang1.Click += btnTrang1_Click;
            // 
            // FormTrang3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTrang1);
            Controls.Add(btnTrang2);
            Controls.Add(btnFormMain);
            Name = "FormTrang3";
            Text = "Trang3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFormMain;
        private Button btnTrang2;
        private Button btnTrang1;
    }
}