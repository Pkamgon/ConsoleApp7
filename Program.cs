using System;
using System;   

namespace Branching_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter dimensionSize");
            int dimensionSize = Convert.ToInt32(Console.ReadLine());
            string result = dimensionSize < 50 ? "You have the right weight" : "Package too heavy to be shipped via Package Express. Have a good day";
            Console.WriteLine(result);
            int packageWeight = 40;
            int packageWidth = 10;
            int packageHeight = 12;
            int packageLength = 11;
            Console.WriteLine(((packageLength * packageWidth * packageHeight) * packageWeight) / 100); //Enter the parameters as stated above
            Console.WriteLine("Please enter packageWidth");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter packageHeight");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the packagelength");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your estimatedTotal for shipping this package is $528.00");
            Console.ReadLine();

        }
    }
}
