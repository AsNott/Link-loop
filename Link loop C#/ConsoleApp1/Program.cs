using System;
using System.Diagnostics;
using System.Threading;

namespace URLOpener
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the URL:"); 
            string url = Console.ReadLine();

            Console.WriteLine("Please Input the Minutes (Minute): ");
            int duration = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 999; i++)
            {
                
                int sleep = duration * 60 * 1000;

                Process.Start(url);

                Thread.Sleep(sleep); // Sleep for 10 minutes (10 * 60 * 1000 milliseconds)
            }
                
           
        }
    }
}
