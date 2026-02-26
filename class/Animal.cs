using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }
}