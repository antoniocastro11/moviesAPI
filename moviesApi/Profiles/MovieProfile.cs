using AutoMapper;
using moviesApi.Data.Dtos.Movie;
using moviesApi.Models;

namespace moviesApi.Profiles;
public class MovieProfile : Profile 
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
        CreateMap<Movie, ReadMovieDto>()
            .ForMember(filmeDto => filmeDto.Sessions,
                   opt => opt.MapFrom(filme => filme.Sessions));
    }
}