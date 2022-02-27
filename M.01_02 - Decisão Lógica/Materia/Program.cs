using System;

namespace Materia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Exemplo 01
            float p1, p2, media;
            Console.Clear();
            Console.Write("Valor da P1 : ");
            p1 = float.Parse(Console.ReadLine());
            Console.Write("Valor da P2 : ");
            p2 = float.Parse(Console.ReadLine());
            media = (p1 + p2) / 2;
            Console.WriteLine("Media do aluno : {0}", media);
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            Console.ReadKey();

            //Exemplo 02
            float p1, p2, media;
            Console.Clear();
            Console.Write("Valor da P1 : ");
            p1 = float.Parse(Console.ReadLine());
            Console.Write("Valor da P2 : ");
            p2 = float.Parse(Console.ReadLine());
            media = (p1 + p2) / 2;
            Console.WriteLine("Media do aluno : {0}", media);
            if (media >= 7.0)
            {
                //Console.Clear();
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                //Console.Clear();
                Console.WriteLine("Aluno Reprovado");
            }
            Console.ReadKey();

            ////Desafio em sala:(ax² + bx + c)
            Console.Clear();
            Console.Write("Defina o valor de 'a': ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Defina o valor de 'b': ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Defina o valor de 'c': ");
            float c = float.Parse(Console.ReadLine());
            if (a != 0.0)
            {
                double al = (Math.Pow(b, 2) - (4 * a * c));
                if (al < 0)
                {
                    Console.WriteLine("Não existe raiz real, logo equação não existe");
                }
                else
                {
                    double xp = (int)(-(b) + Math.Sqrt(al)) / (2 * a);
                    double xn = (int)(-(b) - Math.Sqrt(al)) / (2 * a);
                    Console.WriteLine("Por ter raiz real, teremos x+ = {0} e x- = {1}", xp, xn);
                }
            }
            else
            {
                double X = (-1) * (c / b);
                Console.WriteLine("Não forma uma equação de segundo grau com a = {0}, b = {1} e c = {2} teremos x = {3}", a, b, c, X);
            }
            Console.ReadKey();
        }
    }
}
