using System;

namespace solid.ocp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Compra compra = new Compra(500, "SAO PAULO");
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preco da compra eh: "+ resultado);

        }
    }
}