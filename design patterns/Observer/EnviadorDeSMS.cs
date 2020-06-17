

using System;

namespace solid.observer
{
    public class EnviadorDeSMS : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando SMS");
        }
    }
}