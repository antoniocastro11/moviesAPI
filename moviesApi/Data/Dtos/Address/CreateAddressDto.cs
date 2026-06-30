using System.ComponentModel.DataAnnotations;

namespace moviesApi.Data.Dtos.Address
{
    public class CreateAddressDto
    {
        [StringLength(50)]
        public string Street { get; set; }

        public int Number {  get; set; }
    }
}
