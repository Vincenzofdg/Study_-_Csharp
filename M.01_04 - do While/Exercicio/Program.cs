using System;

namespace Exercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exercicio 01
            int index = 0;
            int soma = 0;
            do
            {
                index++;
                soma += index;
            } while (index < 99);
            Console.WriteLine("A somatoria será {0}", soma);
            Console.ReadKey();

            //// Exercicio 02
            int index = 0;
            int mult = 0;
            do
            {
                index++;
                mult = index * 5;
                Console.WriteLine("O {0}° multiplo de cinco será: {1}.", index, mult);
            } while (index < 100);
            Console.ReadKey();

            // Exercicio 03
            int razao = 1;
            int progAri = 0;
            do
            {
                razao += 2;
                progAri += razao;
                //Console.WriteLine(razao);
            } while (razao < 121);
            Console.WriteLine("A somatória dessa progressão será {0}.", progAri);
            Console.ReadKey();

            // Exercicio 04
            int razao = 12;
            do
            {
                razao -= 2;
                Console.WriteLine(razao);
            } while (razao > 0);
            Console.ReadKey();

            // Exercicio 05
            int index = 0, razao = 1, soma = 1;
            float somaFinal = 0, produtoFinal = 1;
            do
            {
                index++;
                somaFinal += Math.Pow(soma, -1);
                produtoFinal *= Math.Pow(soma, -1);
                razao += 2;
                soma += razao;
            } while (index < 5);
            Console.WriteLine("A somatoria será: {0}.", somaFinal);
            Console.WriteLine("O produto será: {0}.", produtoFinal);
            Console.ReadKey();

            //// Exercicio 06 = 07
            int a, b, mult, index;
            index = mult = a = 0;
            b = 1;
            while (a < b)
            {
                Console.Write("Digite um número: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite um outro número: ");
                b = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            do
            {
                index++;
                mult += a;
            } while (index < b);
            Console.WriteLine($"Resultado: {mult}");
            Console.ReadKey();


            // Exercicio 08
            int indexPrimo, index, indexCont, indexN, indexP;
            indexPrimo = indexCont = index = 0;
            do
            {
                indexN = indexP = 0;
                indexCont = index++;
                while (indexCont > 0)
                {
                    if (index % indexCont == 0)
                    {
                        indexP++;
                    }
                    else
                    {
                        indexN++;
                    }
                    indexCont--;
                }
                if (indexP == 1)
                {
                    indexPrimo++;
                    Console.WriteLine(index);
                }
            } while (indexPrimo < 20);
            Console.ReadKey();

            // Exercicio 09
            Console.Write("Digite um numero: ");
            float a = float.Parse(Console.ReadLine());
            float result = 0, resultResto = 0;
            do
            {
                result = a / 10;
                resultResto += a % 10;
                a = (int)result;
                Console.WriteLine(resultResto);
                Console.ReadKey();
            } while (result > 0);
            Console.WriteLine("A soma dos algorismos digitados será: {0}", resultResto);
            Console.ReadKey();

            // Exercicio 10
            int index = 0;
            float elev = 1;
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite a potencia deste número: ");
            int b = int.Parse(Console.ReadLine());
            do
            {
                index++;
                if (b < 0)
                {
                    elev *= 1 / (float) a;
                }
                else if (b > 0)
                {
                    elev *= a;
                }
                else
                {
                    elev = 1;
                }
            } while (index < b || index < -(b));
            Console.WriteLine($"Resultado: {elev}");
            Console.ReadKey();
        }
    }
}
