namespace TestSelenium
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btOpenBrowser = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btOpenBrowser
            // 
            btOpenBrowser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btOpenBrowser.Location = new Point(271, 172);
            btOpenBrowser.Name = "btOpenBrowser";
            btOpenBrowser.Size = new Size(116, 39);
            btOpenBrowser.TabIndex = 0;
            btOpenBrowser.Text = "Open Browser";
            btOpenBrowser.UseVisualStyleBackColor = true;
            btOpenBrowser.Click += btOpenBrowser_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(177, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 29);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 352);
            Controls.Add(textBox1);
            Controls.Add(btOpenBrowser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btOpenBrowser;
        private TextBox textBox1;
    }
}