using AutoMapper;
using moviesApi.Data.Dtos.Cinema;
using moviesApi.Models;

namespace moviesApi.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile() {

        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.Address,
                    opt => opt.MapFrom(cinema => cinema.Address))
            .ForMember(cinemaDto => cinemaDto.Sessions,
                    opt => opt.MapFrom(cinema => cinema.Sessions)); ;
    }

}

