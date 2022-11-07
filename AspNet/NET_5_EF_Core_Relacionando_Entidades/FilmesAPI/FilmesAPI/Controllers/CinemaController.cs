using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOs;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly FilmesContext context;
        private readonly IMapper mapper;

        public CinemaController(FilmesContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
  

        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDTO cinemaDTO)
        {
            Cinema cinema = this.mapper.Map<Cinema>(cinemaDTO);

            this.context.Cinemas.Add(cinema);
            this.context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
        }

        [HttpGet]
        public IEnumerable<Cinema> RecuperaCinemas([FromQuery] string nomeDoFilme)
        {
            return this.context.Cinemas;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemasPorId(int id)
        {
            Cinema cinema = this.context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);

            if(cinema != null)
            {
                ReadCinemaDTO cinemaDTO = this.mapper.Map<ReadCinemaDTO>(cinema);
                return Ok(cinemaDTO);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDTO cinemaDTO)
        {
            Cinema cinema = this.context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if(cinema == null)
            {
                return NotFound();
            }

            this.mapper.Map(cinemaDTO, cinema);
            this.context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult ExcluirCinema(int id)
        {
            Cinema cinema = this.context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);

            if (cinema == null)
            {
                return NotFound();
            }

            this.context.Remove(cinema);
            this.context.SaveChanges();
            return NoContent();
        }
    }
}
