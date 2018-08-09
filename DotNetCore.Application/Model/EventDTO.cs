using GenDateTools;
using System;

namespace DotNetCore.Application.Model
{
    public class EventDTO
    {
        public int Id { get; set; }

        public int EventTypeId { get; set; }

        public EventTypeDTO EventType { get; set; }

        public int PersonId { get; set; }

        public PersonDTO Person { get; set; }

        public int PlaceId { get; set; }

        public PlaceDTO Place { get; set; }

        public GenDate Date { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
