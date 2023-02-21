using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    public class Asynchro
    {
        public static async Task BoilRice()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Asynchro Rice Boil Started");
                Task.Delay(4000).Wait();
                Console.WriteLine("Asynchro Rice Completed");
            });            
        }
        public static async void MarinateChicken()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Asynchro Chicken Marinate Started");
                Task.Delay(5000).Wait();
                Console.WriteLine("Asynchro Chicken Marinate Completed");
            });           
        }
        public static async void MakingDum()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Asynchro Making Dum Started");
                Task.Delay(3000).Wait();
                Console.WriteLine("Asynchro Making Dum Completed");
            });           
        }
        public void MainMethod()
        {
            Stopwatch sw=new Stopwatch();
            sw.Start();
            BoilRice();
            MarinateChicken();
            MakingDum();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
