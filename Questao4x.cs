class Questao4x
{
    public static void Executar()
    {

        while (true)
        {

            Console.WriteLine("Entre com os valores separados por virgula");
            string[] valores = Console.ReadLine().Split(',');

            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);
            double z = double.Parse(valores[2]);

            ValidaTriangulo(x, y, z);

            Console.WriteLine("Digite 's' para continuar, ou qualquer outra tecla para sair");
            if (Console.ReadLine() != "s")
            {
                break;
            }

        }

        static void ValidaTriangulo(double x, double y, double z)
        {

            if (x < y + z && y < x + z && z < x + y)
            {
                Console.WriteLine("Os valores formam um triangulo");

                if (x == y && x == z)
                {
                    Console.WriteLine("Equilátero");
                }
                else if (x == y || x == z || y == z)
                {
                    Console.WriteLine("Isóselis");
                }
                else
                {
                    Console.WriteLine("Escaleno");
                }

            }
            else
            {
                Console.WriteLine("Os valores NÃO formam um triangulo");
            }



        }



    }

}