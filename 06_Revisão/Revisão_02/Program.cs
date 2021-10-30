using System;

namespace Revisão_02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Questao 01
            float soma = 0, produto = 0;
            int y = 2;
            for (int index = 1; index <= 4; index++)
            {
                soma += ((float)Math.Pow(index, 1) + y) / (float)Math.Pow(index, 2);
                produto *= ((float)Math.Pow(index, 1) + y) / (float)Math.Pow(index, 2);
                y += 2;
            }
            Console.WriteLine("A soma será: {0:f2}", soma);
            Console.ReadKey();

            //Questao 02
            int n;
            do
            {
                Console.Clear();
                Console.Write("Valor de N: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 5 || n > 100);
            for (int index = 1; index <= n; index++)
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(index, 2));
                }
            }
            Console.ReadKey();
        }
    }
}
