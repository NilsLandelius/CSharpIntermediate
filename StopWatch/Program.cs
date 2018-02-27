using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StopWatch stopwatch = new StopWatch();
                stopwatch.Start();
                Console.ReadLine();
                Console.WriteLine(stopwatch.Duration);
                Console.ReadLine();


            }
            catch (Exception e)
            {
                Console.WriteLine($"The Error {0} occured",e);
                Console.ReadLine();
            }
        }
    }
}
