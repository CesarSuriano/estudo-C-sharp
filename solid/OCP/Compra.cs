namespace solid.ocp
{
    public class Compra
    {
        public double Valor { get; }
        public string Cidade { get; }

        public Compra(double valor, string cidade)
        {
            this.Valor = valor;
            this.Cidade = cidade;
        }
    }
}