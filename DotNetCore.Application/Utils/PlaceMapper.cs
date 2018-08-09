using DotNetCore.Application.Model;
using DotNetCore.Domain.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Utils
{
    public class PlaceMapper
    {
        public static PlaceDTO MapPlaceToPlaceDto(Place place)
        {
            return new PlaceDTO
            {
                Id = place.Id,
                Name = place.Name,
                CreatedDate = place.CreatedDate,
                ModifiedDate = place.ModifiedDate,
            };
        }

        public static IEnumerable<PlaceDTO> MapPlaceListToPlaceDTO(IEnumerable<Place> places)
        {
            var placeDtos = new List<PlaceDTO>();

            foreach (var place in places)
                placeDtos.Add(MapPlaceToPlaceDto(place));

            return placeDtos;
        }

        public static Place MapPlaceDtoToPlace(PlaceDTO place)
        {
            return new Place
            {
                Id = place.Id,
                Name = place.Name,
                CreatedDate = place.CreatedDate,
                ModifiedDate = place.ModifiedDate,
            };
        }
    }
}
