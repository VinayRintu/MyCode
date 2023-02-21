
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
List<string> movieSubset = new List<string>();
GenerateMovieSubsets(movieTime, movieSubset, 0, flightTime);

static void GenerateMovieSubsets(Dictionary<string, int> movieTime, List<string> movieSubset, int nextIndex, int flightTime)
{
    if (flightTime == 0)
    {
        PrintMovieSubset(movieSubset);
        return;
    }
    else if (nextIndex == movieTime.Count)
    {
        return ;
    }
    else
    {
        var movie = movieTime.ElementAt(nextIndex);
        GenerateMovieSubsets(movieTime, movieSubset, nextIndex + 1, flightTime);
        if (flightTime >= movie.Value)
        {
            movieSubset.Add(movie.Key);
            GenerateMovieSubsets(movieTime, movieSubset, nextIndex + 1, flightTime - movie.Value);
            movieSubset.Remove(movie.Key);
        }
    }
}
static void PrintMovieSubset(List<string> movieSubset)
{
    foreach (string movie in movieSubset)
    {
        Console.Write(movie + " ");
    }
    Console.WriteLine();
}


