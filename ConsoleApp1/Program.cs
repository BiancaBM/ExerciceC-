using ConsoleApp1.Contracts;
using ConsoleApp1.Enums;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<User> userList = new List<User>() {
                        new User() { Name = "John", LastName = "Aha", BirthDate = new DateTime(2008, 5, 21) , Gender = EGender.M } ,
                        new User() { Name = "Mara", LastName = "Hahaa", BirthDate = new DateTime(1940, 2, 4) , Gender = EGender.F } ,
                        new User() { Name = "Ioana", LastName = "Bala", BirthDate = new DateTime(1950, 12, 3) , Gender = EGender.F } ,
                        new User() { Name = "Bianca", LastName = "Maria", BirthDate = new DateTime(1991, 9, 24) , Gender = EGender.F }
            };

            IUserService userService = new UserService();

            IEnumerable<User> femalePension = userService.FemalePension(userList);
            IEnumerable<User> majorPerson = userService.MajorPerson(userList);


            Console.WriteLine("Femei pensinate: ");

            foreach (User fem in femalePension)
            {
                Console.WriteLine("{0} {1}", fem.Name, fem.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("Persoane majore");

            foreach (User pers in majorPerson)
            {
                Console.WriteLine("{0} {1}", pers.Name, pers.LastName);
            }
        }
    }
}
