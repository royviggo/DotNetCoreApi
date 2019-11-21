using DotNetCore.Data.Interfaces;
using DotNetCore.Business.Interfaces;
using DotNetCore.Business.Mappers;
using DotNetCore.Business.Models;
using System.Collections.Generic;

namespace DotNetCore.Business.Services
{
    public class PersonService : IPersonService
    {
        private IUnitOfWork _unitOfWork;

        public PersonService() { }

        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PersonDTO GetById(int id)
        {
            using (_unitOfWork)
            {
                var person = _unitOfWork.Persons.Get(id);

                return person?.ToPersonDto();
            }
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var persons = _unitOfWork.Persons.GetAll();

                return persons?.ToPersonDto();
            }
        }

        public IEnumerable<PersonDTO> FindByName(string name)
        {
            using (_unitOfWork)
            {
                var persons = _unitOfWork.Persons.FindByName(name);

                return persons?.ToPersonDto();
            }
        }

        public int Add(PersonDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Persons.Add(PersonMapper.ToPerson(person));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(PersonDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Persons.Update(person.ToPerson());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(PersonDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Persons.Remove(person.ToPerson());
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(int personId)
        {
            using (_unitOfWork)
            {
                var person = _unitOfWork.Persons.Get(personId);
                if (person == null)
                    return false;

                var result = _unitOfWork.Persons.Remove(person);
                _unitOfWork.Save();

                return result;
            }
        }
    }
}
