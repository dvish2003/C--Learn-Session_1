using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp
{
    public class UserService : IUserService
    {
        public void CreateUser(string name, int age)
        {
            Console.WriteLine($"Creating user: {name}, Age: {age}");
        }
    }
}