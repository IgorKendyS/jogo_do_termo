namespace JogoTermoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Letter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // block non-letter characters
            }
        }

        private void Letter_TextChanged(object sender, EventArgs e)
        {
            TextBox current = sender as TextBox;

            if (current.Text.Length == 1)
            {
                if (current == letter_1) letter_2.Focus();
                else if (current == letter_2) letter_3.Focus();
                else if (current == letter_3) letter_4.Focus();
                else if (current == letter_4) letter_5.Focus();
                // letter_5 is last — do nothing
            }
        }
    }
}
