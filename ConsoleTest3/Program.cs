using System;
using System.Threading;

namespace ConsoleTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Starting thread...");
            t1.Start();

            for (int i=0;i<5;i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(50);
            }

            Console.WriteLine("Waiting until thread stops...");
            bool a;
            a = t1.Join(10);

            Console.WriteLine("Finished {0}", a);
        }
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(100);
            }
        }
    }
}
