class Questao2
{
    public static void Executar(){
        Console.WriteLine("Resolução Questão 2");
        double salarioAcumulado = 0;
        int cont = 0;

        leituraDados();
        Console.WriteLine("A média do salário é: " + 
                CalculaMediaSalarial(salarioAcumulado, cont));

       // Funções auxiliares, poderia estar em um arquivo separado
        void leituraDados(){
            double salario = 0;        
            int qtdFilhos = 0;          
            string continua = "s";

            do{
               Console.WriteLine("Entre com o salário");
               salario = double.Parse(Console.ReadLine()); 
               salarioAcumulado = salarioAcumulado + salario;

               Console.WriteLine("Entre com a quantidade de Filhos");
               qtdFilhos = int.Parse(Console.ReadLine());
               cont++;
                
                Console.WriteLine("Deseja cadastrar S para Sim ou N para Não");
                continua = Console.ReadLine();

            } while (continua == "s");
        }
        //função para calcular a média
        static double CalculaMediaSalarial(Double salSomado, int qtdPessoas){

            double media = salSomado / qtdPessoas;   

            return media;
        }
        


    }
}