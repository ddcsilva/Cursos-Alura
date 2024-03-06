namespace Desafio1;

public class ContaBancaria
{
    public int numeroIndicador;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
    }
}