using System.Text;

namespace Indice{
    class Program{
        static void Main(string[] args){

            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");            
            texto.Append(" é um teste");            
            texto.Append("Este texto ");                     
            texto.Append("Este um teste");            

            texto.ToString();
            Console.WriteLine(texto);
            
            //var texto = "Este texto é um teste";
            //Console.WriteLine(texto.IndexOf("é"));
            //Console.WriteLine(texto.LastIndexOf("S", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(texto.ToLower());
            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto.Insert(texto.Length, "AQUI "));
            //Console.WriteLine(texto.Remove(5, 5));
            //Console.WriteLine(texto.Length + 1);

            //Console.WriteLine(texto.Replace("e", "X"));
            //Console.WriteLine(texto.Replace("xxxxxxx", "X"));

           // var divisao = texto.Split(" ");
           // Console.WriteLine(divisao[0]);
           // Console.WriteLine(divisao[1]);
           // Console.WriteLine(divisao[2]);
           // Console.WriteLine(divisao[3]);
           // Console.WriteLine(divisao[4]);

           // var resultado = texto.Substring(5, 5);
           // var resultado2 = texto.Substring(5, texto.LastIndexOf("o"));
           // Console.WriteLine(resultado2);

           // Console.WriteLine(texto.Trim());
            
           
           //Console.WriteLine(texto);
        }
    }
}