// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

// Read data from the text file
//var movieTime = File.ReadAllLines("C:/Users/Ruthwika Reddy/OneDrive/Desktop/Movies.txt") 
//    .Select(line => int.Parse(line.Split(' ')[1]))
//    .ToArray();

//// Find the number of possible ways to play the movies
//var possibleWays = FindPossibleWays(movieTime, 120);

//static int FindPossibleWays(int[] movieTime, int targetDuration)
//{
//    Array.Sort(movieTime);

//    var left = 0;
//    var right = movieTime.Length - 1;
//    var count = 0;

//    while (left < right)
//    {
//        var currentDuration = movieTime[left] + movieTime[right];

//        if (currentDuration == targetDuration)
//        {
//            count++;
//            left++;
//            right--;
//        }
//        else if (currentDuration < targetDuration)
//        {
//            left++;
//        }
//        else
//        {
//            right--;
//        }
//    }

//    return count;
//}

//Console.WriteLine($"Number of possible ways to play the movies: {possibleWays}");




//int[] movieTime = { 20, 70, 50, 70, 30 };
//int flightTime = 120;
//int maxMovies = 0;
//List<Tuple<int, int>> watchedMovies = new List<Tuple<int, int>>();

//foreach (var totalTime in movieTime)
//{
//    if (totalTime <= flightTime)
//    {
//        flightTime -= totalTime;
//        maxMovies++;
//        watchedMovies.Add(Tuple.Create(maxMovies, totalTime));
//    }
//}

//Console.WriteLine("Maximum number of movies you can watch is: " + maxMovies);
//Console.WriteLine("List of movies you can watch and their totalTime:");
//foreach (var movie in watchedMovies)
//{
//    Console.WriteLine("Movie " + movie.Item1 + ": " + movie.Item2 + " mins");
//}


//============================================start

//string[] lines = File.ReadAllLines("C:/Users/Ruthwika Reddy/OneDrive/Desktop/Movies.txt");
//Dictionary<string, int> movieTime = new Dictionary<string, int>();
//foreach (string line in lines)
//{
//    string[] parts = line.Split(' ');
//    string movieName = parts[0];
//    int totalTime = int.Parse(parts[1]);
//    movieTime.Add(movieName, totalTime);
//}

//int flightTime = 120;
//int n = movieTime.Count;
//int[] selectedTime = new int[flightTime + 1];
//string[] selected = new string[flightTime + 1];

//for (int i = 0; i < n; i++)
//{
//    if (movieTime.ElementAt(i).Value <= flightTime)
//    {
//        int duration = movieTime.ElementAt(i).Value;
//        string name = movieTime.ElementAt(i).Key;
//        for (int j = flightTime; j >= duration; j--)
//        {
//            if (selectedTime[j] < selectedTime[j - duration] + 1)
//            {
//                selectedTime[j] = selectedTime[j - duration] + 1;
//                selected[j] = name;
//            }
//        }
//    }
//    //Random random = new Random();
//    //int[] start2 = random.Next(i, movieTime);
//    //Console.WriteLine();
//}

//List<string> suggestedMovies = new List<string>();
//int remainingTime = flightTime;
//while (remainingTime > 0)
//{
//    suggestedMovies.Add(selected[remainingTime]);
//    remainingTime = remainingTime - movieTime[selected[remainingTime]];
//    Console.WriteLine("\nOne Type Suggestion :");
//    foreach (string movie in suggestedMovies)
//    {
//        Console.WriteLine(movie);
//    }
//}
//===================================================End

//string filePath = @"C:/Users/Ruthwika Reddy/OneDrive/Desktop/Movies.txt";
//string text = File.ReadAllText(filePath);
//string[] lines = text.Split(' ');
//string[] stringValues = new string[0];
//int[] intValues = new int[0]; 
//foreach (string line in lines)
//{
//    string[] values = line.Split(' ');
//    if (int.TryParse(values[1], out int number))
//    {
//        Array.Resize(ref stringValues, stringValues.Length + 1);
//        stringValues[stringValues.Length - 1] = values[0];
//        Array.Resize(ref intValues, intValues.Length + 1);
//        intValues[intValues.Length - 1] = number;
//    }
//    else
//    {
//        Array.Resize(ref stringValues, stringValues.Length + 1);
//        stringValues[stringValues.Length - 1] = line;
//    }
//}
//// Print the array of integers
////Console.WriteLine("Integers in the file:");
////foreach (int num in intValues)
////{
////    Console.Write(num + " ");
////}
////Console.WriteLine();         //// Print the array of strings
////Console.WriteLine("Strings in the file:");
////foreach (string str in stringValues)
////{
////    Console.Write(str + " ");
////}   

//int flightTime = 120;
//int totalTime = 0;
//string completedMovies = "";
//bool found = false;
//for (int i = 0; i < Math.Pow(2, intValues.Length); i++)
//{
//    totalTime = 0;
//    completedMovies = "";
//    for (int j = 0; j < intValues.Length; j++)
//    {
//        if ((i & (1 << j)) > 0)
//        {
//            totalTime += intValues[j];
//            completedMovies += stringValues[j] + " ";
//        }
//    }
//    if (totalTime == flightTime)
//    {
//        Console.WriteLine("We can complete this combination of movies during our journey: {0}", completedMovies);
//        found = true;
//    }
//}
//if (!found)
//{
//    Console.WriteLine("No combination of movies add up to exactly 120 minutes.");
//}     
//===============================================

string[] lines = File.ReadAllLines("C:/Users/Ruthwika Reddy/OneDrive/Desktop/Movies.txt");
Dictionary<string, int> movieTime = new Dictionary<string, int>();
foreach (string line in lines)
{
    string[] parts = line.Split(' ');
    string movieName = parts[0];
    int totalTime = int.Parse(parts[1]);
    movieTime.Add(movieName, totalTime);
}

int flightTime = 120;
int n = movieTime.Count;
int[] selectedTime = new int[flightTime + 1];
string[] selected = new string[flightTime + 1];

for (int i = 1; i <= n; i++)
{
    //if (movieTime.ElementAt(i).Value <= flightTime)
    //{
    //    int duration = movieTime.ElementAt(i).Value;
    //    string name = movieTime.ElementAt(i).Key;
    //    for (int j = flightTime; j >= duration; j--)
    //    {
    //        if (selectedTime[j] < selectedTime[j - duration] + 1)
    //        {
    //            selectedTime[j] = selectedTime[j - duration] + 1;
    //            selected[j] = name;
    //        }
    //    }
    //}

    Random random = new Random();
    int[] intArray = movieTime.Values.ToArray();
    //int a = int.Parse(movieTime.Values);
    //int[] arr = { 20, 30, 50, 70, 50, 70 };
     int[] start2 = random.Next(i, arr[0]);
    random.Next(intArray.Length);
    Console.WriteLine();
}

List<string> suggestedMovies = new List<string>();
int remainingTime = flightTime;
while (remainingTime > 0)
{
    suggestedMovies.Add(selected[remainingTime]);
    remainingTime = remainingTime - movieTime[selected[remainingTime]];
    Console.WriteLine("\nOne Type Suggestion :");
    foreach (string movie in suggestedMovies)
    {
        Console.WriteLine(movie);
    }
}
//===========================

//string filePath = "C:/Users/Ruthwika Reddy/OneDrive/Desktop/Movies.txt";
//string[] lines = File.ReadAllLines(filePath);
//int flightTime = 120;
//var movies = lines.Select(line => new { Name = line.Split()[0], Time = int.Parse(line.Split()[1]) }).ToArray();
//suggestMovies(movies, flightTime, 0, new string[movies.Length], 0);

//void suggestMovies(var movies, int flightTime, int currentTime, string[] result, int currentIndex)
//{
//    if (currentTime > flightTime) return;
//    if (currentTime == flightTime)
//    {
//        Console.WriteLine("Suggested movies for flight:");
//        for (int i = 0; i < currentIndex; i++)
//            Console.Write(result[i] + " " + movies.First(m => m.Name == result[i]).Time + " minutes  ");
//        Console.WriteLine();
//        return;
//    }
//    for (int i = 0; i < movies.Length; i++)
//    {
//        if (!result.Contains(movies[i].Name))
//        {
//            result[currentIndex] = movies[i].Name;
//            suggestMovies(movies, flightTime, currentTime + movies[i].Time, result, currentIndex + 1);
//            result[currentIndex] = "";
//        }
//    }
//}