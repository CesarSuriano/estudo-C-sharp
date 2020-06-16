using System;

namespace solid.strategy
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