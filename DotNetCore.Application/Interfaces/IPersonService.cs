using DotNetCore.Application.Model;
using System.Collections.Generic;

namespace DotNetCore.Application.Interfaces
{
    public interface IPersonService
    {
        PersonDTO GetById(int id);
        IEnumerable<PersonDTO> GetAll();
    }
}
