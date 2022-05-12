// See https://aka.ms/new-console-template for more information
using System;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average Average = new Average();
            double result = Average.avg(new int[] { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(Average.avg(new int[] { 1, 2, 3, 4, 5, 6 }));
            if (result == 3.5)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}