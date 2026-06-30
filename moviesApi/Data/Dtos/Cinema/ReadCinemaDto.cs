using moviesApi.Data.Dtos.Address;

namespace moviesApi.Data.Dtos.Cinema;
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ReadAddressDto ReadAddressDto { get; set; }
    }
