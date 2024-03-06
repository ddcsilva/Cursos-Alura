namespace Desafios;

public class Desafio03
{
    public void iniciar()
    {
        operacoesBasicas();
        adicionarBandas();
        somaElementos();
    }

    /*
Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
    */
    public void operacoesBasicas()
    {
        double a = 10;
        double b = 5;
        Console.WriteLine($"Soma: {a + b}");
        Console.WriteLine($"Subtração: {a - b}");
        Console.WriteLine($"Divisão: {a / b}");
        Console.WriteLine($"Multiplicação: {a * b}");
    }

    public void adicionarBandas()
    {
        List<string> bandas = new List<string>();
        bandas.Add("Led Zeppelin");
        bandas.Add("Pink Floyd");
        bandas.Add("The Beatles");
        bandas.Add("Queen");
        bandas.Add("AC/DC");
        bandas.Add("The Rolling Stones");
        bandas.Add("The Doors");
        bandas.Add("The Who");
        bandas.Add("Black Sabbath");
        bandas.Add("Deep Purple");
        bandas.Add("The Jimi Hendrix Experience");
        bandas.Add("The Kinks");
        bandas.Add("The Yardbirds");
        bandas.Add("The Animals");
        bandas.Add("The Byrds");
        bandas.Add("The Hollies");
        bandas.Add("The Monkees");
        bandas.Add("The Turtles");
        bandas.Add("The Zombies");

        for (int i = 0; i < bandas.Count; i++)
        {
            Console.WriteLine(bandas[i]);
        }
    }

    public void somaElementos()
    {
        List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
        int soma = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            soma += lista[i];
        }
        Console.WriteLine(soma);
    }
}