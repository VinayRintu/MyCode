using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    public class DependExample
    {
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        public async void CallMethod()
        {
            Stopwatch sw =  new Stopwatch();
            sw.Start();
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
