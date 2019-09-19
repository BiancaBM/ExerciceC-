using ConsoleApp1.Contracts;
using System;
using System.Collections.Generic;
using static ConsoleApp1.Enums;

namespace ConsoleApp1.Services 
{
    public class UserService : IUserService
    {
        public IEnumerable<User> MajorPerson(IEnumerable<User> users)
        {
            var persons = new List<User>();
            foreach (User pers in users)
            {
                if ((DateTime.UtcNow.Year - pers.BirthDate.Year) >= 18)
                {
                    persons.Add(pers);
                }
            }
            return persons;

        }

        public IEnumerable<User> FemalePension(IEnumerable<User> users)
        {
            var femalpers = new List<User>();
#warning Biencutzo, aici treci la urmatorul nivel, using linq madam :))
            // perfect cu foreach. insa acum vreau sa folosesti linq, fluentApi... adica acela cu .Where(....)
            // incearca pentru ambele foreach-uri, de aici si din MajorPerson
            // daca nu reusesti, iti dau eu exemplu pentru unu din ele, sau mici ponturi
            foreach (User pers in users)
            {
                if ((pers.Gender == EGender.F) && (DateTime.UtcNow.Year - pers.BirthDate.Year) >= 60)
                {
                    femalpers.Add(pers);
                }
            }

            return femalpers;
        }

    }
}
