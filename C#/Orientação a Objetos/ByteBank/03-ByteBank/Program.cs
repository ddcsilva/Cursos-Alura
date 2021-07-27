using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200;

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
        }
    }
}