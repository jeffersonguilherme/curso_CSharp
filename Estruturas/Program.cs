namespace Estruturas {
    class Program {
        static void Main(string[] args){

            struct Product {
                //Propriedades
                public int Id;
                public float Price;

                //Métodos
                public float PriceInDolar(float dolar){
                    return Price * dolar;
                }
                
            }

        }
    }
}