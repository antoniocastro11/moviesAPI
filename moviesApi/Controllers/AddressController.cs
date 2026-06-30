using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesApi.Data;
using moviesApi.Data.Dtos.Address;
using moviesApi.Models;

namespace moviesApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class AddressController(MovieContext context, IMapper mapper) : ControllerBase
{
    private Address? GetAddressAux(int id)
    {
        var address = context.Addresses.Find(id);
        return address;
    }

    [HttpPost]
    public IActionResult CreateAddress([FromBody]CreateAddressDto addressDto )
    {
        var address = mapper.Map<Address>(addressDto);
        context.Addresses.Add(address);
        context.SaveChanges();
        return CreatedAtAction(nameof(GetAddressById),
            new { id = address.Id }, address);
    }

    [HttpGet]
    public IEnumerable<ReadAddressDto> GetAddresses([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return mapper.Map<List<ReadAddressDto>>(context.Addresses.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetAddressById([FromBody]int id)
    {
        var address = GetAddressAux(id);
        if (address is null) return NotFound();
        var addressDto = mapper.Map<ReadAddressDto>(address);
        return Ok(addressDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAddress(int id, [FromBody] UpdateAddressDto addressDto)
    {
        var address = GetAddressAux(id);
        if (address is null) return NotFound();
        mapper.Map<UpdateAddressDto>(address);
        context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAddress(int id)
    {
        var address = GetAddressAux(id);
        if (address is null) return NotFound();
        context.Remove(address);
        context.SaveChanges();
        return NoContent();
    }
}