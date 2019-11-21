using DotNetCore.Application.Models;
using System.Collections.Generic;

namespace DotNetCore.Application.Interfaces
{
    public interface IPlaceService
    {
        PlaceDTO GetById(int id);
        IEnumerable<PlaceDTO> GetAll();
        IEnumerable<PlaceDTO> FindByName(string name);
        int Add(PlaceDTO person);
        bool Update(PlaceDTO person);
        bool Remove(PlaceDTO person);
        bool Remove(int personId);
    }
}
