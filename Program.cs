using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.

			Console.Write("Enter your first prefered number - ");
			double firstNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter your second prefered number - ");
			double secondNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter your third prefered number - ");
			double thirdNumber = double.Parse(Console.ReadLine());

			Console.Write("Enter your fourth prefered number - ");
			double fourthNumber = double.Parse(Console.ReadLine());

			double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
			Console.WriteLine("The average for the four numbers you inputted is - {0}", average);

        }
    }
}
