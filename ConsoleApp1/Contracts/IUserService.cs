using System.Collections.Generic;

namespace ConsoleApp1.Contracts
{
    interface IUserService
    {
        IEnumerable<User> MajorPerson(IEnumerable<User> users);
        IEnumerable<User> FemalePension(IEnumerable<User> users);
    }
}
