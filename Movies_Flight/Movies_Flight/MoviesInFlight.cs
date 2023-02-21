using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies_Flight
{
    public class MoviesInFlight
    {
        //public static void GenerateMovieSubsets(Dictionary<string, int> movieTime, List<string> movieSubset, int nextIndex, int flightTime)
        //{
        //    if (flightTime == 0)
        //    {
        //        PrintMovieSubset(movieSubset);
        //        return;
        //    }
        //    else if (nextIndex == movieTime.Count)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        var movie = movieTime.ElementAt(nextIndex);
        //        GenerateMovieSubsets(movieTime, movieSubset, nextIndex + 1, flightTime);
        //        if (flightTime >= movie.Value)
        //        {
        //            movieSubset.Add(movie.Key);
        //            GenerateMovieSubsets(movieTime, movieSubset, nextIndex + 1, flightTime - movie.Value);
        //            movieSubset.Remove(movie.Key);
        //        }
        //    }
        //}
        //public static void PrintMovieSubset(List<string> movieSubset)
        //{
        //    foreach (string movie in movieSubset)
        //    {
        //        Console.Write(movie + " ");
        //    }
        //    Console.WriteLine();
        //}

    }
}
