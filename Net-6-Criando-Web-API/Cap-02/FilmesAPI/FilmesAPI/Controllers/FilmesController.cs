using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : Controller
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)  // É preciso adicionar o atributo [FromBody] para que o ASP.NET Core saiba que o corpo da requisição HTTP deve ser usado para preencher o parâmetro filme.
    {
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }
}
