using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Titulo { get; set; }

    [Required]
    [MaxLength(50)]
    public string Genero { get; set; }

    [Required]
    [Range(70, 300)]
    public int Duracao { get; set; }

    public virtual ICollection<Sessao> Sessoes { get; set; }
}
