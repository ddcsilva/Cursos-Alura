namespace ScreenSound;

public class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; private set; }
    public string Titulo { get; private set; }
    public int Duracao { get; private set; }
    public string Resumo => $"{Ordem} - {Titulo} ({Duracao} minutos - {string.Join(", ", convidados)})";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}
