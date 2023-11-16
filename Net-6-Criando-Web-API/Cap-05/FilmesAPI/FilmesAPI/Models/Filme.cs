using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required(ErrorMessage = "O campo id do filme é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O campo gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O campo gênero do filme não pode ter mais de 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "O campo duração do filme é obrigatório")]
    [Range(70, 300, ErrorMessage = "A duração deve ter no mínimo 70 e no máximo 300 minutos")]
    public int Duracao { get; set; }
}
