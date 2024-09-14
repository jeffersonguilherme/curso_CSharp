namespace ComparacaoString {
    class Program{
        static void Main(string[] args){
            //var texto = "Testando";
            var texto = "Este texto é um teste";

            //Se existe a palavra no texto

            //Console.WriteLine(texto.CompareTo("Testando"));//retorna um interiro, 0 para igual ou 1 para diferente
            //Console.WriteLine(texto.CompareTo("testando"));

            //Console.WriteLine(texto.Contains("teste"));
            //Console.WriteLine(texto.Contains("Teste"));
            //Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(texto.Contains(null)); retorna erro pois ta comparando objeto

            //StringComparison.OrdinalIgnoreCase ignorar o case sensitivi

            //Se Começa com a palavra

            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine("_____________________________");
            Console.WriteLine("");

            //Se termina com a palavra

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("texto"));

            Console.WriteLine("_____________________________");
            Console.WriteLine("");

            //Se todo o texto é igual

            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));

        }
    }
}