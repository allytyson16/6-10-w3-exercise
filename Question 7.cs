using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
//7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.

					Console.Write("Enter first number - ");
					int fNumber = int.Parse(Console.ReadLine());
					Console.Write("Enter second number - ");
					int sNumber = int.Parse(Console.ReadLine());

				//for adding
					int add = fNumber + sNumber;
					Console.WriteLine("The sum of the numbers are " + add);

				//for subtraction
					int difference = fNumber - sNumber;
					Console.WriteLine("The difference of the numbers are " + difference);

				//for multiplication
					int multiplication = fNumber * sNumber;
					Console.WriteLine("The product of the numbers are " + multiplication);

				//for division
					int division = fNumber / sNumber;
					Console.WriteLine("The answer for dividing the two numbers are " + division);
			        }
    }
}
