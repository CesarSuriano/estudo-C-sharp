
using System.Collections.Generic;

namespace solid.acoplamento
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.Valor;
            NotaFiscal notaFiscal= new NotaFiscal(valor);

            foreach (var acao in acoes)
            {
                acao.Executa(notaFiscal);
            }
            return notaFiscal;
        }

    }
}