namespace Enums {
    class Program {
        static void Main(string[] args) {
            //Enums são enumeradores

           

            Console.WriteLine(Cliente.Nome)
        }
    }
    struct Cliente {
        public string Nome;

    }

     enum EEstadoCivil {
                Solteiro = 1;
                Casado = 2;
                Divorciado = 3;
            }
}