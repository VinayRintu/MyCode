using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown_Sequences
{
    public class Class2
    {
        //public static int[][] FinalCountdownSequences(int[] arr)
        // {
        //     List<List<int>> sequences = new List<List<int>>();
        //     List<int> currentSequence = new List<int>();
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         if (currentSequence.Count == 0 || arr[i] == currentSequence[currentSequence.Count - 1] - 1)
        //         {
        //             currentSequence.Add(arr[i]);
        //             if (currentSequence[0] == 1)
        //             {
        //                 sequences.Add(new List<int>(currentSequence));
        //                 currentSequence.Clear();
        //             }
        //         }
        //         else
        //         {
        //             currentSequence.Clear();
        //             currentSequence.Add(arr[i]);
        //         }
        //     }

        //     int[][] result = new int[2][];
        //     result[0] = new int[] { sequences.Count };
        //     result[1] = new int[sequences.Count][];
        //     for (int i = 0; i < sequences.Count; i++)
        //     {
        //         result[1][i] = sequences[i].ToArray();
        //     }

        //     return result;
        // }

        //static void Main(string[] args)
        //{
        //    int[][] testCases = new int[][] {
        //    new int[] { 4, 8, 3, 2, 1, 2 },
        //    new int[] { 4, 4, 5, 4, 3, 2, 1, 8, 3, 2, 1 },
        //    new int[] { 4, 3, 2, 1, 3, 2, 1, 1 },
        //    new int[] { 1, 1, 2, 1 },
        //    new int[] { }
        //    };
        //    foreach (int[] arr in testCases)
        //    {
        //        int count = FinalCountdownSequences(arr, 0, out int[][] sequences);
        //        Console.WriteLine("Count of descending order sequences are : {0}", count);
        //        Console.WriteLine("Sequences are :");
        //        for (int i = 0; i < sequences.Length; i++)
        //        {
        //            Console.WriteLine(" [{0}]", string.Join(", ", sequences[i]));
        //        }
        //    }
        //}

        //public static int FinalCountdownSequences(int[] arr, int index, out int[][] sequences)
        //{
        //    List<List<int>> TotalCountdownSequences = new List<List<int>>();
        //    List<int> currentSequence = new List<int>();

        //    if (index >= arr.Length)
        //    {
        //        sequences = new int[0][];
        //        return 0;
        //    }

        //    int currentCount = 0;
        //    for (int i = index; i < arr.Length; i++)
        //    {
        //        int count = FinalCountdownSequences(arr, i + 1, out int[][] innerSequences);
        //        for (int j = 0; j < count; j++)
        //        {
        //            if (currentSequence.Count == 0 || arr[i] == currentSequence[currentSequence.Count - 1] - 1)
        //            {
        //                currentSequence.Add(arr[i]);
        //                TotalCountdownSequences.Add(new List<int>(currentSequence.Concat(innerSequences[j])));
        //                currentCount++;
        //            }
        //            else
        //            {
        //                currentSequence.Clear();
        //            }
        //        }
        //    }

        //    sequences = new int[TotalCountdownSequences.Count][];
        //    for (int i = 0; i < TotalCountdownSequences.Count; i++)
        //    {
        //        sequences[i] = TotalCountdownSequences[i].ToArray();
        //    }
        //    return currentCount;
        //}

        public static int FinalCountdownSequences(int[] arr, out int[][] sequences)
        {
            List<List<int>> TotalCountdownSequences = new List<List<int>>();
            List<int> currentSequence = new List<int>();
            //int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                //if (arr[i] != arr[i+1] + 1)
                //{
                //    if (arr[i] == 1)
                //    {
                //        currentSequence.Add(arr[i]);
                //        TotalCountdownSequences.Add(currentSequence);
                //        currentSequence = new List<int>();
                //    }
                //}
                if (arr[i] == 1 /*&& arr[i - 1] - 1 == 1 || arr[i] == 1 && arr[i - 1] -1 != 1*/)
                {
                    currentSequence.Add(arr[i]);
                    TotalCountdownSequences.Add(currentSequence);
                    currentSequence = new List<int>();
                }
                else if (currentSequence.Count == 0 || arr[i] == currentSequence[currentSequence.Count - 1] - 1)
                {
                    currentSequence.Add(arr[i]);
                }
                else
                {
                    currentSequence = new List<int>();
                    currentSequence.Add(arr[i]);
                }
            }
            sequences = new int[TotalCountdownSequences.Count][];
            for (int i = 0; i < TotalCountdownSequences.Count; i++)
            {
                sequences[i] = TotalCountdownSequences[i].ToArray();
            }
            return TotalCountdownSequences.Count;
        }
    }
}
