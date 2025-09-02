namespace TermoLib
{
    public class Termo
    {
        public List<String> palavras;

        public void CarregaPalavras(string fileName)
        {
            palavras = File.ReadAllLines(fileName).ToList();
        }

    }
}
