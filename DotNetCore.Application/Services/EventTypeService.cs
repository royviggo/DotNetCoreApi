using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Model;
using DotNetCore.Application.Utils;
using DotNetCore.DataInterface;
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

                return EventTypeMapper.MapEventTypeToEventTypeDto(eventType);
            }
        }

        public IEnumerable<EventTypeDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var eventTypes = _unitOfWork.EventTypes.GetAll();

                return EventTypeMapper.MapEventTypeListToEventTypeDTO(eventTypes);
            }
        }

        public int Add(EventTypeDTO eventType)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.EventTypes.Add(EventTypeMapper.MapEventTypeDtoToEventType(eventType));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(EventTypeDTO eventType)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.EventTypes.Update(EventTypeMapper.MapEventTypeDtoToEventType(eventType));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(EventTypeDTO eventType)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.EventTypes.Remove(EventTypeMapper.MapEventTypeDtoToEventType(eventType));
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
