namespace File_Sorter
{
    partial class Form1
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
            this.Files2Convert = new System.Windows.Forms.ListBox();
            this.ConvertB = new System.Windows.Forms.Button();
            this.FilenumTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Files2Convert
            // 
            this.Files2Convert.AllowDrop = true;
            this.Files2Convert.FormattingEnabled = true;
            this.Files2Convert.Location = new System.Drawing.Point(27, 31);
            this.Files2Convert.Name = "Files2Convert";
            this.Files2Convert.Size = new System.Drawing.Size(700, 95);
            this.Files2Convert.TabIndex = 0;
            this.Files2Convert.SelectedIndexChanged += new System.EventHandler(this.Files2Convert_SelectedIndexChanged);
            // 
            // ConvertB
            // 
            this.ConvertB.Location = new System.Drawing.Point(298, 132);
            this.ConvertB.Name = "ConvertB";
            this.ConvertB.Size = new System.Drawing.Size(140, 23);
            this.ConvertB.TabIndex = 2;
            this.ConvertB.Text = "Convert";
            this.ConvertB.UseVisualStyleBackColor = true;
            this.ConvertB.Click += new System.EventHandler(this.ConvertB_Click);
            // 
            // FilenumTB
            // 
            this.FilenumTB.Location = new System.Drawing.Point(298, 162);
            this.FilenumTB.Name = "FilenumTB";
            this.FilenumTB.Size = new System.Drawing.Size(140, 20);
            this.FilenumTB.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Drag Files Here";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(298, 188);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(140, 23);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Clear All";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 262);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FilenumTB);
            this.Controls.Add(this.ConvertB);
            this.Controls.Add(this.Files2Convert);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Files2Convert;
        private System.Windows.Forms.Button ConvertB;
        private System.Windows.Forms.TextBox FilenumTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Clear;
    }
}

