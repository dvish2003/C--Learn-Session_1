using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Cat : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("The cat is eating.");
        }
        
    }
}