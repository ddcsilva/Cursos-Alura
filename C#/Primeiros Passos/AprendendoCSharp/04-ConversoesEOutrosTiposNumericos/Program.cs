using System;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Projeto 04 ::.");

            double salario = 1200.50;
            Console.WriteLine(salario);

            // O int é um tipo de variável que suporte valores até 32 bits
            // Conversão em Casting. Neste caso, perde a precisão
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo de variável que suporte valores até 64 bits
            long idade = 1300000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável que suporte valores até 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            // O float é um tipo de variável de ponto flutuante de menor precisão
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
