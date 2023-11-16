using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{
    // O atributo [Required] indica que o campo é obrigatório.
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(200, ErrorMessage = "O título do filme não deve exceder 50 caracteres")]
    public string Titulo { get; set; }

    // O atributo [Required] indica que o campo é obrigatório.
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O gênero do filme não deve exceder 50 caracteres")]
    public string Genero { get; set; }

    // O atributo [Required] indica que o campo é obrigatório.
    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(60, 300, ErrorMessage = "A duração deve ter no mínimo 60 e no máximo 300 minutos")]
    public int Duracao { get; set; }
}