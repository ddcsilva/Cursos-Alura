namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            System.Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);
            System.Console.WriteLine(resultadoSaque);

            System.Console.WriteLine(contaDoBruno.saldo);
        }
    }
}
