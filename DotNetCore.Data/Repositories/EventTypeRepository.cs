using DotNetCore.Domain.Entities;
using DotNetCore.DataInterface;
using DotNetCore.Data.Interfaces;
using System.Data;

namespace DotNetCore.Data.Repositories
{
    public class EventTypeRepository : GenericRepository<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(IDbFactory dbFactory, IDbTransaction transaction) : base(dbFactory, transaction)
        {
        }
    }
}
