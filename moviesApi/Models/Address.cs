using System.ComponentModel.DataAnnotations;

namespace moviesApi.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string Street { get; set; }
    public int Number { get; set; }
    public virtual Cinema Cinema { get; set; }
}