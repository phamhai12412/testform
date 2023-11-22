namespace testform
{
    partial class FormMain
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
            btnTrang1 = new Button();
            btnTrang2 = new Button();
            btnTrang3 = new Button();
            SuspendLayout();
            // 
            // btnTrang1
            // 
            btnTrang1.Location = new Point(56, 76);
            btnTrang1.Name = "btnTrang1";
            btnTrang1.Size = new Size(75, 23);
            btnTrang1.TabIndex = 0;
            btnTrang1.Text = "Trang1";
            btnTrang1.UseVisualStyleBackColor = true;
            btnTrang1.Click += btnTrang1_Click;
            // 
            // btnTrang2
            // 
            btnTrang2.Location = new Point(197, 82);
            btnTrang2.Name = "btnTrang2";
            btnTrang2.Size = new Size(75, 23);
            btnTrang2.TabIndex = 1;
            btnTrang2.Text = "Trang2";
            btnTrang2.UseVisualStyleBackColor = true;
            btnTrang2.Click += btnTrang2_Click;
            // 
            // btnTrang3
            // 
            btnTrang3.Location = new Point(331, 89);
            btnTrang3.Name = "btnTrang3";
            btnTrang3.Size = new Size(75, 23);
            btnTrang3.TabIndex = 2;
            btnTrang3.Text = "Trang3";
            btnTrang3.UseVisualStyleBackColor = true;
            btnTrang3.Click += btnTrang3_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTrang3);
            Controls.Add(btnTrang2);
            Controls.Add(btnTrang1);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTrang1;
        private Button btnTrang2;
        private Button btnTrang3;
    }
}