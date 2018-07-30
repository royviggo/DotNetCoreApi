using DotNetCore.Domain.Entities;
using System;

namespace DotNetCore.DataInterface
{
    public interface IPlaceRepository : IGenericRepository<Place>, IDisposable
    {
    }
}
