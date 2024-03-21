using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);

            float time1 = crono1.ElapsedMilliseconds/1000f;

            Console.WriteLine($"{time1:f3}");
            crono2.Start();
            Thread.Sleep(200);

            float time2 = crono2.ElapsedMilliseconds/1000f;

            Console.WriteLine($"{time2:f3}");

            crono1.Stop();

        }
    }
}
