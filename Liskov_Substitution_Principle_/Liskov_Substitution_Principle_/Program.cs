// See https://aka.ms/new-console-template for more information
using Liskov_Substitution_Principle_;

Console.WriteLine("HELLO");


Shape shape = new Rectangle();
Console.WriteLine("Rectangle");
shape.Area();
Console.WriteLine();
shape = new Square();
Console.WriteLine("Square");
shape.Area();

Rectangle1 obj = new Square1();// Creating object for the derived class using base class reference
Console.WriteLine("Square");
obj.Area();
