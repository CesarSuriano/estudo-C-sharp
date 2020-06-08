using System;

namespace dot_net_core
{
    public class LivroRepositorioCSV
    {
        public LivroRepositorioCSV()
        {
            Console.WriteLine("Livro repositório");
        }

        public ListaDeLeitura ParaLer { get; internal set; }
        public ListaDeLeitura Lendo { get; internal set; }
        public ListaDeLeitura Lidos { get; internal set; }
    }

}