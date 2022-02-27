using System;

namespace Materia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exemplo 01: Vamos criar um programa para exibir valores inteiros de 1 a 10.
            int contador = 0;
            while (contador < 10)
            {
                contador++; // contador = contador + 1
                Console.WriteLine("Contador = {0}", contador);
            }
            Console.ReadKey();

            // Exemplo 02: Criar uma rotina de entrada que aceite somente um valor positivo.
            int x = 0;
            while (x <= 0)
            {
                Console.Write("Valor positivo: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.Write("OK");
            Console.ReadKey();

            // Exemplo 03: Entrar com dois valores via teclado, onde o segundo deverá ser maior que o primeiro.
            // Caso contrário solicitar novamente apenas o segundo valor. 
            Console.Write("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            while (n1 >= n2)
            {
                Console.Write("Digite Novamente o segundo valor: ");
                n2 = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("OK");
            Console.ReadKey();

            // Exemplo 04: Entrar via teclado com o sexo de determinado usuário, aceitar somente “F” ou “M” 
            // como respostas válidas.
            Console.Write("Digite o sexo (F para mulher e M para homem): ");
            char s = char.Parse(Console.ReadLine().ToUpper());
            while (s != 'M' && s != 'F')
            {
                Console.SetCursorPosition(5, 0);
                s = Console.ReadKey().KeyChar;
            }
            Console.Write("OK");
            Console.ReadKey();
        }
    }
}
