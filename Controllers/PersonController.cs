using Microsoft.AspNetCore.Mvc;
using RestAPI.Business;
using RestAPI.Models;

namespace RestAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private IPersonBusiness _personBusiness;
    public PersonController(IPersonBusiness personService)
    {
        _personBusiness = personService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Person>>> GetAll()
    {
       return  Ok(await _personBusiness.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Person>> GetById(int id)
    {
        var person = await _personBusiness.GetByIdAsyn(id);
        if(person is null)
            return NotFound();
        return  Ok(person);
    }

    [HttpPost]
    public async Task<ActionResult<Person>> Create([FromBody] Person person)
    {
        if(person is null)
            return BadRequest();

        return Ok(await _personBusiness.CreatePesonAsyn(person));
    }

    [HttpPut]
    public async Task<ActionResult<Person>> Put([FromBody] Person person)
    {
        if(person is null)
            return BadRequest();

        return Ok(await _personBusiness.UpdatePerson(person));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Person>> Delete(int id)
    {
        return  NoContent();
    }
}