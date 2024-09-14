namespace Estruturas {
    class Program {
        static void Main(string[] args){

           // struct Product {
          //      //Propriedades
          //      public int Id;
          //      public float Price;

                //Métodos
          //      public float PriceInDolar(float dolar){
          //          return Price * dolar;
         //       }
                
         //   }

        //Structs não não são funcções, então não podemos cria-los dentro do Main nem dentro de uma class
        //Eles competem com a classe

        Product mouse = new Product(1, "mouse gamer", 299.97, EProductType.Product);
        var manutencaoEletrica = new Product(2, "Manutenção Elétrica Residencial", 500, EProductType.Service);

        mouse.Name = "Maouse Escritorio";

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Price);
        Console.WriteLine((int)mouse.Type);

        }
    }

    struct Product {

        public Product(int id, string name, double price, EProductType type){
            Id = id;// Propriedade recebe parametro
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;//Maiucuslo Propriedade
        public EProductType Type;

        public double PriceInDolar(double dolar) {//Ninusculo parametro
            return Price * dolar;
        }
    }

    enum EProductType {
        Product = 1,
        Service = 2,
    }
}