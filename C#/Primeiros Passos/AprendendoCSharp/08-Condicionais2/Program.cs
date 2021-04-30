using System;

namespace _08_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".:: Projeto 08 ::.");

            int idadeJoao = 18;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.WriteLine("A execução acabou. Tecle <Enter> para finalizar");
            Console.ReadLine();
        }
    }
}
