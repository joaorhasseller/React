using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;
using RestAPI.Service;

namespace RestAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private IPersonService _personService;
    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Person>>> GetAll()
    {
       return  Ok(await _personService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Person>> GetById(int id)
    {
        var person = await _personService.GetByIdAsyn(id);
        if(person is null)
            return NotFound();
        return  Ok(person);
    }

    [HttpPost]
    public async Task<ActionResult<Person>> Create([FromBody] Person person)
    {
        if(person is null)
            return BadRequest();

        return Ok(await Task.FromResult(_personService.CreatePesonAsyn(person)));
    }

    [HttpPut]
    public async Task<ActionResult<Person>> Put([FromBody] Person person)
    {
        if(person is null)
            return BadRequest();

        return Ok(await Task.FromResult(_personService.UpdatePerson(person)));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Person>> Delete(int id)
    {
        return  NoContent();
    }
}