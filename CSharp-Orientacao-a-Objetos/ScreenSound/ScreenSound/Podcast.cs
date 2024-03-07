namespace ScreenSound;

public class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; private set; }
    public string Host { get; private set; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} apresentado por {Host}\n");

        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}");
    }
}