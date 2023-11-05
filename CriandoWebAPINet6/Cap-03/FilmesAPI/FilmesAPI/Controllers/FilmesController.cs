using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : Controller
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)  // É preciso adicionar o atributo [FromBody] para que o ASP.NET Core saiba que o corpo da requisição HTTP deve ser usado para preencher o parâmetro filme.
    {
        filme.Id = id++;
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet]
    // Skip: Parâmetro que indica quantos elementos devem ser ignorados no início da lista.
    // Take: Parâmetro que indica quantos elementos devem ser retornados.
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50) // O método RecuperaFilmes() retorna a lista de filmes que está armazenada na memória do servidor.
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public Filme? RecuperaFilmePorId(int id) // O método RecuperaFilmePorId() recebe o id do filme que deve ser retornado e faz uma busca na lista de filmes.
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);
    }
}
