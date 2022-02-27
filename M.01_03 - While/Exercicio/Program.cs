using System;

namespace Exercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exercicio 01
            Console.Clear();
            Console.Write("Digite um número positivo: ");
            int v = int.Parse(Console.ReadLine());
            while (v <= 0)
            {
                Console.Write("Digite um número positivo: ");
                v = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valor digitado ({0}), é possitivo.", v);
            Console.ReadKey();

            // Exercicio 02
            Console.Clear();
            Console.Write("Primeiro Valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float n2 = float.Parse(Console.ReadLine());
            while (n1 >= n2)
            {
                Console.Write("Segundo Valor: ");
                n2 = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tudo Ok");
            Console.ReadKey();

            // Exercicio 03
            Console.Write("Qual seu sexo (M para homens e F para mulher): ");
            char sex = char.Parse(Console.ReadLine().ToLower());
            while (sex != 'm' && sex != 'f')
            {
                Console.Write("Qual seu sexo (M para homens e F para mulher): ");
                sex = char.Parse(Console.ReadLine().ToLower());
            }
            Console.WriteLine("Muito obrigado(a)");
            Console.ReadKey();

            // Exercicio 04
            int index = 1;
            while (index <= 10)
            {
                int num = 5;
                int res = index * num;
                Console.WriteLine($"{index:D2} x {num:D2} = {res:D2}");
                index++;
            }
            Console.WriteLine("Feito!");
            Console.ReadKey();

            // Exercicio 05
            Console.Clear();
            Console.Write("Digite um número positivo: ");
            int num = int.Parse(Console.ReadLine());
            int index = 1;
            while (num <= 0)
            {
                char a = Convert.ToChar(num);
                a = Console.ReadKey().KeyChar;
            }
            while (index <= 10)
            {
                int res = index * num;
                Console.WriteLine($"{index:D2} x {num:D2} = {res:D2}");
                index++;
            }
            Console.WriteLine("Feito!");
            Console.ReadKey();

            // Exercicio 06
            Console.Clear();
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());
            while (x <= 0)
            {
                char y = Convert.ToChar(x);
                y = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("Digite o intervalo que deverá ser calculada a tabuada.");
            Console.Write("1°Intervalo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2°Intervalo: ");
            int b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                while (a <= b)
                {
                    int num = 5;
                    int res = b * num;
                    Console.WriteLine($"{b:D2} x {num:D2} = {res:D2}");
                    b--;
                }
                Console.WriteLine("Feito!");
            }
            else
            {
                while (b <= a)
                {
                    Console.Write("2°Intervalo: ");
                    b = int.Parse(Console.ReadLine());
                }
                while (a <= b)
                {
                    int num = 5;
                    int res = a * num;
                    Console.WriteLine($"{a:D2} x {num:D2} = {res:D2}");
                    a++;
                }
                Console.WriteLine("Feito!");
            }
            Console.ReadKey();

            // Exercicio 07
            Console.Clear();
            int tab = 1;
            while (tab <= 20)
            {
                int index = 1;
                while (index <= 10)
                {
                    int res = index * tab;
                    Console.WriteLine($"{index:D2} x {tab:D2} = {res:D2}");
                    index++;
                }
                tab++;
                Console.ReadKey();
                Console.Clear();
            }

            // Exercicio 08
            Console.Clear();
            int index = 1;
            int soma = 0;
            while (index <= 100)
            {
                soma += index;
                index++;
            }
            Console.WriteLine($"Valor total será: {soma}.");
            Console.ReadKey();

            // Exercicio 09
            Console.Clear();
            int numMin = 9999999;
            int numMax = 0;
            int index = 1;
            while (index <= 10)
            {
                Console.Write($"{index}° valor: ");
                int valor = int.Parse(Console.ReadLine());
                if (valor > numMax)
                {
                    numMax = valor;
                }
                if (valor < numMin)
                {
                    numMin = valor;
                }
                index++;
            }
            Console.WriteLine("-------------------------" +
                "-");
            Console.WriteLine($"Número maior: {numMax}.\nNúmero menor: {numMin}.");
            Console.ReadKey();

            // Exercicio 10
            Console.Clear();
            double fn;
            int index = 1;
            while (index <= 30)
            {
                fn = (Math.Pow(((1 + Math.Sqrt(5)) / 2), index) - Math.Pow(((1 - Math.Sqrt(5)) / 2), index)) / Math.Sqrt(5);
                Console.Write($"{fn:N0}" + " ");
                index++;
            }
            Console.ReadKey();

            // Exercício 11
            Console.Clear();
            int n, index;
            n = index = 0;
            float valor = 0;
            while (n <= 0 || n > 50)
            {
                Console.Write("Informe o valor (N): ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (index < n)
            {
                valor = index / (index + 1);
                index++;
            }
            Console.WriteLine($"A soma dos valores será {valor}.");
            Console.ReadKey();

            // Exercício 12
            int maior, menor, n, index;
            maior = menor = index = n = 0;
            while (index < 10)
            {
                Console.Write("Digite um valor: ");
                n = int.Parse(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                } 
                else if (n < menor)
                {
                    menor = n;
                }
                index++;
            }
            Console.WriteLine($"Maior valor: {maior} \nMenor valor: {menor}");
            Console.ReadKey();

            // Exercício 13
            int a, b;
            a = b = 0;
            while (a <= b)
            {
                while (a <= 0)
                {
                    Console.Write("Digite o primeiro valor: ");
                    a = int.Parse(Console.ReadLine());
                }
                while (b <= 0)
                {
                    Console.Write("Digite o segundo valor: ");
                     b = int.Parse(Console.ReadLine());
                }
            }
            while (a >= b)
            {
                a -= b; // a = a - b
            }
            Console.WriteLine("O resto da divisão será {0}.", a);
            Console.Clear();

            // Exercício 14
            float pesoM, pesoF;
            pesoM = pesoF = 0;
            int index = 0;
            while (index < 100)
            {
                Console.Write("Sexo (M ou F): ");
                char s = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Peso: ");
                float p = float.Parse(Console.ReadLine());
                if (s == 'm')
                {
                    pesoM += p;
                }
                else if (s == 'f')
                {
                    pesoF += p;
                }
                index++;
                Console.Clear();
            }
            Console.WriteLine($"Peso dos homens: {pesoM} \nPeso das mulhers: {pesoF}");
            Console.ReadKey();

            // Exercício 15
            int n, index, num, numMaior, numMenor, somaValores;
            float positivo, negativo;
            index = n = 0;
            positivo = negativo = 0;
            while (n <= 0 || n > 20)
            {
                Console.Write("Informe o valor (N): ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > 20)
                {
                    Console.WriteLine("ERRO");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            Console.Write("Valor: ");
            num = int.Parse(Console.ReadLine());
            numMaior = numMenor = somaValores = num;
            if (num >= 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }
            while ((index + 1) < n)
            {
                index++;
                Console.Write("Valor: ");

                num = int.Parse(Console.ReadLine());
                somaValores += num;
                if (num > numMaior)
                {
                    numMaior = num;
                } 
                else if (num < numMenor)
                {
                    numMenor = num;
                }

                if (num >= 0)
                {
                    positivo++;
                }
                else if (num < 0)
                {
                    negativo++;
                }
            }
            float porcetoPosi = (positivo / n) * 100;
            float porcetoNega = (negativo / n) * 100;
            Console.Clear();
            Console.WriteLine($"a) Maior valor: {numMaior}\nb) Menor valor: {numMenor}");
            Console.WriteLine($"c) Soma dos valores: {somaValores}");
            Console.WriteLine($"d) Porcentagem (Positivos): {porcetoPosi}%\ne) Porcentagem (Negativos): {porcetoNega}%");
            Console.ReadKey();
        }
    }
}
