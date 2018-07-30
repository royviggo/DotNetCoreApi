using DotNetCore.Domain.Enums;
using System;

namespace DotNetCore.Application.Model
{
    public class PersonDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string FatherName { get; set; }

        public string Patronym { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public int? BornYear { get; set; }

        public int? DeathYear { get; set; }

        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
