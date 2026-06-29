using System.ComponentModel.DataAnnotations;

namespace moviesApi.Data.Dtos;

public class CreateMovieDto
{
    [Required(ErrorMessage = "O campo título é obrigado")]
    [StringLength(100)]
    public string Title {get; set;}

    [Required (ErrorMessage = "O campo título é obrigado")]
    [StringLength(50)]
    public string Genre {get; set;}

    [Required (ErrorMessage = "O campo título é obrigado")]
    [Range (70,300)]
    public int Duration {get;set;}

    [StringLength(70)]
    public string Director {get; set;}

}