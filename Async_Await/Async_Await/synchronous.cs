using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    public class synchronous
    {
        public void BoilRice()
        {
            Console.WriteLine("synchronous Rice Boil Started");
            Thread.Sleep(3000);
            Console.WriteLine("synchronous Rice Completed");
        }
        public void MarinateChicken()
        {
            Console.WriteLine("synchronous Chicken Marinate Started");
            Thread.Sleep(5000);
            Console.WriteLine("synchronous Chicken Marinate Completed");
        }
        public void MakingDum()
        {
            Console.WriteLine("synchronous Making Dum Started");
            Thread.Sleep(4000);
            Console.WriteLine("synchronous Making Dum Completed");
        }
        public void MainReady()
        {
            Stopwatch sw=new Stopwatch();
            sw.Start();
            synchronous sync=new synchronous();
            sync.BoilRice();
            sync.MarinateChicken();
            sync.MakingDum();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

    }
}
