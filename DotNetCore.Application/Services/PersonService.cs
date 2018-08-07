using DotNetCore.DataInterface;
using DotNetCore.Application.Interfaces;
using DotNetCore.Application.Utils;
using DotNetCore.Application.Model;
using System.Collections.Generic;

namespace DotNetCore.Application.Services
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

                return PersonMapper.MapPersonToPersonDto(person);
            }
        }

        public IEnumerable<PersonDTO> GetAll()
        {
            using (_unitOfWork)
            {
                var persons = _unitOfWork.Persons.GetAll();

                return PersonMapper.MapPersonListToPersonDto(persons);
            }
        }

        public IEnumerable<PersonDTO> FindByName(string name)
        {
            using (_unitOfWork)
            {
                var persons = _unitOfWork.Persons.FindByName(name);

                return PersonMapper.MapPersonListToPersonDto(persons);
            }
        }

        public int Add(PersonDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Persons.Add(PersonMapper.MapPersonDtoToPerson(person));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Update(PersonDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Persons.Update(PersonMapper.MapPersonDtoToPerson(person));
                _unitOfWork.Save();

                return result;
            }
        }

        public bool Remove(PersonDTO person)
        {
            using (_unitOfWork)
            {
                var result = _unitOfWork.Persons.Remove(PersonMapper.MapPersonDtoToPerson(person));
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
