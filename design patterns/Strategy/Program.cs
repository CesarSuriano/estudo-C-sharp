namespace solid.strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1200);
            IImposto icms = new ICMS();
            IImposto iss = new ISS();

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
        }
    }
}