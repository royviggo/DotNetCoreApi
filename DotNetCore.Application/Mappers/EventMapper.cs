using DotNetCore.Application.Models;
using DotNetCore.Data.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Mappers
{
    public static class EventMapper
    {
        public static EventDTO ToEventDto(this Event evnt)
        {
            return new EventDTO
            {
                Id = evnt.Id,
                EventTypeId = evnt.EventTypeId,
                EventType = evnt.EventType?.ToEventTypeDto(),
                PersonId = evnt.PersonId,
                Person = evnt.Person?.ToPersonDto(),
                PlaceId = evnt.PlaceId,
                Place = evnt.Place.ToPlaceDto(),
                Date = evnt.Date,
                Description = evnt.Description,
                CreatedDate = evnt.CreatedDate,
                ModifiedDate = evnt.ModifiedDate,
            };
        }

        public static IEnumerable<EventDTO> ToEventDTO(this IEnumerable<Event> events)
        {
            var eventDtos = new List<EventDTO>();

            foreach (var evnt in events)
                eventDtos.Add(evnt.ToEventDto());

            return eventDtos;
        }

        public static Event ToEvent(this EventDTO evnt)
        {
            return new Event

            {
                Id = evnt.Id,
                EventTypeId = evnt.EventTypeId,
                PersonId = evnt.PersonId,
                PlaceId = evnt.PlaceId,
                Date = evnt.Date,
                Description = evnt.Description,
                CreatedDate = evnt.CreatedDate,
                ModifiedDate = evnt.ModifiedDate,
            };
        }
    }
}
