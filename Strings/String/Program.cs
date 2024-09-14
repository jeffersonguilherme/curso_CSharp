namespace String{
    class Program{
        static void Main(string[] args){
            var id = Guid.NewGuid();
            //id.Tostring();

            id = new Guid();
             Console.WriteLine(id);
        }
    }
}