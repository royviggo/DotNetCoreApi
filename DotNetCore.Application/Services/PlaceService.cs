using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Mappers;
using DotNetCore.Application.Models;
using DotNetCore.Data.Interfaces;
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

                return place?.ToPlaceDto();
            }
        }

        public IEnumerable<PlaceDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var places = _unitOfWork.Places.GetAll();

                return places?.ToPlaceDTO();
            }
        }

        public IEnumerable<PlaceDTO> FindByName(string name)
        {
            using (_unitOfWork)
            {
                var places = _unitOfWork.Places.FindByName(name);

                return places?.ToPlaceDTO();
            }
        }

        public int Add(PlaceDTO place)
        {
            if (place == null) throw new System.ArgumentNullException(nameof(place));

            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Add(place.ToPlace());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(PlaceDTO place)
        {
            if (place == null) throw new System.ArgumentNullException(nameof(place));

            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Update(place.ToPlace());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(PlaceDTO place)
        {
            if (place == null) throw new System.ArgumentNullException(nameof(place));

            using (_unitOfWork)
            {
                var result = _unitOfWork.Places.Remove(place.ToPlace());
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
