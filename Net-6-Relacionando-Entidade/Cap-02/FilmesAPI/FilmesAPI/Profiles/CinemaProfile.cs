using AutoMapper;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        // Mapeia o DTO de criação de cinema (CreateCinemaDto) para a entidade Cinema.
        CreateMap<CreateCinemaDto, Cinema>();

        // Mapeia a entidade Cinema para o DTO de leitura de cinema (ReadCinemaDto).
        CreateMap<Cinema, ReadCinemaDto>()
            // Configura um mapeamento personalizado para a propriedade ReadEnderecoDto do ReadCinemaDto.
            .ForMember(
                cinemaDto => cinemaDto.Endereco, // Especifica a propriedade de destino no DTO.
                opt => opt.MapFrom(cinema => cinema.Endereco) // Define que o valor será mapeado a partir da propriedade Endereco da entidade Cinema.
            )
            // Configura um mapeamento personalizado para a propriedade Sessoes do ReadCinemaDto.
            .ForMember(
                cinemaDto => cinemaDto.Sessoes, // Especifica a propriedade de destino no DTO.
                opt => opt.MapFrom(cinema => cinema.Sessoes) // Define que o valor será mapeado a partir da propriedade Sessoes da
            );

        // Mapeia o DTO de atualização de cinema (UpdateCinemaDto) para a entidade Cinema.
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
