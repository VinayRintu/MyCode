using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle_
{
    class Rectangle1 
    {
        public  void Area()
        {
            Console.WriteLine("This Area Belongs to Rectangle1"); 
        }
    }

    class Square1 :Rectangle1
    {        
        public  void Area()
        {
            Console.WriteLine("This Area Belongs to Square1");
        }
    }
}
