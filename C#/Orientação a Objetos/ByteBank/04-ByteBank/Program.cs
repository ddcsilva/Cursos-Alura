using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de Tipo de Referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de Tipo de Valor: " + (idade == idadeMaisUmaVez));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine("Igualdade de Tipo de Referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo: " + contaDaGabrielaCosta.saldo);
        }
    }
}
