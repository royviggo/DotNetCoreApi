using System.Collections.Generic;
using System.Net.Mime;
using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.WebApi.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET: api/events
        [HttpGet]
        public IEnumerable<EventDTO> Get()
        {
            return _eventService.GetAll();
        }

        // GET: api/events/5
        [HttpGet("{id}", Name = "GetEventById")]
        public ActionResult<EventDTO> Get(int id)
        {
            var evnt = _eventService.GetById(id);
            if (evnt == null)
                return NotFound();

            return Ok(evnt);
        }

        // POST: api/events
        [HttpPost]
        public IActionResult Post(EventDTO evnt)
        {
            var result = _eventService.Add(evnt);
            evnt.Id = result;

            return CreatedAtRoute("GetEventById", new { id = evnt.Id }, evnt);
        }

        // PUT api/events
        [HttpPut]
        public IActionResult Put(EventDTO evnt)
        {
            var result = _eventService.Update(evnt);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

        // DELETE api/events/1
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _eventService.Remove(id);
            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}
