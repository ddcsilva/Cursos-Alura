namespace Desafio2;

public class ContaBancaria
{
    public int NumeroIndicador { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}