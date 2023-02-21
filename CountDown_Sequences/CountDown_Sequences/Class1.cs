using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown_Sequences
{
    public class Program1
    {
        public int[][] finalCountdown(int[] arr)
        {
            List<int[]> countdowns = new List<int[]>();
            int start = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length && arr[i + 1] == arr[i] - 1)
                {
                    if (start == 0)
                    {
                        start = i;
                    }
                }
                else if (start != 0)
                {
                    int[] countdown = new int[i - start + 1];
                    Array.Copy(arr, start, countdown, 0, countdown.Length);
                    countdowns.Add(countdown);
                    start = 0;
                }
            }
            if (start != 0)
            {
                int[] countdown = new int[arr.Length - start];
                Array.Copy(arr, start, countdown, 0, countdown.Length);
                countdowns.Add(countdown);
            }
            int[][] result = new int[countdowns.Count][];
            countdowns.CopyTo(result);
            return result;
            //int index = 0;
            //foreach (int[] countdown in countdowns)
            //{ 
            //    result[index++] = countdown; 
            //}
            //int[] finalResult = new int[2];
            //finalResult[0] = countdowns.Count;
            //finalResult[1] = result;
            //return finalResult;
        }
    }
}
