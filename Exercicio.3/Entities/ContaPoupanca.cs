namespace Exercicio._3.Entities
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, string titular, double saldo)
            : base(numero, titular, saldo)
        {

        }
        public override double Rendimento()
        {
            return Saldo * 0.05;
        }

        public override string ToString()
        {
            return Numero + " " + Titular + " " + Saldo;
        }
    }
}