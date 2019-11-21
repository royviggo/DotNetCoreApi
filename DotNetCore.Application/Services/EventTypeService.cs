using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Mappers;
using DotNetCore.Application.Models;
using DotNetCore.Data.Interfaces;
using System.Collections.Generic;

namespace DotNetCore.Application.Services
{
    public class EventTypeService : IEventTypeService
    {
        private IUnitOfWork _unitOfWork;

        public EventTypeService() { }

        public EventTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public EventTypeDTO GetById(int id)
        {
            using (_unitOfWork)
            {
                var eventType = _unitOfWork.EventTypes.Get(id);

                return eventType?.ToEventTypeDto();
            }
        }

        public IEnumerable<EventTypeDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var eventTypes = _unitOfWork.EventTypes.GetAll();

                return eventTypes?.ToEventTypeDTO();
            }
        }

        public int Add(EventTypeDTO eventType)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.EventTypes.Add(eventType.ToEventType());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(EventTypeDTO eventType)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.EventTypes.Update(eventType.ToEventType());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(EventTypeDTO eventType)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.EventTypes.Remove(eventType.ToEventType());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(int eventTypeId)
        {
            using (_unitOfWork)
            {
                var eventType = _unitOfWork.EventTypes.Get(eventTypeId);
                if (eventType == null)
                    return false;

                var result = _unitOfWork.EventTypes.Remove(eventType);
                _unitOfWork.Save();

                return result;
            }
        }

    }
}
