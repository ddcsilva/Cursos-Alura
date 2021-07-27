using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoSaque);

            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);

            Console.WriteLine(contaDoBruno.saldo);
        }
    }
}
