using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moviesApi.Data;
using moviesApi.Data.Dtos.Cinema;
using moviesApi.Models;

namespace moviesApi.Controllers;

[ApiController]
[Route("[Controller]")]

public class CinemaController(MovieContext context, IMapper mapper) : ControllerBase
{

    private Cinema? GetCinemaAux(int id)
    {
        var cinema = context.Cinemas.Find(id);
        return cinema;
    }

    [HttpPost]
    public IActionResult CreateCinema([FromBody]CreateCinemaDto cinemaDto)
    {
        Cinema cinema = mapper.Map<Cinema>(cinemaDto);
        context.Cinemas.Add(cinema);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetCinemaById),
        new { id = cinema.Id }, cinema);
    }

    [HttpGet]
    public IEnumerable<ReadCinemaDto> GetCinemas([FromQuery] int skip = 0, [FromQuery] int take = 10, [FromQuery] int? addressId = null)
    {
        if (addressId is null) {
            return mapper.Map<List<ReadCinemaDto>>(context.Cinemas.Skip(skip).Take(take));
        }
        return mapper.Map<List<ReadCinemaDto>>(context.Cinemas.FromSqlRaw($"SELECT Id, Name, AddressId FROM Cinemas WHERE Cinemas.AddressId = {addressId}").ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetCinemaById(int id) {
        var cinema = GetCinemaAux(id);
        if (cinema is null) return NotFound();
        var cinemaDto = mapper.Map<ReadCinemaDto>(cinema);
        return Ok(cinemaDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCinema(int id, [FromBody] UpdateCinemaDto cinemaDto) {

        var cinema = GetCinemaAux(id);
        if (cinema is null) return NotFound();
        mapper.Map(cinemaDto, UpdateCinema);
        context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCinemaById(int id)
    {
        var cinema = GetCinemaAux(id);
        if (cinema is null) return NotFound();
        context.Remove(cinema);
        context.SaveChanges();
        return NoContent();
    }
}