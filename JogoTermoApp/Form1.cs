using TermoLib;

namespace JogoTermoApp
{
    public partial class Form1 : Form
    {
        private Termo termo;
        int coluna = 1; // controla o �ndice da coluna

        public Form1()
        {
            InitializeComponent();
            termo = new Termo();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (coluna > 5) return;
            // pega o valor do bot�o enviado (teclado virtual)
            var button = (Button)sender;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = RetornaBotao(nomeButton);
            buttonTabuleiro.Text = button.Text;
            coluna++;
        }

        private void Letter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // block non-letter characters
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var palavra = string.Empty;
            for (int i = 1; i <= 5; i++)
            {
                var nomeBotao = $"btn{termo.palavraAtual}{i}";
                var botao = RetornaBotao(nomeBotao);
                palavra += botao.Text;
            }
            termo.ChecaPalavra(palavra);
            AtualizaTabuleiro();
            AtualizaTeclado();
            coluna = 1;
            if (termo.jogoFinalizado)
            {
                MessageBox.Show("Parab�ns, palavra correta!", "Jogo termo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Button RetornaBotao(string name)
        {
            return (Button)Controls.Find(name, true)[0];
        }

        private void AtualizaTabuleiro()
        {
            for(int col = 1; col <= 5; col++)
            {
                var letra = termo.tabuleiro[termo.palavraAtual-2][col-1];
                var nomeBotaoTab = $"btn{termo.palavraAtual - 1}{col}";
                var botaoTab = RetornaBotao(nomeBotaoTab);
                var nomeBotaoKey = $"btn{letra.Caracter}";
                var botaoKey = RetornaBotao(nomeBotaoKey);
                if(letra.Cor == 'A')
                {
                    botaoTab.BackColor = Color.Gold;
                    if(botaoKey.BackColor != Color.Green)
                    {
                        botaoKey.BackColor = Color.Gold;
                    }
                }
                else if(letra.Cor == 'V'){
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

        private void AtualizaTeclado()
        {
            
        }
    }
}
