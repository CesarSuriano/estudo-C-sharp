
using System;
using System.Collections.Generic;

namespace solid.acoplamento
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao notaFiscalDao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();

            acoes.Add(enviadorDeEmail);
            acoes.Add(notaFiscalDao);

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Cesar");
            gerador.Gera(fatura);
            Console.ReadKey();
        }
    }
}