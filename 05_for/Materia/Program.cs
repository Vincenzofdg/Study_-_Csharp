using System;

namespace Materia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exemplo do laço for:
            // Vamos criar um programa para exibir valores inteiros de 1 a 10

            int contador;
            //  Valor Inicial |   Condição   | Incremento
            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Contador = {0}", contador);
            }

            Console.ReadKey();

            // Laço for () => laço contado.
            // Laço while () e do while () => laços condicionais.

            // Utilizar o for () quando se souber o número de repetições do laço.

            int a, b, t;

            for (a = 1, b = 10; a <= 10; a++, b--)
            {
                t = a * b;
                Console.WriteLine("{0} x {1} = {2}", a, b, t);
            }

            Console.ReadKey();
        }
    }
}
