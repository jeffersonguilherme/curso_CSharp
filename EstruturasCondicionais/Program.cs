
namespace EstruturasCondicionais {
    class Program {
        static void Main(string[] args){

            int idade = 18;
            int maiorIdade = 21;
            int idadeMaxima = 65;

        //  if(idade >= maiorIdade && idade < idadeMaxima)
        //  if(idade >= maiorIdade || idade < idadeMaxima)
        //  if(idade >= maiorIdade != idade < idadeMaxima)
        //    if(!(idade >= maiorIdade))
            if(idade <= maiorIdade)
                 Console.WriteLine("Sim");
            else{
                Console.WriteLine("Não");
            }

        }
    }
}
