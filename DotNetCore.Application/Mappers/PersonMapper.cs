using DotNetCore.Application.Models;
using DotNetCore.Data.Entities;
using System.Collections.Generic;

namespace DotNetCore.Application.Mappers
{
    public static class PersonMapper
    {
        public static PersonDTO ToPersonDto(this Person person)
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

        public static IEnumerable<PersonDTO> ToPersonDto(this IEnumerable<Person> persons)
        {
            var personDtos = new List<PersonDTO>();

            foreach (var person in persons)
                personDtos.Add(person.ToPersonDto());

            return personDtos;
        }

        public static Person ToPerson(this PersonDTO person)
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
