namespace Indice{
    class Program{
        static void Main(string[] args){
            var texto = "Este texto é um teste";
            //Console.WriteLine(texto.IndexOf("é"));
            //Console.WriteLine(texto.LastIndexOf("S", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(texto.ToLower());
            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto.Insert(texto.Length, "AQUI "));
            //Console.WriteLine(texto.Remove(5, 5));
            //Console.WriteLine(texto.Length + 1);

            Console.WriteLine(texto.Replace("e", "X"));

        }
    }
}