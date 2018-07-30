using GenDateTools;

namespace DotNetCore.Domain.Entities
{
    public class Event : Entity
    {
        public int EventTypeId { get; set; }

        public EventType EventType { get; set; }

        public int PersonId { get; set; }

        //public Person Person { get; set; }

        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public GenDate Date { get; set; }

        public string Description { get; set; }
    }
}
