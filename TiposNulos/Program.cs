namespace TiposNulos {
    class Program {
        static void Main(string[] args){
        
        //void = vazio, não retorna nada
        //null serve definir um tipo, onde ele tem a possibilidade de ser nulo
        // int idade; (assume zero com vazio)
        //string nome = ""; assum vazio null =! vazio

        int? idade = 20;
        Console.WriteLine(idade);
        idade = null;
        Console.WriteLine(idade);
        idade = 25;
        Console.WriteLine(idade);

        }
    }
}