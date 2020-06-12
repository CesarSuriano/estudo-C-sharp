
using System;

namespace solid.acoplamento
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Executando nota fiscal");
        }
    }
}