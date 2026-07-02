using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using moviesApi.Data;
using moviesApi.Data.Dtos.Session;
using moviesApi.Models;

namespace moviesApi.Controllers;

[ApiController]
[Route("[Controller]")]

public class SessionController(MovieContext context, IMapper mapper) : ControllerBase
{

    public IActionResult CreateSession(CreateSessionDto dto)
    {
        Session session = mapper.Map<Session>(dto);
        context.Add(session);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetSessionById), new { movieId = session.MovieId, cinemaId = session.CinemaId }, session );
    }

    public IEnumerable<ReadSessionDto> GetSessions()
    {
        return mapper.Map<List<ReadSessionDto>>(context.Sessions.ToList());
    }


    [HttpGet("{movieId}/{cinemaId}")]
    public IActionResult GetSessionById(int movieId, int cinemaId)
    {
        var session = context.Sessions.FirstOrDefault(session => session.MovieId == movieId && session.CinemaId == cinemaId);
        if(session is null) return NotFound();
        ReadSessionDto sessionDto = mapper.Map<ReadSessionDto>(session);
        return Ok(sessionDto);

    }


}
