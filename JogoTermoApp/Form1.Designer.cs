namespace JogoTermoApp
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
            letter_1 = new TextBox();
            letter_2 = new TextBox();
            letter_4 = new TextBox();
            letter_3 = new TextBox();
            letter_5 = new TextBox();
            SuspendLayout();
            // 
            // letter_1
            // 
            letter_1.Location = new Point(121, 62);
            letter_1.MaxLength = 1;
            letter_1.Name = "letter_1";
            letter_1.Size = new Size(24, 23);
            letter_1.TabIndex = 0;
            letter_1.TextChanged += Letter_TextChanged;
            letter_1.KeyPress += Letter_KeyPress;
            // 
            // letter_2
            // 
            letter_2.Location = new Point(166, 62);
            letter_2.MaxLength = 1;
            letter_2.Name = "letter_2";
            letter_2.Size = new Size(24, 23);
            letter_2.TabIndex = 1;
            letter_2.KeyPress += Letter_KeyPress;
            // 
            // letter_4
            // 
            letter_4.Location = new Point(261, 62);
            letter_4.MaxLength = 1;
            letter_4.Name = "letter_4";
            letter_4.Size = new Size(24, 23);
            letter_4.TabIndex = 3;
            letter_4.KeyPress += Letter_KeyPress;
            // 
            // letter_3
            // 
            letter_3.Location = new Point(216, 62);
            letter_3.MaxLength = 1;
            letter_3.Name = "letter_3";
            letter_3.Size = new Size(24, 23);
            letter_3.TabIndex = 2;
            letter_3.KeyPress += Letter_KeyPress;
            // 
            // letter_5
            // 
            letter_5.Location = new Point(304, 62);
            letter_5.MaxLength = 1;
            letter_5.Name = "letter_5";
            letter_5.Size = new Size(24, 23);
            letter_5.TabIndex = 4;
            letter_5.KeyPress += Letter_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(letter_5);
            Controls.Add(letter_4);
            Controls.Add(letter_3);
            Controls.Add(letter_2);
            Controls.Add(letter_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox letter_1;
        private TextBox letter_2;
        private TextBox letter_4;
        private TextBox letter_3;
        private TextBox letter_5;
    }
}
