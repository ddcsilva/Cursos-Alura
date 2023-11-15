using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SessoesController : ControllerBase
{
    private readonly FilmesContext _context;
    private IMapper _mapper;

    public SessoesController(FilmesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaSessao([FromBody] CreateSessaoDto sessaoDto)
    {
        Sessao sessao = _mapper.Map<Sessao>(sessaoDto);
        _context.Sessoes.Add(sessao);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaSessaoPorId), new
        {
            filmeId = sessao.FilmeId,
            cinemaId = sessao.CinemaId
        }, sessao);
    }

    [HttpGet]
    public IEnumerable<ReadSessaoDto> RecuperaSessoes()
    {
        return _mapper.Map<IEnumerable<ReadSessaoDto>>(_context.Sessoes.ToList());
    }

    [HttpGet("{filmeId}/{cinemaId}")]
    public IActionResult RecuperaSessaoPorId(int filmeId, int cinemaId)
    {
        Sessao sessao = _context.Sessoes.FirstOrDefault(sessao =>
            sessao.FilmeId == filmeId && sessao.CinemaId == cinemaId);

        if (sessao != null)
        {
            ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
            return Ok(sessaoDto);
        }
        return NotFound();
    }
}