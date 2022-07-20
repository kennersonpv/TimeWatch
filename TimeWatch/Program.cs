using System;
using System.Threading;

namespace TimeWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Watch.StartWatch();
                Thread.Sleep(3000);

                Console.WriteLine(Watch.StopWatch());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
