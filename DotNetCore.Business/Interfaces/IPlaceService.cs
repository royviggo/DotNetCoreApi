using DotNetCore.Business.Models;
using System.Collections.Generic;

namespace DotNetCore.Business.Interfaces
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
