using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int timeHoursSpent = int.Parse(input[0]);

            int vMedia = int.Parse(input[1]);


            int distance = vMedia * timeHoursSpent;

            double litros = (double)distance / 12;

            Console.WriteLine(litros.ToString("N3"));
        }
    }
}
