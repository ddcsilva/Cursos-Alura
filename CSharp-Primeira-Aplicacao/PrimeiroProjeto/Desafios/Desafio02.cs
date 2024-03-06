namespace Desafios;

public class Desafio02
{
    public void iniciar()
    {
        verificarNota();
        exibirLinguagem();
        ExibirNesimaPosicao();
    }

    public void verificarNota()
    {
        int notaMedia = 6;
        if (notaMedia >= 5)
        {
            Console.WriteLine("Nota suficiente para aprovação");
        }
    }

    public void exibirLinguagem()
    {
        List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
        Console.WriteLine(linguagens[0]);
    }

    public void ExibirNesimaPosicao()
    {
        Console.WriteLine("Digite a quantidade de números que deseja inserir na lista:");
        int quantidade = int.Parse(Console.ReadLine()!);

        List<int> lista = new List<int>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número:");
            int numero = int.Parse(Console.ReadLine()!);
            lista.Add(numero);
        }

        Console.WriteLine("Digite a posição que deseja exibir:");
        int posicao = int.Parse(Console.ReadLine()!);

        if (posicao < 1 || posicao > lista.Count)
        {
            Console.WriteLine("Posição inválida!");
        }
        else
        {
            Console.WriteLine($"O número na posição {posicao} é {lista[posicao - 1]}");
        }
    }
}