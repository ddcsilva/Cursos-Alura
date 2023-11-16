using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CinemasController : ControllerBase
{
    private readonly FilmesContext _context;
    private IMapper _mapper;

    public CinemasController(FilmesContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
    {
        Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
        _context.Cinemas.Add(cinema);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
    }

    [HttpGet]
    public IEnumerable<ReadCinemaDto> RecuperaCinemas()
    {
        return _mapper.Map<IEnumerable<ReadCinemaDto>>(_context.Cinemas.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaCinemasPorId(int id)
    {
        Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema != null)
        {
            ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
            return Ok(cinemaDto);
        }
        return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
    {
        Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null)
        {
            return NotFound();
        }
        _mapper.Map(cinemaDto, cinema);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaCinema(int id)
    {
        Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if (cinema == null)
        {
            return NotFound();
        }
        _context.Remove(cinema);
        _context.SaveChanges();
        return NoContent();
    }
}