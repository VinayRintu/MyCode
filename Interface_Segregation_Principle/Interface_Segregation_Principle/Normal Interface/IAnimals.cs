using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    interface IAnimals
    {
        void Eat();
        void Sleep();
        void Swim();
        void Fly();
    }
    class Fish : IAnimals
    {
        public void Eat()
        {
            Console.WriteLine("Fish Can Eat");
        }
        public void Sleep()
        {
            Console.WriteLine("Fish Can Sleep");
        }
        public void Swim()
        {
            Console.WriteLine("Fish Can Swim");
        }
        public void Fly()
        {
            Console.WriteLine("Fish Can't Fly");
        }
    }

    class Bird : IAnimals
    {
        public void Eat()
        {
            Console.WriteLine("Bird Can Eat");
        }
        public void Sleep()
        {
            Console.WriteLine("Bird Can Sleep");
        }
        public void Swim()
        {
            Console.WriteLine("Bird Can't Swim");
        }
        public void Fly()
        {
            Console.WriteLine("Bird Can Eat");
        }
    }

}
