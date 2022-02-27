using System;

namespace Revisão_01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o salário: ");
            var sala = float.Parse(Console.ReadLine());
            Console.Write("Digite o cargo: ");
            var cargo = Console.ReadLine();
            Console.Write("Digite o tempo de serviço: ");
            var tempoAnos = int.Parse(Console.ReadLine());
            if (cargo == "Gerente")
            {
                if (tempoAnos >= 5)
                {
                    var salaNovo = sala + (sala * 0.10f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
                if (tempoAnos >= 3 && tempoAnos < 5)
                {
                    var salaNovo = sala + (sala * 0.09f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
                if (tempoAnos < 3)
                {
                    var salaNovo = sala + (sala * 0.08f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
            }
            if (cargo == "Engenheiro")
            {
                if (tempoAnos >= 5)
                {
                    var salaNovo = sala + (sala * 0.11f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
                if (tempoAnos >= 3 && tempoAnos < 5)
                {
                    var salaNovo = sala + (sala * 0.10f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
                if (tempoAnos < 3)
                {
                    var salaNovo = sala + (sala * 0.09f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
            }
            if (cargo == "Técnico")
            {
                if (tempoAnos >= 5)
                {
                    var salaNovo = sala + (sala * 0.12f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
                if (tempoAnos >= 3 && tempoAnos < 5)
                {
                    var salaNovo = sala + (sala * 0.11f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
                if (tempoAnos < 3)
                {
                    var salaNovo = sala + (sala * 0.10f);
                    Console.WriteLine("O novo salário será {0}", salaNovo);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Profissão inválida !");
                Console.ReadKey();
            }
        }
    }
}
