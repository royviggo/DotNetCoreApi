using System;

namespace DotNetCore.Business.Models
{
    public class EventTypeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string GedcomTag { get; set; }

        public string Sentence { get; set; }

        public bool IsFamilyEvent { get; set; }

        public bool UseDate { get; set; }

        public bool UsePlace { get; set; }

        public bool UseDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
