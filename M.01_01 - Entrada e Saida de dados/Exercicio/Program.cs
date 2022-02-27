using System;

namespace Exercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Exercicio 01
            float b, h, A;
            Console.Clear();
            Console.Write("base (b): ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Altura (h): ");
            h = float.Parse(Console.ReadLine());
            A = (int)b * h;
            Console.WriteLine("Área (A): {0}", A);
            Console.ReadKey();

            //Exercicio 02
            double l, A;
            Console.Clear();
            Console.Write("Lateral (l): ");
            l = double.Parse(Console.ReadLine());
            A = Math.Pow(l, 2);
            Console.WriteLine("Área (A): {0}", A);
            Console.ReadKey();

            //Exercicio 03
            float d, A;
            Console.Clear();
            Console.Write("Diagonal (d): ");
            d = float.Parse(Console.ReadLine());
            A = (int)(d * d) / 2;
            Console.WriteLine("Área (A): {0}", A);
            Console.ReadKey();

            //Exercicio 04
            float b, h, A;
            Console.Clear();
            Console.Write("base (b): ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Altura (h): ");
            h = float.Parse(Console.ReadLine());
            A = (b * h) / 2;
            Console.WriteLine("Área (A): {0}", A);
            Console.ReadKey();

            //Exercicio 05
            double d, V;
            Console.Clear();
            Console.Write("Diâmetro (d): ");
            d = double.Parse(Console.ReadLine());
            V = (int)(4 * 3.14) * ((d / 2) / 3);
            Console.WriteLine("Volume (V): {0}", V);
            Console.ReadKey();

            //Exercicio 06
            float n1, n2, n3, n4, M;
            Console.Clear();
            Console.Write("Valor (n1): ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Valor (n2): ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Valor (n3): ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Valor (n4): ");
            n4 = float.Parse(Console.ReadLine());
            M = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("Média Aritimética (M): {0}", M);
            Console.ReadKey();

            //Exercicio 07
            double n1, n2, M;
            Console.Clear();
            Console.Write("Valor (n1): ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Valor (n2): ");
            n2 = double.Parse(Console.ReadLine());
            M = (int)Math.Sqrt(n1 * n2);
            Console.WriteLine("Média Geométrica (M): {0}", M);
            Console.ReadKey();

            //Exercicio 08            
            float Nm, Km;
            Console.Clear();
            Console.Write("Milhas Náuticas (Nm): ");
            Nm = float.Parse(Console.ReadLine());
            Km = (Nm * 1852) / 1000;
            Console.WriteLine("Conversão para Quilômetro (Km): {0}", Km);
            Console.ReadKey();

            //Exercicio 09
            float r, i, U;
            Console.Clear();
            Console.Write("Resistência Elétric (r):  ");
            r = float.Parse(Console.ReadLine());
            Console.Write("Corrente Elétrica (i):  ");
            i = float.Parse(Console.ReadLine());
            U = r * i;
            Console.WriteLine("Tensão ou Potência Eletrica em Volts (U): {0}", U);
            Console.ReadKey();

            //Exercicio 10
            double c1 = 1.8; // nao consigo criar float c1 = 1.8.
            int c2 = 32;
            double C, F; //Sistema nao aceita double. PORQUE?!?
            Console.Clear();
            Console.Write("Temperatura em Celsius (C): ");
            C = double.Parse(Console.ReadLine());
            F = (C * c1) + c2;
            Console.WriteLine("Temperatura em Fahrenheit (F): {0}", F);
            Console.ReadKey();

            //Exercicio 11
            double pi = 3.14;
            double d, r, A;
            Console.Clear();
            Console.Write("Diâmetro (d): ");
            d = double.Parse(Console.ReadLine());
            r = d / 2;
            A = (int)pi * Math.Pow(r, 2);
            Console.WriteLine("Área (a): {0}", A);
            Console.ReadKey();

            //Exercicio 12
            float r, h, Vc;
            Console.Clear();
            Console.Write("Raio (r): ");
            r = float.Parse(Console.ReadLine());
            Console.Write("Altura (h): ");
            h = float.Parse(Console.ReadLine());
            Vc = (2 * r * h) / 3;
            Console.WriteLine("Volume do Cone (Vc): {0}", Vc);
            Console.ReadKey();

            //Exercicio 13
            double conv = 3.6;
            double Vi, a, T, Vf;
            Console.Write("Velocidade Inicia em m/s (Vi): ");
            Vi = double.Parse(Console.ReadLine());
            Console.Write("Aceleração em m/s² (a): ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Tempo em segundos (T): ");
            T = double.Parse(Console.ReadLine());
            Vf = (Vi + a * T) * conv;
            Console.WriteLine("Velocidade Final em Km/h (Vf): {0}", Vf);
            Console.ReadKey();

            //Exercicio 14
            double pi = 3.18;
            double r, a, Vesf, Vqua;
            Console.Clear();
            Console.Write("Raio (r): ");
            r = double.Parse(Console.ReadLine());
            Console.Write("Aresta (a): ");
            a = double.Parse(Console.ReadLine());
            Vesf = (4 * pi * Math.Pow(r, 3)) / 3;
            Vqua = Math.Pow(a, 3);
            Console.WriteLine("O Volume da Esfera (Vesf): {0}", Vesf);
            Console.WriteLine("O Volume do Quadrado (Vqua): {0}", Vqua);
            Console.ReadKey();

            //Exercicio 15
            double cons = 5.6;
            double X, R;
            Console.Clear();
            Console.Write("Real (R$): ");
            X = double.Parse(Console.ReadLine());
            R = X * cons;
            Console.WriteLine("O valor convertido em dolar (US$) : {0}", R);
            Console.ReadKey();

            //Exercicio 16
            double conv = 57.29578;
            double ang, angc, seno, cos, tang, sec;
            Console.Clear();
            Console.Write("Ângulo: ");
            ang = double.Parse(Console.ReadLine());
            angc = ang * conv;
            seno = Math.Sin(angc);
            cos = Math.Cos(angc);
            tang = Math.Tan(angc);
            sec = 1 / (Math.Cos(angc));
            Console.WriteLine("seno: {0}", seno);
            Console.WriteLine("Coseno: {0}", cos);
            Console.WriteLine("Tangente: {0}", tang);
            Console.WriteLine("Secante: {0}", sec);
            Console.ReadKey();

            //Exercicio 17
            double X, Y, R;
            Console.Clear();
            Console.Write("Valor de X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Valor de Y: ");
            Y = double.Parse(Console.ReadLine());
            R = Math.Pow(X, Y);
            Console.WriteLine("O Valor de X^Y : {0}", R);
            Console.ReadKey();

            //Exercicio 18
            float p1, p2, p3, p4, p5, X, Y;
            Console.Clear();
            Console.Write("Valor do 1° produto: ");
            p1 = float.Parse(Console.ReadLine());
            Console.Write("Valor do 2° produto: ");
            p2 = float.Parse(Console.ReadLine());
            Console.Write("Valor do 3° produto: ");
            p3 = float.Parse(Console.ReadLine());
            Console.Write("Valor do 4° produto: ");
            p4 = float.Parse(Console.ReadLine());
            Console.Write("Valor do 5° produto: ");
            p5 = float.Parse(Console.ReadLine());
            Console.Write("Dinheiro dado para pagar compra: ");
            X = float.Parse(Console.ReadLine());
            Y = X - (p1 + p2 + p3 + p4 + p5);
            Console.WriteLine("O valor do Troco : {0}", Y);
            Console.ReadKey();
        }
    }
}
