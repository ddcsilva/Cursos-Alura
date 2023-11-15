using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

public class FilmesContext : DbContext
{
    public FilmesContext(DbContextOptions<FilmesContext> options) : base(options) { }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sessao>()
            .HasKey(sc => new { sc.FilmeId, sc.CinemaId }); // Chave primária composta

        modelBuilder.Entity<Sessao>()
            .HasOne(sessao => sessao.Cinema) // Uma Sessão tem um Cinema
            .WithMany(cinema => cinema.Sessoes) // Um Cinema tem várias Sessões
            .HasForeignKey(sessao => sessao.CinemaId); // A chave estrangeira de Sessão é CinemaId

        modelBuilder.Entity<Sessao>()
            .HasOne(sessao => sessao.Filme) // Uma Sessão tem um Filme
            .WithMany(filme => filme.Sessoes) // Um Filme tem várias Sessões
            .HasForeignKey(sessao => sessao.FilmeId); // A chave estrangeira de Sessão é FilmeId

        modelBuilder.Entity<Endereco>()
            .HasOne(endereco => endereco.Cinema) // Um Endereço tem um Cinema
            .WithOne(cinema => cinema.Endereco) // Um Cinema tem um Endereço
            .OnDelete(DeleteBehavior.Restrict); // Não exclui o Endereço quando o Cinema for excluído
    }
}