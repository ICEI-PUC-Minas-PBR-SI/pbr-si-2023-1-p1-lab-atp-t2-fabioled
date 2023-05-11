class Questao1
{   
    public static void Executar(){
        //Declarando Vetor de Inteiros de tamanho 20
        int[]N = new int[20];

        for (int i = 0; i < 20; i++){
            Console.WriteLine($"Entre com valor para N[{i}]");
            N[i] = int.Parse(Console.ReadLine());
        }

        int menor = N[0];
        int posicao = 0;

        for (int i = 0; i < 20; i++)
        {
            if (N[i] < menor ){
                menor = N[i];
                posicao = i;
            }
        }

        Console.WriteLine($"O menor elemento do Vetor N é {menor} e foi encontrado na posição {posicao}");
    }
    
}