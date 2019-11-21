using System.Collections.Generic;
using System.Net.Mime;
using DotNetCore.Business.Interfaces;
using DotNetCore.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.WebApi.Controllers
{
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlaceService _placeService;

        public PlacesController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        // GET: api/places
        [HttpGet]
        public IEnumerable<PlaceDTO> Get()
        {
            return _placeService.GetAll();
        }

        // GET api/places/1
        [HttpGet("{id:int}", Name = "GetPlaceById")]
        public ActionResult<PlaceDTO> Get(int id)
        {
            var place = _placeService.GetById(id);
            if (place == null)
                return NotFound();

            return Ok(place);
        }

        // GET api/places/name
        [HttpGet("{name:alpha}")]
        public IEnumerable<PlaceDTO> Get(string name)
        {
            return _placeService.FindByName(name);
        }

        // POST api/places
        [HttpPost]
        public IActionResult Post(PlaceDTO place)
        {
            var result = _placeService.Add(place);
            place.Id = result;

            return CreatedAtRoute("GetPlaceById", new { id = place.Id }, place);
        }

        // PUT api/places
        [HttpPut]
        public IActionResult Put(PlaceDTO person)
        {
            var result = _placeService.Update(person);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

        // DELETE api/places/1
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _placeService.Remove(id);
            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}
