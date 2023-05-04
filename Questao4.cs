class Questao4
{

    public static void Executar()
    {
        // Procedimento que recebe 3 valores        
        // o comprimento de cada lado < do o comprimento dos outros dois

        while (true)
        {
            Console.WriteLine("Digite 3 lados do triângulo separados por vírgula: ");
            string[] valores = Console.ReadLine().Split(',');

            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);
            double z = double.Parse(valores[2]);


            VerificaTriangulo(x, y, z);

            static void VerificaTriangulo(double x, double y, double z)
            {       
                if (x < y + z && y < x + z && z < x + y)
                // if (x < y + z || y < x + z || z < x + y)
                {
                    Console.WriteLine("Os valores formam um triangulo");

                    if (x == y && x == z)
                    {
                        Console.WriteLine("Triangulo Equilátero");
                    }
                    else if (x == y || x == z || y == z)
                    {
                        Console.WriteLine("Triangulo Isósceles");
                    }
                    else
                    {
                        Console.WriteLine("Triangulo Escaleno");
                    }

                }
                else
                {
                    Console.WriteLine("Os valores informados não formam um triangulo");
                }
                
            }
            Console.WriteLine("Digite 's' para continuar, ou qualquer outra tecla para sair");
            if (Console.ReadLine() != "s")
            {
                break;
            }

        }

    }


}

