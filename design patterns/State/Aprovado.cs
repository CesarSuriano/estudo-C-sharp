using System;

namespace solid.state
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento já foi aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento já foi aprovado");
        }
    }
}