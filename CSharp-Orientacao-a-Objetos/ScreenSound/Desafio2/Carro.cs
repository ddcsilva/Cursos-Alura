namespace Desafio2;

public class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }

    private int _ano;
    public int Ano
    {
        get => _ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                throw new ArgumentOutOfRangeException("Ano inválido");
            } 

            _ano = value;
        }
    }

    public int Velocidade { get; set; }
    public string DescricaoDetalhada => $"Fabricado por {Fabricante} em {Ano}, modelo {Modelo} de cor {Cor}";

    public void Acelerar()
    {
        Velocidade += 20;
    }

    public void Frear()
    {
        Velocidade -= 20;
    }

    public void Buzinar()
    {
        Console.WriteLine("B I P B I P");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Fabricante: {Fabricante}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Velocidade: {Velocidade}");
    }
}
