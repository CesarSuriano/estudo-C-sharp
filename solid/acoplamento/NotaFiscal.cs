
namespace solid.acoplamento
{
    public class NotaFiscal 
    {
        public double Valor {get; private set;}

        public NotaFiscal(double valor)
        {
            this.Valor = valor;
        }
    }
}