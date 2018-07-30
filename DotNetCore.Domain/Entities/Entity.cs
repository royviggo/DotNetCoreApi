using DotNetCore.Domain.Interfaces;
using System;

namespace DotNetCore.Domain.Entities
{
    public class Entity : IEntity
    {
        public void Dispose() { }

        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
