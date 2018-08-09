using DotNetCore.Application.Model;
using DotNetCore.Domain.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Utils
{
    public class EventTypeMapper
    {
        public static EventTypeDTO MapEventTypeToEventTypeDto(EventType eventType)
        {
            return new EventTypeDTO
            {
                Id = eventType.Id,
                Name = eventType.Name,
                GedcomTag = eventType.GedcomTag,
                Sentence = eventType.Sentence,
                IsFamilyEvent = eventType.IsFamilyEvent,
                UseDate = eventType.UseDate,
                UsePlace = eventType.UsePlace,
                UseDescription = eventType.UseDescription,
                CreatedDate = eventType.CreatedDate,
                ModifiedDate = eventType.ModifiedDate,
            };
        }

        public static IEnumerable<EventTypeDTO> MapEventTypeListToEventTypeDTO(IEnumerable<EventType> eventType)
        {
            var eventTypeDtos = new List<EventTypeDTO>();

            foreach (var place in eventType)
                eventTypeDtos.Add(MapEventTypeToEventTypeDto(place));

            return eventTypeDtos;
        }

        public static EventType MapEventTypeDtoToEventType(EventTypeDTO eventType)
        {
            return new EventType
            {
                Id = eventType.Id,
                Name = eventType.Name,
                GedcomTag = eventType.GedcomTag,
                Sentence = eventType.Sentence,
                IsFamilyEvent = eventType.IsFamilyEvent,
                UseDate = eventType.UseDate,
                UsePlace = eventType.UsePlace,
                UseDescription = eventType.UseDescription,
                CreatedDate = eventType.CreatedDate,
                ModifiedDate = eventType.ModifiedDate,
            };
        }
    }
}
