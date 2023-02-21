using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Interface_Segregation
{
    public class Bird1 : IAnimal, IAnimalSecond
    {
        public void Eat()
        {
            Console.WriteLine("Bird1 Can Eat ");
        }

        public void Fly()
        {
            Console.WriteLine("Bird1 Can Fly ");
        }

        public void Sleep()
        {
            Console.WriteLine("Bird1 Can Sleep ");
        }
    }
}
