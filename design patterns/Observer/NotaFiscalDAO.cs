using System;

namespace solid.observer
{
    public class NotaFiscalDAO : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Acessando o banco");
        }
    }
}