namespace ScreenSound;

public class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string? Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Músicas do álbum {Nome}:");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        Console.WriteLine($"Duração total: {DuracaoTotal} minutos");
    }
}
