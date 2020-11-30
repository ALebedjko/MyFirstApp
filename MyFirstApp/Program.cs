using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterationCount;

            Console.Title = "Iterations";
            Console.WriteLine("Please enter interation count");
            String userInput = Console.ReadLine();
            iterationCount = Int32.Parse(userInput);


            while (iterationCount > 0)
            {
                Console.WriteLine("Hello World!");
                iterationCount--;
            }
        }
    }
}
