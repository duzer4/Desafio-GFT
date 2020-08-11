using System;
using System.Collections.Generic;
using Exercicio._2.Entities;

namespace Exercicio._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Clécio Henrique", "Rua GFT", 997638535);

            Console.WriteLine(pessoa.ToString());
        }
    }
}
