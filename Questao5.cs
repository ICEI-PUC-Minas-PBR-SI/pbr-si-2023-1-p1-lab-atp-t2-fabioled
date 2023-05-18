class Questao5
{
  
    public static void Executar(){

       
        Console.WriteLine("Resolução da Questão 5");
        int num ; 
        int[] vetorAux = SorteiaNumeros();
        
        while(true) {
            Console.WriteLine("Tente adivinhar o numero!");
            num = int.Parse(Console.ReadLine());

            if(Tentativa(vetorAux, num) == true) {
                Console.WriteLine("Encontrei");
                break;
            } else {
               Console.WriteLine("Não Encontrei");
            }
            
        }
           

    }
    // função que gera vetor com 3 nums aleatórios
    static int[] SorteiaNumeros() {
        
        Random random = new Random();
        int[] numerosSorteados = new int[3];

        for (int i = 0; i < numerosSorteados.Length; i++)
        {
            numerosSorteados[i] = random.Next(10,51);
        }

        return numerosSorteados;
    }

    //procedimento que testa se o usuário consegue acertar os numeros

    static bool Tentativa(int[]numeros, int numeroLido){

       foreach (int item in numeros)
       {
            if (numeroLido == item){                 
                return true;              
            } 
       }
        return false;
    }

}