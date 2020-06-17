using System;

namespace solid.state
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento finalizado");
        }
    }
}