class Questao5
{
    public static void Executar(){
        Console.WriteLine("Resolução da Questão 5");
        int[] vetorAux = SorteiaNumeros();

        for (int i = 0; i < vetorAux.Length; i++)
        {
            Console.WriteLine(vetorAux[i]);
        }
        

    }

    static int[] SorteiaNumeros() {

        Random random = new Random();
        int[] numerosSorteados = new int[3];

        for (int i = 0; i < numerosSorteados.Length; i++)
        {
            numerosSorteados[i] = random.Next(10,51);
        }

        return numerosSorteados;
    }

}