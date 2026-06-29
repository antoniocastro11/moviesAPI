using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesApi.Data;
using moviesApi.Data.Dtos.Movie;
using moviesApi.Models;
namespace moviesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController(MovieContext context, IMapper mapper) : ControllerBase
{
    private Movie? GetMovieAux(int id)
    {
        var movie = context.Movies.Find(id);
        return movie;
    }

    [HttpPost]
    public IActionResult AddMovie([FromBody] CreateMovieDto movieDto)
    {
        Movie movie = mapper.Map<Movie>(movieDto);
        context.Movies.Add(movie);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetMovieById),
        new { id = movie.Id }, movie);
    }

    [HttpGet]
    public IEnumerable<ReadMovieDto> GetMovies([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return mapper.Map<List<ReadMovieDto>>(context.Movies.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetMovieById(int id)
    {
        var movie = context.Movies.Find(id);
        if (movie is null)
            return NotFound();
        var movieDto = mapper.Map<ReadMovieDto>(movie);
        return Ok(movieDto);
    }

    // seguindo o fluxo do curso, para criar edição com patch precisamos de um pacote de nuget que não foi encontrado, por isso não foi implementado
    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieDto movieDto)
    {
        var movie = GetMovieAux(id);
        if (movie is null) return NotFound();
        mapper.Map(movieDto, movie);
        context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMovie(int id)
    {
        var movie = GetMovieAux(id);
        if(movie is null) return NotFound();
        context.Remove(movie);
        context.SaveChanges();
        return NoContent();
    }
}