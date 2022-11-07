using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOs;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly FilmesContext context;
        private readonly IMapper mapper;

        public FilmesController(FilmesContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreateFilmeDTO filmeDTO)
        {
            Filme filme = this.mapper.Map<Filme>(filmeDTO);

            this.context.Filmes.Add(filme);
            this.context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id }, filmeDTO);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilme()
        {
            return this.context.Filmes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            var filme = this.context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme != null)
            {
                ReadFilmeDTO filmeDTO = this.mapper.Map<ReadFilmeDTO>(filme);

                return Ok(filmeDTO);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDTO filmeDTO)
        {
            var filme = this.context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            this.mapper.Map(filmeDTO, filme);

            this.context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirFilme(int id)
        {
            var filme = this.context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            this.context.Filmes.Remove(filme);
            this.context.SaveChanges();

            return NoContent();
        }
    }
}
