using DotNetCore.Domain.Entities;
using System.Collections.Generic;

namespace DotNetCore.DataInterface
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        IEnumerable<Person> FindByName(string name);
    }
}
