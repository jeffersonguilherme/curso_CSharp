namespace TiposPrimitivos { 
    class Program {
        static void Main(string[] args){
            
            byte meuByte = 127;
            int idade = 25;
            float salario = 2.500f;
            double salarioSemestral = 22.000;// tipo padrão caso coloque var (valor intermediario)
            decimal salarioAnual = 25.000m;

            bool  usuarioJaCadastrado = false;
            bool pogamentoRecebido = true;
            var usuarioExpirado = false; //converte para bool o tipo

        //  char primeiraLetra = ""; //sempre aspas simples
            char primeiroLetra = 'C';
            var segundaLetra = 'D';

            string primeiraLetraString = "C"; //Cadeia de caracteres " "
            string texto = "Meu texto";
            var documento = "112233311";

            //var substitui o nome de um tipo, sera o primeiro tipo valor atribuido
            var idadeVar = 25;
            IEnumerable<MeuTipoComplexo> aluno = new IEnumerable<MeuTipoComplexo>();
            var aluno = new IEnumerable<MeuTipoComplexo>();
        }
    }
}