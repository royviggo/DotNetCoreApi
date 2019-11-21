using DotNetCore.Data.Entities;
using System;
using System.Collections.Generic;

namespace DotNetCore.Data.Interfaces
{
    public interface IPlaceRepository : IGenericRepository<Place>, IDisposable
    {
        IEnumerable<Place> FindByName(string name);
    }
}
