using System;

namespace Exercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exercicio 01
            int n;
            do
            {
                Console.Write("Informe o valor (N): ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n >= 20)
                {
                    Console.WriteLine("[ERRO]Valor não válido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (n <= 0 || n >= 20);
            float valor = 0;
            for (int index = 0; index < n;)            
            {
                valor += ++index / (float)(index + 1);
            }
            Console.WriteLine("A soma será {0:F2}.", valor);
            Console.ReadKey();

            //Exercicio 02
            int n;
            float soma = 0;
            do
            {
                Console.Clear();
                Console.Write("Quantidade de termos a ser somada: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n >= 50)
                {
                    Console.WriteLine("[ERRO]Digite o valor novamente!");
                    Console.ReadKey();
                }
            } while (n <= 0 || n >= 50);
            for (int index = 1; index <= n; index++)
            {
                soma += ((float)Math.Pow(index, 2) + 1) / (float)Math.Pow(index, 3);
            }
            Console.WriteLine("A soma será: {0:F3}", soma);           
            Console.ReadKey();

            /*
                        3----------- 5----------- 7
                               2 --------- 2
            --------------------------------------------------
                        7 ---------- 19---------- 37
                             12 ---------- 18
                                      6
            */

            // Exercicio 03
            int filho = 0, porcentCont = 0, hab = 500;
            float saSoma = 0, saMaior = -1, porcent, saNum, saMedia, filhoMedia;
            for (int index = 1; index <= hab; index++)
            {
                do
                {
                    Console.Write("{0}° Salário: ", index);
                    saNum = float.Parse(Console.ReadLine());
                } while (saNum <= 0);
                saSoma += saNum;
                if (saNum > saMaior)
                {
                    saMaior = saNum;
                }
                if (saNum <= 1000)
                {
                    porcentCont++; 
                }
                int filhoNum = 0;
                Console.Write("   Número de filhos: ");
                filhoNum = int.Parse(Console.ReadLine());
                filho += filhoNum;
            }
            Console.WriteLine("a) Média dos salários R$ {0:f2}", saMedia = saSoma / hab);
            Console.WriteLine("b) Média de filhos: {0:f2}", filhoMedia = (float)filho / hab);
            Console.WriteLine("c) O maior salário R$ {0:f2}", saMaior);
            Console.WriteLine("d) Porcentagem de sálarios: {0:f2}%", porcent = 100 * ((float)porcentCont / hab));
            Console.ReadKey();

            // Exercicio 04 - Solução com if()
            float compra, pago, troco, moeda = 0;
            Console.Write("Valor da compra: ");
            compra = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Valor pago: ");
                pago = float.Parse(Console.ReadLine());
            } while (pago < compra);
            troco = pago - compra;
            for (int index = 1; index <= 6; index++)
            {
                if (troco > 0)
                {
                    if (index == 1) moeda = 1.00f;
                    else if (index == 2) moeda = 0.50f;
                    else if (index == 3) moeda = 0.25f;
                    else if (index == 4) moeda = 0.10f;
                    else if (index == 5) moeda = 0.05f;
                    else moeda = 0.01f;

                    int moedaQuantidade = 0;
                    if (troco >= moeda)
                    {
                        moedaQuantidade = (int)(troco / moeda);
                        Console.WriteLine("Serão necessarias {0:d2} moeda(s) de R$ {1:f2}", moedaQuantidade, moeda);
                        troco = (float)Math.Round(troco - (moeda *moedaQuantidade), 2); // Math.Round arredondamento.
                    }
                }
            }
            Console.ReadKey();

            // Exercicio 04 - Solução com switch
             float compra, pago, troco, moeda;
             int moedaIdentificador = 0, moedaQuantidade = 0;
             Console.Write("Digite o valor da compra: ");
             compra = float.Parse(Console.ReadLine());
             do
             {
                 Console.Write("Digite o valor da pago: "); 
                 pago = float.Parse(Console.ReadLine());
             } while (pago < compra) ;
             troco = pago - compra;
             moeda = 0;
             while (troco > 0)
             {
                 moedaIdentificador++;
                 switch (moedaIdentificador)
                 {
                     case 1: moeda = 1.00f; break;
                     case 2: moeda = 0.50f; break;
                     case 3: moeda = 0.25f; break;
                     case 4: moeda = 0.10f; break;
                     case 5: moeda = 0.05f; break;
                     case 6: moeda = 0.01f; break;
                     }
                 if (troco >= moeda)
                 {
                     moedaQuantidade = (int)(troco / moeda);
                     Console.WriteLine("Serão necessarias {0:d2} moeda(s) de R$ {1:f2}", moedaQuantidade, moeda);
                     troco = (float)Math.Round(troco - (moeda * moedaQuantidade), 2);
                 }
            }
            Console.ReadKey();

            // Exercicio 05
            float aplica;
            do
            {
                Console.Write("Valor da aplicação: ");
                aplica = float.Parse(Console.ReadLine());
            } while (aplica <= 0);
            for (int mes = 1; mes <= 11; mes++)
            {
                aplica += (aplica * 0.05f);
            }
            Console.WriteLine("Em 11 meses o valor será R$ {0:f2}", aplica);
            Console.ReadKey();
        }
    }
}
