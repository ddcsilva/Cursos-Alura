using System.ComponentModel.DataAnnotations;
using FilmesAPI.Models;

namespace FilmesAPI;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    public int EnderecoId { get; set; }
    public virtual Endereco Endereco { get; set; }
}