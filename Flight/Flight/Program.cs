//See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

for (int i = 0; i < n; i++)
{
    if (movieTime.ElementAt(i).Value <= flightTime)
    {
        int duration = movieTime.ElementAt(i).Value;
        string name = movieTime.ElementAt(i).Key;
        for (int j = flightTime; j >= duration; j--)
        {
            if (selectedTime[j] < selectedTime[j - duration] + 1)
            {
                selectedTime[j] = selectedTime[j - duration] + 1;
                selected[j] = name;
            }
        }
    }
    //Random random = new Random();
    //int[] start2 = random.Next(i, movieTime.Values);
    //Console.WriteLine();
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

//for (int i = 1; i <= n; i++)
//{
//    foreach (var movie in movieTime)
//    {
//        int time = movie.Value;
//        string name = movie.Key;
//        for (int j = flightTime; j >= time; j--)
//        {
//            if (selectedTime[j] < selectedTime[j - time] + time)
//            {
//                selectedTime[j] = selectedTime[j - time] + time;
//                selected[j] = name;
//            }
//        }
//    }
//}

//List<string> suggestedMovies = new List<string>();
//int remainingTime = flightTime;
//while (remainingTime > 0)
//{
//    suggestedMovies.Add(selected[remainingTime]);
//    remainingTime -= movieTime[selected[remainingTime]];
//}

//Console.WriteLine("Suggested movies to watch during flight: ");
//foreach (string movie in suggestedMovies)
//{
//    Console.WriteLine(movie);
//}
