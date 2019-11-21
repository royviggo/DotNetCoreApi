using DotNetCore.Application.Models;
using GenDateTools;
using System.Collections.Generic;

namespace DotNetCore.Application.Interfaces
{
    public interface IEventService
    {
        EventDTO GetById(int id);
        IEnumerable<EventDTO> GetAll();

        IEnumerable<EventDTO> GetByPerson(int id);
        IEnumerable<EventDTO> GetByPerson(IEnumerable<int> ids);

        IEnumerable<EventDTO> GetByDate(GenDate date);

        IEnumerable<EventDTO> GetByEventTypeAndDate(int eventTypeId, GenDate date);
        IEnumerable<EventDTO> GetByEventTypeAndDate(IEnumerable<int> eventTypeIds, GenDate date);

        IEnumerable<EventDTO> GetByPlace(int placeId);
        IEnumerable<EventDTO> GetByPlace(IEnumerable<int> placeIds);

        int Add(EventDTO evnt);
        bool Update(EventDTO evnt);
        bool Remove(EventDTO evnt);
        bool Remove(int id);
    }
}