using AutoMapper;
using moviesApi.Data.Dtos.Session;
using moviesApi.Models;

namespace moviesApi.Profiles;

    public class SessionProfile : Profile
{
        public SessionProfile()
    {
        CreateMap<CreateSessionDto, Session>();
        CreateMap<Session, ReadSessionDto>();
    }
}

