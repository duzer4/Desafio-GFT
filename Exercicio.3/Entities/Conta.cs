namespace Exercicio._3.Entities
{
    public abstract class Conta
    {
        protected int Numero { get; set; }
        protected string Titular { get; set; }
        protected double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public abstract double Rendimento();
    }
}