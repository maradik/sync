using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var semaphore = new Semaphore(1, 1, "MySemaphore");
            semaphore.WaitOne();

            Console.WriteLine("Hello World!");

            semaphore.Release();
        }
    }
}