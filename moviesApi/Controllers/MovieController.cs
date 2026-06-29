using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesApi.Data;
using moviesApi.Data.Dtos;
using moviesApi.Models;
namespace moviesApi.Controllers; 

[ApiController]
[Route("[controller]")]
public class MovieController(MovieContext context, IMapper mapper) : ControllerBase
{

    [HttpPost]
    public IActionResult AddMovie([FromBody] CreateMovieDto movieDto)
    {
        Movie movie = mapper.Map<Movie>(movieDto);
        context.Movies.Add(movie);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetMovieById), 
        new { id = movie.Id}, movie);
    }

    [HttpGet]
    public IEnumerable<Movie> GetMovies([FromQuery]int skip = 0, [FromQuery]int take = 10)
    {
        return context.Movies.Skip(skip).Take(take);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetMovieById(int id)
    {
        var movie = context.Movies.Find(id);
        if (movie is null)
            return NotFound();
        return Ok(movie);
    }
}