using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AluraTunesAula1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listas os gêneros do Rock
            var generos = new List<Genero>
            {
                new Genero { Id = 1, Nome = "Rock" },
                new Genero { Id = 2, Nome = "Reggae" },
                new Genero { Id = 3, Nome = "Rock Progressivo" },
                new Genero { Id = 4, Nome = "Jazz" },
                new Genero { Id = 5, Nome = "Punk Rock" },
                new Genero { Id = 6, Nome = "Clássica" }
            };

            // LINQ - Language Integrated Query = Consulta Integrada à Linguagem
            var query = from g in generos
                        where g.Nome.Contains("Rock")
                        select g;

            foreach (var genero in query)
            {
                Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            }
        }
    }
}
