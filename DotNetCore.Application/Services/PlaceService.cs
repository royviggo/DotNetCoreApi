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
                var place = _unitOfWork.Places.Get(id);

                return PlaceMapper.MapPlaceToPlaceDto(place);
            }
        }

        public IEnumerable<PlaceDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var places = _unitOfWork.Places.GetAll();

                return PlaceMapper.MapPlaceListToPlaceDTO(places);
            }
        }

        public IEnumerable<PlaceDTO> FindByName(string name)
        {
            using (_unitOfWork)
            {
                var places = _unitOfWork.Places.FindByName(name);

                return PlaceMapper.MapPlaceListToPlaceDTO(places);
            }
        }

        public int Add(PlaceDTO place)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Add(PlaceMapper.MapPlaceDtoToPlace(place));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(PlaceDTO place)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Update(PlaceMapper.MapPlaceDtoToPlace(place));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(PlaceDTO place)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Remove(PlaceMapper.MapPlaceDtoToPlace(place));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(int placeId)
        {
            using (_unitOfWork)
            {
                var place = _unitOfWork.Places.Get(placeId);
                if (place == null)
                    return false;

                var result = _unitOfWork.Places.Remove(place);
                _unitOfWork.Save();

                return result;
            }
        }
    }
}
