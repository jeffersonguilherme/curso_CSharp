namespace Variaveis { // divisão logica
    class Program { //Programa Propriamente dito
        static void Main(string[] args){//Metodo Principal
            
            string primeiroNome = "jef";
           // int idade;
           // int idade = 25;
           // var idade = 25;

           // const int idade_minima; // Correto inicia com ZERO
            const int idadeMinima = 25; //Correto incia com 25

            //int internal = 25;

            //Valores padrões
            //int => 0
            //float => 0
            //decimal => 0
            //bool => false
            //string => ""

            //Conversão 

            float valor = 25.8F;
            int outro = 25;
            valor = outro; 

            int inteiro = int.Parse("100");

            //Convert simlar ao parse visto anteriormente 
            //Porem permite converte varios tipo de valor
                //Não apenas string
            //Devemos iforma o tipo na chamada da conversão

            int inteiroConvert = Convert.ToInt32("100");
        }
    }
}