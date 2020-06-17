using System;

namespace solid.decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);
            Imposto icms = new ICMS(new ISS(new IKCV()));

            double valor = icms.Calcula(orcamento);

            Console.WriteLine(valor);
        }
    }
}