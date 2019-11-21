using DotNetCore.Business.Models;
using System.Collections.Generic;

namespace DotNetCore.Business.Interfaces
{
    public interface IEventTypeService
    {
        EventTypeDTO GetById(int id);
        IEnumerable<EventTypeDTO> GetAll();
        int Add(EventTypeDTO eventType);
        bool Update(EventTypeDTO eventType);
        bool Remove(EventTypeDTO eventType);
        bool Remove(int eventTypeId);
    }
}
