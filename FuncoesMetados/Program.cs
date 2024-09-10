
namespace FuncoesMetados{
    class Program {
        static void Main(string[] args){

           // MeuMetodo("C# é legal");

           // static void MeuMetodo(string paramentro){
           //     Console.WriteLine(paramentro);
           // }

           //static string RetornaNome(string nome, string sobrenome){
            //Retorna o nome e sobrenome
          //  return nome + " " + sobrenome;
         //  }

         //  Console.WriteLine(RetornaNome("jefferson","Silva"));
        MeuMetodo();

        string nome = RetornaNome("Jefferson ", "silva", 40);
        Console.WriteLine(nome);

        }

       static void MeuMetodo(){
        Console.WriteLine("C# é legal");
       }
        static string RetornaNome(
            string nome,
            string sobrenome,
            int idade = 30,
            bool teste = false,
            double novo = 33.42
            ){
            
            return nome + sobrenome + " tem " + idade.ToString();

        }

    }
}