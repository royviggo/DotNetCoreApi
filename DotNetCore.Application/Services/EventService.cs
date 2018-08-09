using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Model;
using DotNetCore.Application.Utils;
using DotNetCore.DataInterface;
using GenDateTools;
using System.Collections.Generic;

namespace DotNetCore.Application.Services
{
    public class EventService : IEventService
    {
        private IUnitOfWork _unitOfWork;

        public EventService() {}

        public EventService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public EventDTO GetById(int id)
        {
            using (_unitOfWork)
            {
                var evnt = _unitOfWork.Events.Get(id);

                return EventMapper.MapEventToEventDto(evnt);
            }
        }

        public IEnumerable<EventDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetAll();

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByPerson(int id)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPerson(id);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByPerson(IEnumerable<int> ids)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPerson(ids);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByDate(GenDate date)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByDate(date);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByEventTypeAndDate(int eventTypeId, GenDate date)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByEventTypeAndDate(eventTypeId, date);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByEventTypeAndDate(IEnumerable<int> eventTypeIds, GenDate date)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByEventTypeAndDate(eventTypeIds, date);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByPlace(int placeId)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPlace(placeId);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public IEnumerable<EventDTO> GetByPlace(IEnumerable<int> placeIds)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPlace(placeIds);

                return EventMapper.MapEventListToEventDTO(events);
            }
        }

        public int Add(EventDTO evnt)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Events.Add(EventMapper.MapEventDtoToEvent(evnt));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(EventDTO evnt)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Events.Update(EventMapper.MapEventDtoToEvent(evnt));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(EventDTO evnt)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Events.Remove(EventMapper.MapEventDtoToEvent(evnt));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(int id)
        {
            using (_unitOfWork)
            {
                var evnt = _unitOfWork.Events.Get(id);
                if (evnt == null)
                    return false;

                var result = _unitOfWork.Events.Remove(evnt);
                _unitOfWork.Save();

                return result;
            }
        }
    }
}
