using System;

namespace _06_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Projeto 06 ::.");

            int idade = 32;
            int idadeDanilo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeDanilo);
        }
    }
}
