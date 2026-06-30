using moviesApi.Data.Dtos.Address;
using moviesApi.Models;
using AutoMapper;

namespace moviesApi.Profiles;
public class AddressProfile : Profile
{
    public AddressProfile() {

        CreateMap<CreateAddressDto, Address>();
        CreateMap<UpdateAddressDto, Address>();
        CreateMap<Address, ReadAddressDto>();
    }
}

