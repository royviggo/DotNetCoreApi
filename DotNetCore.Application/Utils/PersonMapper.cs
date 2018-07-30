using DotNetCore.Application.Model;
using DotNetCore.Domain.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Utils
{
    public static class PersonMapper
    {
        public static PersonDTO MapPersonToPersonDto(Person person)
        {
            return new PersonDTO
            {
                Id = person.Id,
                FirstName = person.FirstName,
                FatherName = person.FatherName,
                Patronym = person.Patronym,
                LastName = person.LastName,
                Gender = person.Gender,
                BornYear = person.BornYear,
                DeathYear = person.DeathYear,
                Status = person.Status,
                CreatedDate = person.CreatedDate,
                ModifiedDate = person.ModifiedDate,
            };
        }

        public static IEnumerable<PersonDTO> MapPersonListToPersonDto(IEnumerable<Person> persons)
        {
            var personDtos = new List<PersonDTO>();

            foreach (var person in persons)
                personDtos.Add(MapPersonToPersonDto(person));

            return personDtos;
        }

        public static Person MapPersonDtoToPerson(PersonDTO person)
        {
            return new Person
            {
                Id = person.Id,
                FirstName = person.FirstName,
                FatherName = person.FatherName,
                Patronym = person.Patronym,
                LastName = person.LastName,
                Gender = person.Gender,
                BornYear = person.BornYear,
                DeathYear = person.DeathYear,
                Status = person.Status,
                CreatedDate = person.CreatedDate,
                ModifiedDate = person.ModifiedDate,
            };
        }
    }
}
