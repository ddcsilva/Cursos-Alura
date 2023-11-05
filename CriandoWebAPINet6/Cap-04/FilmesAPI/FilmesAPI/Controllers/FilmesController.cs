using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmesController : Controller
{
    private FilmesContext _context;
    private IMapper _mapper;

    public FilmesController(FilmesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    // É preciso adicionar o atributo [FromBody] para que o ASP.NET Core saiba que o corpo da requisição HTTP deve ser usado para preencher o parâmetro filme.
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);

        _context.Filmes.Add(filme);
        _context.SaveChanges();

        // O método CreatedAtAction() retorna o código 201 (Created) e o cabeçalho Location com a URL do recurso criado.
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id }, filme);
    }

    [HttpGet]
    // O método RecuperaFilmes() retorna a lista de filmes que está armazenada na memória do servidor.
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        // Skip: Parâmetro que indica quantos elementos devem ser ignorados no início da lista.
        // Take: Parâmetro que indica quantos elementos devem ser retornados.
        return _context.Filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    // O método RecuperaFilmePorId() recebe o id do filme que deve ser retornado e faz uma busca na lista de filmes.
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null)
        {
            // NotFound: Retorna o código 404 (Not Found) para o cliente.
            return NotFound("Filme não encontrado");
        }

        // Ok: Retorna o código 200 (OK) para o cliente.
        return Ok(filme);
    }
}
