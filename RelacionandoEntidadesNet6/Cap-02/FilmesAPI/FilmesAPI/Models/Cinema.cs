using System.ComponentModel.DataAnnotations;

namespace FilmesAPI;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }
}