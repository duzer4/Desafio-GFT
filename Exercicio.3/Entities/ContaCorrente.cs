namespace Exercicio._3.Entities
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, string titular, double saldo)
            : base(numero, titular, saldo)
        {

        }
        public override double Rendimento()
        {
            return Saldo * 0.03;
        }

        public override string ToString()
        {
            return Numero + " " + Titular + " " + Saldo;
        }
    }
}