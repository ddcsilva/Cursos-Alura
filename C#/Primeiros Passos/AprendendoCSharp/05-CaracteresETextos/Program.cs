using System;

namespace _05_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Projeto 05 ::.");

            // Caractere
            char primeiraLetra = 'a';
            Console.WriteLine("Variável em Char: " + primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine("Variável em Char em número: " + primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine("Variável em Char com cálculo: " + primeiraLetra);

            string titulo = "Alura - Cursos de Tecnologia";
            Console.WriteLine("Representação de String: " + titulo);

            titulo = titulo + 2020;
            Console.WriteLine("String + Número: " + titulo);

            // Não é possível quebrar linha, sem o caractere especial
            // É possível utilizar o caractere @ no início da String
            string cursosProgramação = @" - .NET
                                           - Java
                                           - Javascript";
            Console.WriteLine(cursosProgramação);
        }
    }
}
