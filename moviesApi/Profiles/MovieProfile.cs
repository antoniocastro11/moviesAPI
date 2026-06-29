using AutoMapper;
using moviesApi.Data.Dtos;
using moviesApi.Models;

namespace moviesApi.Profiles;
public class MovieProfile : Profile 
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
        CreateMap<Movie, ReadMovieDto>();
    }
}