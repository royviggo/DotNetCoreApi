using DotNetCore.Application.Model;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.Application.Interfaces;
using System.Collections.Generic;

namespace DotNetCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/person
        [HttpGet]
        public IEnumerable<PersonDTO> Get()
        {
            return _personService.GetAll();
        }

        // GET api/person/1
        [HttpGet("{id}")]
        public ActionResult<PersonDTO> Get(int id)
        {
            return _personService.GetById(id);
        }

    }
}