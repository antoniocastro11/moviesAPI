using Microsoft.EntityFrameworkCore;
using moviesApi.Models;
namespace moviesApi.Data;



public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> opts) : base(opts)
    {
        //um context para cada banco de dados
    }
    public DbSet<Movie> Movies => Set<Movie>();// um set para cada entidade
    public DbSet<Cinema> Cinemas => Set<Cinema>();
    public DbSet<Address> Addresses => Set<Address>();
}