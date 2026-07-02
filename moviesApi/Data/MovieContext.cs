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
    public DbSet<Session> Sessions => Set<Session>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Session>().HasKey(session => new { session.MovieId, session.CinemaId });

        modelBuilder.Entity<Session>().HasOne(session => session.Cinema).WithMany(cinema => cinema.Sessions).HasForeignKey(session => session.CinemaId);

        modelBuilder.Entity<Session>().HasOne(session => session.Movie).WithMany(movie => movie.Sessions).HasForeignKey(session => session.MovieId);
    }
}