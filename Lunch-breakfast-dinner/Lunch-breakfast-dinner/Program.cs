// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime currentTime = DateTime.Now;
string time = DateTime.Now.ToShortTimeString();
string[] parts = time.Split(':');
int hour = int.Parse(parts[0]);
int minutes = int.Parse(parts[1]);
//int hour = 2;
//int minutes = 60;


int[] nextMeal = new int[2];
if (hour == 7 && minutes == 0) 
{
    Console.WriteLine($"Jack Your");
}
else if (hour == 12 && minutes == 0)
{

}
else if (hour == 19 && minutes == 0)
{

}
else if (hour >= 7 && hour < 12)
{
    nextMeal[0] = 12 - hour - 1;
    if (minutes == 0)
    {
        nextMeal[1] = 0;
    }
    else
    {
        nextMeal[1] = (60 - minutes);
    }
    Console.WriteLine($"Hey Jake timeToEat Lunch in [{nextMeal[0]},{nextMeal[1]}]");
}
else if (hour >= 12 && hour < 19)
{
    nextMeal[0] = 19 - hour - 1;
    if (minutes == 0)
    {
        nextMeal[1] = 0;
    }
    else
    {
        nextMeal[1] = (60 - minutes);
    }
    Console.WriteLine($"Hey Jake timeToEat Dinner in [{nextMeal[0]},{nextMeal[1]}]");
}
else
{
    nextMeal[0] = 7 + 24 - hour - 1;
    if (minutes == 0)
    {
        nextMeal[1] = 0;
    }
    else
    {
        nextMeal[1] = (60 - minutes);
    }
    Console.WriteLine($"Hey Jake timeToEat Breakfast in [{nextMeal[0]},{nextMeal[1]}]");
}

//string time = DateTime.Now.ToShortTimeString();
//string[] parts = time.Split(':');
////int hour = int.Parse(parts[0]);
////int minutes = int.Parse(parts[1]);
//int hour = 2;
//int minutes = 0;

//int[] nextMeal = new int[2];
//int nextHour;

//if (hour >= 7 && hour < 12)
//{
//    nextHour = 12;
//}
//else if (hour >= 12 && hour < 19)
//{
//    nextHour = 19;
//}
//else
//{
//    nextHour = 7;
//}

//nextMeal[0] = (nextHour - hour + 24-1) % 24;
//nextMeal[1] = (60 - minutes) % 60;

//string mealType = (nextHour == 7) ? "Breakfast" : ((nextHour == 12) ? "Lunch" : "Dinner");
//Console.WriteLine($"Hey Jake, time to eat {mealType} in [{nextMeal[0]},{nextMeal[1]}]");
