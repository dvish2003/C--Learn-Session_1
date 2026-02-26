using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp
{
    public interface IUserService
    {
        public void CreateUser(string name, int age);
    }
}