using System;
using System.Collections.Generic;
using System.Data;

namespace solid.patterns2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Factory
            // IDbConnection conexao = new ConnectionFactory().GetConnection();

            // IDbCommand comando = conexao.CreateCommand();
            // comando.CommandText = "Comando por text";

            //Flyweight
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),
            };

            Piano piano = new Piano();
            piano.Toca(musica);
        }
    }
}