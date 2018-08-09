using DotNetCore.Domain.Entities;
using DotNetCore.DataInterface;
using DotNetCore.Data.Interfaces;
using System.Data;
using System.Collections.Generic;
using DotNetCore.Data.Utils;

namespace DotNetCore.Data.Repositories
{
    public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
    {
        public PlaceRepository(IDbFactory dbFactory, IDbTransaction transaction) : base(dbFactory, transaction)
        {
        }

        public IEnumerable<Place> FindByName(string name)
        {
            var sql = GetBaseQuery().Where("Name like @Name");

            return GetListSql(sql, param: new { Name = "%" + name + "%" });
        }
    }
}
