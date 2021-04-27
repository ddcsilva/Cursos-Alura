using System;

namespace _03_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Projeto 03 ::.");

            // A forma padrão troca o (.) por (,) e ignora o zero no final
            double salario;
            double idade;
            salario = 1200.70;
            Console.WriteLine("Salário: " + salario);

            // É possível atribuir um número inteiro na variável double
            salario = 1000;
            Console.WriteLine("Salário: " + salario);

            // Se eu fizer um cálculo entre inteiros, ele retorna um inteiro
            salario = 15 / 2;
            Console.WriteLine("Salário: " + salario);

            // A variável mantém como tipo Double
            Console.WriteLine("Salário: " + salario);
            Console.WriteLine(salario.GetType());

            // Se eu fizer um cálculo com pelo menos um double, o resultado será double
            salario = 15.0 / 2;
            Console.WriteLine("Salário: " + salario);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);
        }
    }
}
