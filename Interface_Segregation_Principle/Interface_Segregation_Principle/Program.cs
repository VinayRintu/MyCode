// See https://aka.ms/new-console-template for more information
using Interface_Segregation_Principle;
using Interface_Segregation_Principle.Interface_Segregation;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

Console.WriteLine("----Fish-----");

Fish objNormalFish = new Fish();
objNormalFish.Eat();
objNormalFish.Sleep();
objNormalFish.Swim();
objNormalFish.Fly();//Not Required

Console.WriteLine("----Bird-----");
Bird objNormalBird = new Bird();
objNormalBird.Eat();
objNormalBird.Sleep();
objNormalBird.Swim();//Not Required
objNormalBird.Fly();

//Interface...
Console.WriteLine("----Bird-----");
Bird1 objBird = new Bird1();
objBird.Eat();
objBird.Sleep();
objBird.Fly();

Console.WriteLine("----Fish-----");
Fish1 objFish = new Fish1();
objFish.Eat();
objFish.Sleep();
objFish.Swim();