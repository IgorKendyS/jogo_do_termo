using TermoLib;

namespace TermoTest
{
    [TestClass]
    public sealed class TestTermo
    {
        [TestMethod]
        public void TestReadFile()
        {
            Termo termo = new Termo();
            termo.CarregaPalavras("palavras.txt");
            Console.WriteLine(String.Join("\n",termo.palavras));
        }

        [TestMethod]
        public void testJogo()
        {
            Termo termo = new Termo();
            imprimirJogo(termo);
            termo.ChecaPalavra("APOIO");
            imprimirJogo(termo);
        }

        public void imprimirJogo(Termo termo)
        {
            Console.WriteLine("PALAVRA SORTEADA: " + termo.palavraSorteada +"\n");
            Console.WriteLine("T A B U L E I R O");
            foreach (var palavra in termo.tabuleiro){
                foreach(var letra in palavra)
                {
                    Console.Write(letra.Caracter + ": " + letra.Cor + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("T E C L A D O");
            foreach (var tecla in termo.teclado)
            {
                Console.Write(tecla.Key + ": " + tecla.Value + " | ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
