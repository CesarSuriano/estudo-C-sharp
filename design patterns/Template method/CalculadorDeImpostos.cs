using System;

namespace solid.template
{

    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valorDoImposto = imposto.Calcula(orcamento);
            Console.WriteLine("Valor: " + valorDoImposto);
        }
    }
}