namespace solid.chain
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Aplica(Orcamento orcamento)
        {
            return 0;
        }
    }
}