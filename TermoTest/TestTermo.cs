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
    }
}
