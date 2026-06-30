using System.ComponentModel.DataAnnotations;

namespace moviesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nome é obrigatório")]
        public string Name { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
