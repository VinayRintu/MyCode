using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    public class Asynchronous
    {
        public void BoilRice()
        {
            Console.WriteLine("Asynchronous Rice Boil Started");
            Thread.Sleep(7000);
            Console.WriteLine("Asynchronous Rice Completed");
        }
        public void MarinateChicken()
        {
            Console.WriteLine("Asynchronous Chicken Marinate Started");
            Thread.Sleep(5000);
            Console.WriteLine("Asynchronous Chicken Marinate Completed");
        }
        public void MakingDum()
        {
            Console.WriteLine("Asynchronous Making Dum Started");
            Thread.Sleep(4000);
            Console.WriteLine("Asynchronous Making Dum Completed");
        }
        public void MainReady()
        {
            Thread th1 = new Thread(BoilRice);
            Thread th2= new Thread(MarinateChicken);
            Thread th3= new Thread(MakingDum);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            th1.Start();
            th2.Start();
            th3.Start();
            
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //synchronous sync = new synchronous();
            //sync.BoilRice();
            //sync.MarinateChicken();
            //sync.MakingDum();
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
