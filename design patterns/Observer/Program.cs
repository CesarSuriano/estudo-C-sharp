using System;

namespace solid.observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder()
                .ParaEmpresa("Itau unibanco")
                .ComCnpj("23.456.789.1000-12")
                .ComItem(new ItemDaNota("Item 1", 100))
                .ComItem(new ItemDaNota("Item 1", 200))
                .NaDataAtual()
                .ComObservacoes("Observacao");

                criador.AdicionaAcao(new EnviadorDeEmail());
                criador.AdicionaAcao(new EnviadorDeSMS());

                NotaFiscal nf = criador.Build();

                Console.WriteLine(nf.ValorBruto);
                Console.WriteLine(nf.Impostos);
        }
    }
}