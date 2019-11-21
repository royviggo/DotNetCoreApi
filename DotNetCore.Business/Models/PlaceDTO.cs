using System;

namespace DotNetCore.Business.Models
{
    public class PlaceDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
