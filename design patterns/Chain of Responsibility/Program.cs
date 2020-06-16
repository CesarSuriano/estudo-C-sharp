using System;

namespace solid.chain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogar", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("X-Box", 250));

            double desconto = calculador.RealizaCalculo(orcamento);
            Console.WriteLine(desconto);


        }
    }
}