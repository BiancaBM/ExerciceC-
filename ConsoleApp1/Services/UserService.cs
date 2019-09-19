using ConsoleApp1.Contracts;
using System;
using System.Collections.Generic;
using ConsoleApp1.Enums;
using System.Linq;

namespace ConsoleApp1.Services 
{
    public class UserService : IUserService
    {
        public IEnumerable<User> MajorPerson(IEnumerable<User> users)
        {
           
            var majorPers = users.Where(pers => (DateTime.UtcNow.Year - pers.BirthDate.Year) >= 18).ToList<User>();

            return majorPers;

        }

        public IEnumerable<User> FemalePension(IEnumerable<User> users)
        {
            var femalpers = users.Where(pers => pers.Gender == EGender.F && (DateTime.UtcNow.Year - pers.BirthDate.Year) >= 60).ToList<User>();
                                  
            return femalpers;
        }

    }
}
