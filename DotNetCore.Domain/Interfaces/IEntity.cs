using System;

namespace DotNetCore.Domain.Interfaces
{
    public interface IEntity : IDisposable
    {
        int Id { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}