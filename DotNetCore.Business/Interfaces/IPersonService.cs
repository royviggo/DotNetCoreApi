using DotNetCore.Business.Models;
using System.Collections.Generic;

namespace DotNetCore.Business.Interfaces
{
    public interface IPersonService
    {
        PersonDTO GetById(int id);
        IEnumerable<PersonDTO> GetAll();
        IEnumerable<PersonDTO> FindByName(string name);
        int Add(PersonDTO person);
        bool Update(PersonDTO person);
        bool Remove(PersonDTO person);
        bool Remove(int personId);
    }
}
