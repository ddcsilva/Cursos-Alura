namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();

            primeiraContaCorrente.saldo = 200;

            System.Console.WriteLine(primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;

            System.Console.WriteLine(primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();

            segundaContaCorrente.saldo = 50;

            System.Console.WriteLine("A primeira Conta tem: " + primeiraContaCorrente.saldo);
            System.Console.WriteLine("A segunda Conta tem: " + segundaContaCorrente.saldo);
        }
    }
}
