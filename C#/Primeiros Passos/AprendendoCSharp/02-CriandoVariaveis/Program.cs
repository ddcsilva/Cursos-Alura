using System;

namespace _02_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Projeto 02 ::.");

            int idade;

            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine("10 + 5 = " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("10 + 5 * 2 = " + idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("(10 + 5) * 2 = " + idade);

        }
    }
}
