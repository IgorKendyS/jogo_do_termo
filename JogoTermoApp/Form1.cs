using TermoLib;

namespace JogoTermoApp
{
    public partial class Form1 : Form
    {
        private Termo termo;

        public Form1()
        {
            InitializeComponent();
            termo = new Termo();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var linha = termo.palavraAtual;
            var coluna = 1;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = button.Text;
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
