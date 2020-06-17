using System;
using System.Collections.Generic;

namespace solid.observer
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }

        private double valorTotal;
        private double impostos;

        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public void AdicionaAcao(IAcaoAposGerarNota acao)
        {
            this.todasAcoesASeremExecutadas.Add(acao);
        }

        public NotaFiscal Build()
        {
            NotaFiscal nf = new NotaFiscal(this.RazaoSocial, this.Cnpj, this.Data, this.valorTotal, this.impostos, this.todosItens, this.Observacoes);

            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }
            return nf;
        }
    }
}