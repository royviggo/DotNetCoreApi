using DotNetCore.Application.Models;
using DotNetCore.Data.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Mappers
{
    public static class EventTypeMapper
    {
        public static EventTypeDTO ToEventTypeDto(this EventType eventType)
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

        public static IEnumerable<EventTypeDTO> ToEventTypeDTO(this IEnumerable<EventType> eventType)
        {
            var eventTypeDtos = new List<EventTypeDTO>();

            foreach (var place in eventType)
                eventTypeDtos.Add(ToEventTypeDto(place));

            return eventTypeDtos;
        }

        public static EventType ToEventType(this EventTypeDTO eventType)
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
