using DotNetCore.Application.Model;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.Application.Interfaces;
using System.Collections.Generic;

namespace DotNetCore.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/persons
        [HttpGet]
        public IEnumerable<PersonDTO> Get()
        {
            return _personService.GetAll();
        }

        // GET api/persons/1
        [HttpGet("{id:int}", Name = "GetPersonById")]
        public ActionResult<PersonDTO> Get(int id)
        {
            var person = _personService.GetById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        // GET api/persons/name
        [HttpGet("{name:alpha}")]
        public IEnumerable<PersonDTO> Get(string name)
        {
            return _personService.FindByName(name);
        }

        // POST api/persons
        [HttpPost]
        public IActionResult Post(PersonDTO person)
        {
            var result = _personService.Add(person);
            person.Id = result;

            return CreatedAtRoute("GetPersonById", new { id = person.Id }, person);
        }

        // PUT api/persons
        [HttpPut]
        public IActionResult Put(PersonDTO person)
        {
            var result = _personService.Update(person);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

        // DELETE api/persons/1
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _personService.Remove(id);
            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}