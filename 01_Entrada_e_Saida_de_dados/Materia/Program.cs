using System;

namespace Materia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x, resp;//Declaração de duas varíaveis no mesmo comando (duas variaveis do tipo double).
            Console.Clear(); //Limpar a tela.
            Console.Write("Digite um valo: ");//Exibirá uma mensagem para o usuário.
            x = double.Parse(Console.ReadLine()); //Aguarda a digitação de um valor.Converte o String digitado em double.
            resp = 2 * x;//Calcular o dobro do x e armazenar em resp.
            Console.WriteLine("Dobro do valor escolhido: {0}", resp);
            Console.ReadKey();

            //Exemplo 01
            int Anos, Dias, Horas;
            Console.Clear();
            Console.WriteLine("Digite sua idade em anos: ");
            Anos = int.Parse(Console.ReadLine());

            Dias = Anos * 365;
            Horas = Dias * 24;
            Console.WriteLine("{0} anos de vida.", Anos);
            Console.WriteLine("Aproximadamente {0} dias.", Dias);
            Console.WriteLine("{0} horas.", Horas);
            Console.ReadKey();

            //Exemplo 02
            float P1, P2, M;
            Console.Clear();
            Console.Write("P1: ");
            P1 = float.Parse(Console.ReadLine());
            Console.Write("P2: ");
            P2 = float.Parse(Console.ReadLine());
            M = (P1 + P2) / 2;
            Console.WriteLine("M = {0}", M);
            Console.ReadLine();
        }
    }
}
