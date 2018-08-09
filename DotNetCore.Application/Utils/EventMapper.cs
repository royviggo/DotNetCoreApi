using DotNetCore.Application.Model;
using DotNetCore.Domain.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Utils
{
    public class EventMapper
    {
        public static EventDTO MapEventToEventDto(Event evnt)
        {
            return new EventDTO
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

        public static IEnumerable<EventDTO> MapEventListToEventDTO(IEnumerable<Event> events)
        {
            var eventDtos = new List<EventDTO>();

            foreach (var evnt in events)
                eventDtos.Add(MapEventToEventDto(evnt));

            return eventDtos;
        }

        public static Event MapEventDtoToEvent(EventDTO evnt)
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
