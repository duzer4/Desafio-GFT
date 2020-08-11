namespace Exercicio._2.Entities
{
    public class Pessoa
    {
        private string _nome { get; set; }
        private string _endereco { get; set; }
        private int _telefone { get; set; }

        public Pessoa(string nome, string endereco, int telefone)
        {
            this._nome = nome;
            this._endereco = endereco;
            this._telefone = telefone;
        }

        public override string ToString()
        {
            return this._nome + ", " + this._endereco + ", " + this._telefone;
        }

    }
}