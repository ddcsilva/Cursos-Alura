using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateEnderecoDto
    {
        [Required(ErrorMessage = "O campo logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo numero é obrigatório")]
        public int Numero { get; set; }
    }
}