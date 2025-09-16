using TermoLib;

namespace JogoTermoApp
{
    public partial class TermoJogo : Form
    {
        private Termo termo;
        int coluna = 1; // controla o índice da coluna

        public TermoJogo()
        {
            InitializeComponent();
            termo = new Termo();
        }

        private void TermoJogo_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (coluna > 5) return;
            // pega o valor do botão enviado (teclado virtual)
            var button = (Button)sender;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = RetornaBotao(nomeButton);
            buttonTabuleiro.Text = button.Text;
            coluna++;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (coluna <= 1) return;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna - 1}";
            var buttonTabuleiro = RetornaBotao(nomeButton);
            buttonTabuleiro.Text = "";
            coluna--;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var palavra = string.Empty;
            for (int i = 1; i <= 5; i++)
            {
                var nomeBotao = $"btn{termo.palavraAtual}{i}";
                var botao = RetornaBotao(nomeBotao);
                var letter = botao.Text;
                if (letter == string.Empty) return;
                palavra += letter;
            }
            termo.ChecaPalavra(palavra);
            AtualizaTabuleiro();
            coluna = 1;
            if (termo.jogoFinalizado)
            {
                MessageBox.Show("Parabéns, palavra correta!", "Jogo termo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Button RetornaBotao(string name)
        {
            return (Button)Controls.Find(name, true)[0];
        }

        private void AtualizaTabuleiro()
        {
            for (int col = 1; col <= 5; col++)
            {
                var letra = termo.tabuleiro[termo.palavraAtual - 2][col - 1];
                var nomeBotaoTab = $"btn{termo.palavraAtual - 1}{col}";
                var botaoTab = RetornaBotao(nomeBotaoTab);
                var nomeBotaoKey = $"btn{letra.Caracter}";
                var botaoKey = RetornaBotao(nomeBotaoKey);
                if (letra.Cor == 'A')
                {
                    botaoTab.BackColor = Color.Gold;
                    if (botaoKey.BackColor != Color.Green)
                    {
                        botaoKey.BackColor = Color.Gold;
                    }
                }
                else if (letra.Cor == 'V')
                {
                    botaoTab.BackColor = Color.Green;
                    botaoKey.BackColor = Color.Green;
                }
                else
                {
                    botaoTab.BackColor = Color.Gray;
                    botaoKey.BackColor = Color.Gray;
                }
            }
        }

        private void TermoJogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                btnBackspace_Click(null, null);
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(null, null);
                return;
            }

            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                string keyChar = e.KeyCode.ToString();

                var buttonName = $"btn{keyChar}";
                var virtualKeyButton = RetornaBotao(buttonName);

                if (virtualKeyButton != null)
                {
                    btnM_Click(virtualKeyButton, null);
                }
            }
        }

    }
}
