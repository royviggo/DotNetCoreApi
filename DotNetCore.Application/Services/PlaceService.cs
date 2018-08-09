using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Model;
using DotNetCore.Application.Utils;
using DotNetCore.DataInterface;
using System.Collections.Generic;

namespace DotNetCore.Application.Services
{
    public class PlaceService : IPlaceService
    {
        private IUnitOfWork _unitOfWork;

        public PlaceService() { }

        public PlaceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PlaceDTO GetById(int id)
        {
            using (_unitOfWork)
            {
                var person = _unitOfWork.Places.Get(id);

                return PlaceMapper.MapPlaceToPlaceDto(person);
            }
        }

        public IEnumerable<PlaceDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var persons = _unitOfWork.Places.GetAll();

                return PlaceMapper.MapPlaceListToPlaceDTO(persons);
            }
        }

        public IEnumerable<PlaceDTO> FindByName(string name)
        {
            using (_unitOfWork)
            {
                var persons = _unitOfWork.Places.FindByName(name);

                return PlaceMapper.MapPlaceListToPlaceDTO(persons);
            }
        }

        public int Add(PlaceDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Add(PlaceMapper.MapPlaceDtoToPlace(person));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(PlaceDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Update(PlaceMapper.MapPlaceDtoToPlace(person));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(PlaceDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Remove(PlaceMapper.MapPlaceDtoToPlace(person));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(int personId)
        {
            using (_unitOfWork)
            {
                var person = _unitOfWork.Places.Get(personId);
                if (person == null)
                    return false;

                var result = _unitOfWork.Places.Remove(person);
                _unitOfWork.Save();

                return result;
            }
        }
    }
}
