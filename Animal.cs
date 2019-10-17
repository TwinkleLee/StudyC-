using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        protected int age = 10;
    }
    class Person : Animal
    {
        public void Shout()
        {
            Animal animal = new Animal() as Person;
            //Person person = new Person() as Animal;
            Console.ReadKey();

        }
    }
}
