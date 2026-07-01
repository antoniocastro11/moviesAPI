using System.ComponentModel.DataAnnotations;
namespace moviesApi.Models;
public class Movie
{

    [Key]
    [Required]
    public int Id {get; set;}
    
    [Required(ErrorMessage = "O campo título é obrigado")]
    [MaxLength(100)]
    public string Title {get; set;}

    [Required (ErrorMessage = "O campo título é obrigado")]
    [MaxLength(50)]
    public string Genre {get; set;}

    [Required (ErrorMessage = "O campo título é obrigado")]
    [Range (70,300)]
    public int Duration {get;set;}

    [MaxLength(70)]
    public string Director {get; set;}

    public virtual ICollection<Session> Sessions {get; set;}

}