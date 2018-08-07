using DotNetCore.Application.Model;
using System.Collections.Generic;

namespace DotNetCore.Application.Interfaces
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
