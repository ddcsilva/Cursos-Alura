using System.Runtime.ConstrainedExecution;

namespace Desafio1;

public class Carro
{
    // Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
    public string marca;
    public string modelo;
    public string cor;
    public int ano;
    public int velocidade;

    public void Acelerar()
    {
        velocidade += 20;
    }

    public void Frear()
    {
        velocidade -= 20;
    }

    public void Buzinar()
    {
        Console.WriteLine("B I P B I P");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Velocidade: {velocidade}");
    }
}
