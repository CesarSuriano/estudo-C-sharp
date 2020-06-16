namespace solid.chain
{
    public class DescontoPorCintoItens : IDesconto
    {
        public SemDesconto descconto;

        public IDesconto Proximo { get; set; }

        public double Aplica(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Aplica(orcamento);
        }
    }
}