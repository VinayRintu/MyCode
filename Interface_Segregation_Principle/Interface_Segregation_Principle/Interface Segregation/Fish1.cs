using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Interface_Segregation
{
    public class Fish1 : IAnimal,IAnimalFirst
    {
        public void Eat()
        {
            Console.WriteLine("Fish1 Can Eat ");
        }

        public void Sleep()
        {
            Console.WriteLine("Fish1 Can Sleep ");
        }

        public void Swim()
        {
            Console.WriteLine("Fish1 Can Swim ");
        }
    }
}
