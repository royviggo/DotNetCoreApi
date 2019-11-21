using DotNetCore.Business.Interfaces;
using DotNetCore.Business.Mappers;
using DotNetCore.Business.Models;
using DotNetCore.Data.Interfaces;
using GenDateTools;
using System.Collections.Generic;

namespace DotNetCore.Business.Services
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

                return evnt?.ToEventDto();
            }
        }

        public IEnumerable<EventDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetAll();

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByPerson(int id)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPerson(id);

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByPerson(IEnumerable<int> ids)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPerson(ids);

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByDate(GenDate date)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByDate(date);

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByEventTypeAndDate(int eventTypeId, GenDate date)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByEventTypeAndDate(eventTypeId, date);

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByEventTypeAndDate(IEnumerable<int> eventTypeIds, GenDate date)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByEventTypeAndDate(eventTypeIds, date);

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByPlace(int placeId)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPlace(placeId);

                return events?.ToEventDTO();
            }
        }

        public IEnumerable<EventDTO> GetByPlace(IEnumerable<int> placeIds)
        {
            using (_unitOfWork)
            {
                var events = _unitOfWork.Events.GetByPlace(placeIds);

                return events?.ToEventDTO();
            }
        }

        public int Add(EventDTO evnt)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Events.Add(evnt.ToEvent());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(EventDTO evnt)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Events.Update(evnt.ToEvent());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(EventDTO evnt)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Events.Remove(evnt.ToEvent());
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
