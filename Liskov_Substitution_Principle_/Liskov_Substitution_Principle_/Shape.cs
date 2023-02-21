using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle_
{
    class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("This is Shape Method");
        }
    }

    class Rectangle : Shape
    {     
        public override void Area()
        {

            Console.WriteLine("This Area belongs to Rectangle");
        }
    }

    class Square : Shape
    {  
        public override void Area()
        {
            Console.WriteLine("This Area Belongs to Square");
        }
    }
    
}
