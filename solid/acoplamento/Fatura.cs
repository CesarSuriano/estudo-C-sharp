
namespace solid.acoplamento
{
    public class Fatura 
    {
        public double Valor {get; private set;}
        public string Nome {get; private set;}

        public Fatura(double valor, string nome)
        {
            this.Valor = valor;
            this.Nome = nome;
        }
    }
}