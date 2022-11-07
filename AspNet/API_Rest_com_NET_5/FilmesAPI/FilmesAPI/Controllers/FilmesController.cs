using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {
        private readonly FilmesContext context;

        public FilmesController(FilmesContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] Filme filme)
        {
            this.context.Filmes.Add(filme);
            this.context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id }, filme);
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
                return Ok(filme);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] Filme filmeNovo)
        {
            var filme = this.context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            filme.Titulo = filmeNovo.Titulo;
            filme.Genero = filmeNovo.Genero;
            filme.Duracao = filmeNovo.Duracao;
            filme.Diretor = filmeNovo.Diretor;

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
