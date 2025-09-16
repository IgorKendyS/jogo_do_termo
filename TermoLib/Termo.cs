namespace TermoLib
{
    public class Letra
    {
        public Letra(char caracter, char cor)
        {
            Caracter = caracter;
            Cor = cor;
        }
        public char Caracter;
        public char Cor;
    }
    public class Termo
    {
        public List<String> palavras;
        public string palavraSorteada;
        public List<List<Letra>> tabuleiro;
        public Dictionary<char, char> teclado;
        public int palavraAtual;
        public bool jogoFinalizado = false;

        public Termo()
        {
            CarregaPalavras("palavras.txt");
            SorteiaPalavra();
            palavraAtual = 1;
            tabuleiro = new List<List<Letra>>();
            teclado = new Dictionary<char, char>();
            for (int i = 65; i <= 90; i++)
            {
                // V - posicao correta | A - Na Palavra | P - Nao esta na palavra
                teclado.Add((char)i, 'C');
            }
        }

        public void CarregaPalavras(string fileName)
        {
            palavras = File.ReadAllLines(fileName).ToList();
        }
        public void SorteiaPalavra()
        {
            Random rand = new Random();
            var index = rand.Next(0, palavras.Count() - 1);
            palavraSorteada = palavras[index];
        }

        public void ChecaPalavra(string palavra)
        {
            if (palavra == palavraSorteada)
            {
                jogoFinalizado = true;
            }
            if (palavra.Length != 5)
            {
                return;
                throw new Exception("A palavra deve ter 5 letras");
            }
            var palavraTabuleiro = new List<Letra>();
            var greenLetters = new List<int>();
            char cor;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == palavraSorteada[i]){
                    cor = 'V';
                    greenLetters.Add(i);
                }
                /*string wordWithoutGreenLetters = new string(palavraSorteada.Where((ch, index) => !greenLetters.Contains(index)).ToArray());
                    if (wordWithoutGreenLetters.Contains(palavra[i]))*/
                else if (palavraSorteada.Contains(palavra[i]))
                {
                    cor = 'A';
                }
                else
                {
                    cor = 'P';
                }
                palavraTabuleiro.Add(new Letra(palavra[i], cor));
            }
            tabuleiro.Add(palavraTabuleiro);
            palavraAtual++;
        }
        
    }
}
