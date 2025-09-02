namespace TermoApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.letter_1 = new System.Windows.Forms.TextBox();
            this.letter_2 = new System.Windows.Forms.TextBox();
            this.letter_3 = new System.Windows.Forms.TextBox();
            this.letter_4 = new System.Windows.Forms.TextBox();
            this.letter_5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // letter_1
            // 
            this.letter_1.Location = new System.Drawing.Point(116, 65);
            this.letter_1.MaxLength = 1;
            this.letter_1.Name = "letter_1";
            this.letter_1.Size = new System.Drawing.Size(40, 20);
            this.letter_1.TabIndex = 0;
            this.letter_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // letter_2
            // 
            this.letter_2.Location = new System.Drawing.Point(178, 65);
            this.letter_2.MaxLength = 1;
            this.letter_2.Name = "letter_2";
            this.letter_2.Size = new System.Drawing.Size(40, 20);
            this.letter_2.TabIndex = 1;
            // 
            // letter_3
            // 
            this.letter_3.Location = new System.Drawing.Point(244, 65);
            this.letter_3.MaxLength = 1;
            this.letter_3.Name = "letter_3";
            this.letter_3.Size = new System.Drawing.Size(40, 20);
            this.letter_3.TabIndex = 2;
            // 
            // letter_4
            // 
            this.letter_4.Location = new System.Drawing.Point(306, 65);
            this.letter_4.MaxLength = 1;
            this.letter_4.Name = "letter_4";
            this.letter_4.Size = new System.Drawing.Size(40, 20);
            this.letter_4.TabIndex = 3;
            // 
            // letter_5
            // 
            this.letter_5.Location = new System.Drawing.Point(372, 65);
            this.letter_5.MaxLength = 1;
            this.letter_5.Name = "letter_5";
            this.letter_5.Size = new System.Drawing.Size(40, 20);
            this.letter_5.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.letter_5);
            this.Controls.Add(this.letter_4);
            this.Controls.Add(this.letter_3);
            this.Controls.Add(this.letter_2);
            this.Controls.Add(this.letter_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letter_1;
        private System.Windows.Forms.TextBox letter_2;
        private System.Windows.Forms.TextBox letter_3;
        private System.Windows.Forms.TextBox letter_4;
        private System.Windows.Forms.TextBox letter_5;
    }
}

