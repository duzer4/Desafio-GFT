using System;

namespace Exercicio._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o valor inicial: ");
            int valorInicial = int.Parse(Console.ReadLine());

            if (valorInicial <= 0)
            {
                Console.WriteLine("O número inicial deve ser maior que 0");
                return;
            }
                
            Console.Write("Digite o valor final: ");
            int valorFinal = int.Parse(Console.ReadLine());

            if (valorFinal <= valorInicial )
            {
                Console.WriteLine("O valor final deve ser maior que o valor inicial");
                return;
            }

            System.Console.Write("O números ímpares são: ");

            for (int i = valorInicial; i <= valorFinal; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
