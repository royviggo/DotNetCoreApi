using DotNetCore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DotNetCore.DataInterface
{
    public interface IPlaceRepository : IGenericRepository<Place>, IDisposable
    {
        IEnumerable<Place> FindByName(string name);
    }
}
