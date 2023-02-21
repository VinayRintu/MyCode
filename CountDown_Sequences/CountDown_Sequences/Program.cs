// See https://aka.ms/new-console-template for more information
using CountDown_Sequences;
using static System.Runtime.InteropServices.JavaScript.JSType;



//public class Program
//{
//    public static int[][] FinalCountdown(int[] arr)
//    {
//        List<List<int>> countdownSequences = new List<List<int>>();
//        List<int> currentSequence = new List<int>();
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] == currentSequence.Count + 1)
//            {
//                currentSequence.Add(arr[i]);
//            }
//            else
//            {
//                if (currentSequence.Count > 0)
//                {
//                    countdownSequences.Add(currentSequence);
//                    currentSequence = new List<int>();
//                }
//            }
//        }
//        if (currentSequence.Count > 0)
//        {
//            countdownSequences.Add(currentSequence);
//        }
//        int[][] result = new int[countdownSequences.Count][];
//        for (int i = 0; i < countdownSequences.Count; i++)
//        {
//            result[i] = countdownSequences[i].ToArray();
//        }
//        return new int[][] { new int[] { countdownSequences.Count }, result };
//    }
//    public static void Main(string[] args)
//    {
//        int[] arr = new int[] { 4, 8, 3, 2, 1, 2 };
//        int[][] result = FinalCountdown(arr);
//        Console.WriteLine("[{0}, {1}]", result[0][0], string.Join(", ", result[1]));
//    }
//}

//Program1 p1 = new Program1();
//Console.WriteLine(p1.FinalCountdownSequences(countDown));

//CountDownSwquences obj=new CountDownSwquences();
//int[] arr = new int[] { 4, 8, 3, 2, 1, 2 };
//int[][] result = obj.FinalCountdown(arr);
//Console.WriteLine("[{0}, {1}]", result[0][0], string.Join(", ", result[1]));


//Class2 class2= new Class2();
//int[][] arr = class2.FinalCountdownSequences(new int[] { 4, 4, 5, 4, 3, 2, 1, 8, 3, 2, 1 });
//Console.WriteLine("Count: " + arr[0][0]);
//Console.WriteLine("Sequences: ");
//for (int i = 0; i < arr[1].Length; i++)
//{
//    Console.WriteLine(string.Join(", ", arr[1][i]));
//}

//int[][] arraysForTest = new int[][] {
//            new int[] { 3, 2, 1, 3, 2, 1, 1 },
//            new int[] { 4, 8, 3, 2, 1, 2 },
//            new int[] { 4, 4, 5, 4, 3, 2, 1, 8, 3, 2, 1 },
//            new int[] { 1, 1, 2, 1 },
//            new int[] { }
//            };

//foreach (int[] arr in arraysForTest)
//{
//    //int count = Class2.FinalCountdownSequences(arr, out int[][] sequences);
//    //Console.WriteLine("Count of descending order sequences are : {0}", count);
//    //Console.WriteLine("Sequences are :");
//    //for (int i = 0; i < sequences.Length; i++)
//    //{
//    //    Console.WriteLine(" [{0}]", string.Join(", ", sequences[i]));
//    //}

//    Console.Write("[ " + count.ToString() + ", ");
//    if (count > 1)
//        Console.Write("[");
//    foreach (int[] number in sequences)
//    {
//        Console.Write("[ " + string.Join(", ", number) + " ] ");
//    }
//    if (count > 1) Console.Write("]");
//    Console.Write("]");
//    Console.WriteLine();
//}

//int[] arr1 = new int[] { 4, 3, 2, 1, 3, 2, 1, 1 };
//int count1 = Class2.FinalCountdownSequences(arr1, out int[][] sequences);
//Console.WriteLine("Count of descending order sequences are : {0}", count1);
//Console.WriteLine("Sequences are :");
//for (int i = 0; i < sequences.Length; i++)
//{
//    Console.WriteLine("[{0}]", string.Join(", ", sequences[i]));
//}


int[] arrayForTest = new int[] { 4, 1, 8, 3, 2, 1, 2 };
int count = Class2.FinalCountdownSequences(arrayForTest, out int[][] sequences);
Console.Write("[ " + count.ToString() + ", ");
if (count > 0)
{
    if (count > 1)
    {
       Console.Write("[");
    }
      
    for(int i = 0; i < sequences.Length; i++)
    {
         Console.Write("[ " + string.Join(", ", sequences[i]) + " ] ");
    }
    if (count > 1)
    {
         Console.Write("]");
    }
    Console.Write("]");
    Console.WriteLine();
}
else
{
    Console.Write("[ 0, []]");
}
Console.WriteLine();

