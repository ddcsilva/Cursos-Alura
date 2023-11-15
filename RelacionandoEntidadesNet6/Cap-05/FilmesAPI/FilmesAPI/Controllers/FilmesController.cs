﻿using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
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

    /// <summary>
    /// Adiciona um filme ao banco de dados.
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um novo filme.</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Retorna o filme recém-criado.</response>
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

    /// <summary>
    /// Atualiza um filme ao banco de dados.
    /// </summary>
    /// <param name="id">Identificador do filme.</param>
    /// <param name="filmeDto">Objeto com os campos necessários para atualização de um filme.</param>
    /// <returns>IActionResult</returns>
    /// <response code="204">Retorna o filme atualizado.</response>
    [HttpPut("{id}")]
    // O método AtualizaFilme() recebe o id do filme que deve ser atualizado e o objeto filmeDto que contém os novos dados do filme.
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null)
        {
            return NotFound();
        }

        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();

        return NoContent();
    }

    /// <summary>
    /// Atualiza parcialmente um filme ao banco de dados.
    /// </summary>
    /// <param name="id">Identificador do filme.</param>
    /// <param name="patchFilme">Objeto com os campos necessários para atualização parcial de um filme.</param>
    /// <returns>IActionResult</returns>
    /// <response code="204">Retorna o filme atualizado.</response>
    [HttpPatch("{id}")]
    // O método AtualizaFilmeParcialmente() recebe o id do filme que deve ser atualizado e o objeto filmeDto que contém os novos dados do filme.
    public IActionResult AtualizaFilmeParcialmente(int id, JsonPatchDocument<UpdateFilmeDto> patchFilme)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null)
        {
            return NotFound();
        }

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);

        // O método ApplyTo() aplica as alterações do objeto patchFilme no objeto filmeParaAtualizar.
        patchFilme.ApplyTo(filmeParaAtualizar, ModelState);

        // O método TryValidateModel() verifica se o objeto filmeParaAtualizar é válido.
        if (!TryValidateModel(filmeParaAtualizar))
        {
            // ValidationProblem: Retorna o código 400 (Bad Request) para o cliente.
            return ValidationProblem(ModelState);
        }

        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();

        return NoContent();
    }

    /// <summary>
    /// Deleta um filme do banco de dados.
    /// </summary>
    /// <param name="id">Identificador do filme.</param>
    /// <returns>IActionResult</returns>
    /// <response code="204">Retorna o filme deletado.</response>
    [HttpDelete("{id}")]
    // O método DeletaFilme() recebe o id do filme que deve ser deletado.
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null)
        {
            return NotFound();
        }

        _context.Remove(filme);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpGet]
    // O método RecuperaFilmes() retorna a lista de filmes que está armazenada na memória do servidor.
    public IEnumerable<ReadFilmeDto> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50, [FromQuery] string? nomeCinema = null)
    {
        if (nomeCinema == null)
        {
            // Skip: Parâmetro que indica quantos elementos devem ser ignorados no início da lista.
            // Take: Parâmetro que indica quantos elementos devem ser retornados.
            return _mapper.Map<IEnumerable<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take).ToList());
        }

        return _mapper.Map<IEnumerable<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take)
            .Where(filme => filme.Sessoes.Any(sessao => sessao.Cinema.Nome == nomeCinema)).ToList());
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

        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);

        // Ok: Retorna o código 200 (OK) para o cliente.
        return Ok(filmeDto);
    }
}
