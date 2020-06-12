
using System;

namespace solid.acoplamento
{
    public class SAP : IAcaoAposGerarNota 
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Executando o SAP");
        }
    }
}