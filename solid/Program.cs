using System;

namespace solid
{
    public class Program
    {
       public static void Main(string[] args)
       {
           CalculadoraDeSalario cs = new CalculadoraDeSalario();
           Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorCento()), 5000);
           double resultado;

           resultado = cs.Calcula(funcionario);

           Console.WriteLine("O salario de um desenvolvedor é: " + resultado);
           Console.ReadKey();
       }
    }
}