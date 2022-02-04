using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
           //6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

			Console.Write("Enter first number - ");
			int fNum = int.Parse(Console.ReadLine());
			Console.Write("Enter second number - ");
			int sNum = int.Parse(Console.ReadLine());
			Console.Write("Enter third number - ");
			int tNum = int.Parse(Console.ReadLine());
			int product = fNum * sNum * tNum;
			Console.WriteLine("The product of {0}, {1} and {2} is {3}", fNum, sNum, tNum, product);

        }
    }
}
