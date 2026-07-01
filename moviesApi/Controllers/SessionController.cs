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

    public Session? GetSessionAux(int id)
    {
        var session = context.Sessions.Find(id);
        return session;
    }

    public IActionResult CreateSession(CreateSessionDto dto)
    {
        Session session = mapper.Map<Session>(dto);
        context.Add(session);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetSessionById), new { Id = session.Id}, session );
    }

    public IEnumerable<ReadSessionDto> GetSessions()
    {
        return mapper.Map<List<ReadSessionDto>>(context.Sessions.ToList());
    }


    public IActionResult GetSessionById(int id)
    {
        var session = GetSessionAux(id);
        if(session is null) return NotFound();
        ReadSessionDto sessionDto = mapper.Map<ReadSessionDto>(session);
        return Ok(sessionDto);

    }


}
