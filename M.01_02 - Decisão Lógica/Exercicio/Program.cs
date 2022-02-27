using System;

namespace Exercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 01:
            Console.Clear();
            Console.Write("Valor de 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de 'b': ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("O valor {0} é maior.", a);
            } 
            else
            {
                Console.WriteLine("O valor {0} é maior.", b);
            }
            Console.ReadKey();

            //EXERCICIO 02:
            Console.Clear();
            Console.Write("Valor de 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de 'b': ");
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("O valor {0} é menor.", a);
            }
            else
            {
                Console.WriteLine("O valor {0} é menor.", b);
            }
            Console.ReadKey();

            //EXERCICIO 03:
            Console.Clear();
            Console.Write("Valor de 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de 'b': ");
            int b = int.Parse(Console.ReadLine());
            if (a != b)
            {
                if (a > b)
                {
                    Console.Write("O valor {0} é maior", a);
                } 
                else
                {
                    Console.Write("O valor {0} é maior", b);
                }
            }
            else
            {
                Console.WriteLine("Os valores são iguais");
            }            
            Console.ReadKey();

            //EXERCICIO 04:
            Console.Clear();
            Console.Write("Informe a base (b): ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Informe a altura (h): ");
            float h = float.Parse(Console.ReadLine());
            float A = b * h;
            if (A > 100)
            {
                Console.WriteLine("Terreno Grande!");
            }
            Console.ReadKey();

            //EXERCICIO 05:
            Console.Clear();
            Console.Write("Informe a base (b): ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Informe a altura (h): ");
            float h = float.Parse(Console.ReadLine());
            float A = b * h;
            if (A > 100)
            {
                Console.WriteLine("Terreno Grande!");
            } 
            else
            {
                Console.WriteLine("Terreno Pequeno!");
            }
            Console.ReadKey();

            //EXERCICIO 06:
            Console.Clear();
            Console.Write("Valor de 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Valor de 'b': ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Valor de 'c': ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("O valor {0} é maior.", a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("O valor {0} é maior.", b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("O valor {0} é maior.", c);
            }
            Console.ReadKey();

            //EXERCICIO 07:
            Console.Clear();
            Console.Write("Prova 01: ");
            float p1 = float.Parse(Console.ReadLine());
            Console.Write("Prova 02: ");
            float p2 = float.Parse(Console.ReadLine());
            int Mm = 5;
            float M = (p1 + 2 * p2) / 3;
            if (M >= Mm)
            {
                Console.WriteLine("Aluno aprovado com {0}", M);
            } 
            else
            {
                Console.WriteLine("Aluno reprovado com {0}", M);
            }
            Console.ReadKey();

            //EXERCICIO 08:
            Console.Clear();
            Console.Write("Prova 01: ");
            float p1 = float.Parse(Console.ReadLine());
            int M = 5;
            float p2 = (3 * M - p1) / 2;
            Console.WriteLine("O aluno deverá tirar {0} na segunda prova para passar", p2);
            Console.ReadKey();
        }
    }
}
