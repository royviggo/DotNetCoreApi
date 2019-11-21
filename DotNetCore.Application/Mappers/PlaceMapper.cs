using DotNetCore.Application.Models;
using DotNetCore.Data.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Mappers
{
    public static class PlaceMapper
    {
        public static PlaceDTO ToPlaceDto(this Place place)
        {
            return new PlaceDTO
            {
                Id = place.Id,
                Name = place.Name,
                CreatedDate = place.CreatedDate,
                ModifiedDate = place.ModifiedDate,
            };
        }

        public static IEnumerable<PlaceDTO> ToPlaceDTO(this IEnumerable<Place> places)
        {
            var placeDtos = new List<PlaceDTO>();

            foreach (var place in places)
                placeDtos.Add(place.ToPlaceDto());

            return placeDtos;
        }

        public static Place ToPlace(this PlaceDTO place)
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
