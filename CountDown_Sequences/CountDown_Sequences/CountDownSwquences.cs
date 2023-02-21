//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CountDown_Sequences
//{
//    public class CountDownSwquences
//    {
//        public static int[][] FinalCountdown(int[] arr)
//        {
//            List<List<int>> countdownSequences = new List<List<int>>();
//            List<int> currentSequence = new List<int>();
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == currentSequence.Count + 1)
//                {
//                    currentSequence.Add(arr[i]);
//                    countdownSequences.Add(currentSequence);
//                    currentSequence = new List<int>();
//                }
//                else
//                {
//                    if (currentSequence.Count > 0)
//                    {
//                        countdownSequences.Add(currentSequence);
//                        currentSequence = new List<int>();
//                    }
//                }
//            }
//            if (currentSequence.Count > 0)
//            {
//                countdownSequences.Add(currentSequence);
//            }
//            int[][] result = new int[countdownSequences.Count][];
//            for (int i = 0; i < countdownSequences.Count; i++)
//            {
//                result[i] = countdownSequences[i].ToArray();
//            }
//        //    return new int[][] { new int[] { countdownSequences.Count }, result.ToArray() };
//        //}
//        //public static void Main(string[] args)
//        //{
//        //    int[] arr = new int[] { 4, 8, 3, 2, 1, 2 };
//        //    int[][] result = FinalCountdown(arr);
//        //    Console.WriteLine("[{0}, {1}]", result[0][0], string.Join(", ", result[1]));
//        }

//    }
//}
