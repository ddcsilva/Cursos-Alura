using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(resultadoSaque);

            Console.WriteLine(contaDoBruno.saldo);
        }
    }
}
