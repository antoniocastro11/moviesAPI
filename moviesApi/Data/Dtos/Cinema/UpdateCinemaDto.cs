using System.ComponentModel.DataAnnotations;

namespace moviesApi.Data.Dtos.Cinema
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Name { get; set; }
    }
}
