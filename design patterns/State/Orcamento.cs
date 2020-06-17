using System.Collections.Generic;

namespace solid.state
{
    public class Orcamento
    {
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}