using System.Collections.Generic;
using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EventTypesController : ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;

        public EventTypesController(IEventTypeService eventTypeService)
        {
            _eventTypeService = eventTypeService;
        }

        // GET: api/eventtypes
        [HttpGet]
        public IEnumerable<EventTypeDTO> Get()
        {
            return _eventTypeService.GetAll();
        }

        // GET: api/eventtypes/5
        [HttpGet("{id}", Name = "GetEventTypeById")]
        public ActionResult<EventTypeDTO> Get(int id)
        {
            var eventType = _eventTypeService.GetById(id);
            if (eventType == null)
                return NotFound();

            return Ok(eventType);
        }

        // POST api/eventtypes
        [HttpPost]
        public IActionResult Post(EventTypeDTO eventType)
        {
            var result = _eventTypeService.Add(eventType);
            eventType.Id = result;

            return CreatedAtRoute("GetEventTypeById", new { id = eventType.Id }, eventType);
        }

        // PUT api/eventtypes
        [HttpPut]
        public IActionResult Put(EventTypeDTO eventType)
        {
            var result = _eventTypeService.Update(eventType);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

        // DELETE api/eventtypes/1
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _eventTypeService.Remove(id);
            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}
