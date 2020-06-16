namespace solid.chain
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Aplica(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Aplica(orcamento);
        }
    }
}