using System;

namespace solid.state
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento foi reprovado");
        }

        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("O orcamento não pode ser aprovado, pois já foi negado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("O orçamento já foi reprovado");
        }
    }
}