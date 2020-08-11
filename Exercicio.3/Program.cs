using System;
using System.Collections.Generic;
using Exercicio._3.Entities;

namespace Exercicio._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> list = new List<Conta>();

            System.Console.WriteLine("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Titular da conta: ");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Conta corrente ou poupança? (Escreva: corrente ou poupanca)");
            string resposta = Console.ReadLine();

            if (resposta == "corrente")
            {
                list.Add(new ContaCorrente(numero, titular, saldo));
            }
            else
            {
                list.Add(new ContaPoupanca(numero, titular, saldo));
            }

            System.Console.WriteLine();

            foreach (Conta conta in list)
            {
                double rendimento = conta.Rendimento();
                System.Console.WriteLine(conta.ToString());
            }
            
        }
    }
}
