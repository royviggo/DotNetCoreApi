using DotNetCore.Domain.Entities;
using System;

namespace DotNetCore.DataInterface
{
    public interface IEventTypeRepository : IGenericRepository<EventType>, IDisposable
    {
    }
}
