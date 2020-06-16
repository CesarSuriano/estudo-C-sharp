using System;

namespace solid.chain
{
    public class CalculadorDeDescontos
    {
        public double RealizaCalculo(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCintoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Aplica(orcamento);
        }
    }
}