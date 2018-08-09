using System;

namespace DotNetCore.Application.Model
{
    public class PlaceDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
