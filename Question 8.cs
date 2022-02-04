using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
          
		//8.Write a C# Sharp program that takes a number as input and print its multiplication table.

			Console.Write("Enter a number to get its multiples - ");
			int number = int.Parse(Console.ReadLine());

			Console.WriteLine("The multiplication table for {0} is :" + number);
			int answer = number * 1;
			Console.WriteLine("{0} * {1} = {2}", number, 1, answer);
			answer = number * 2;
			Console.WriteLine("{0} * {1} = {2}", number, 2, answer);
			answer = number * 3;
			Console.WriteLine("{0} * {1} = {2}", number, 3, answer);
			answer = number * 4;
			Console.WriteLine("{0} * {1} = {2}", number, 4, answer);
			answer = number * 5;
			Console.WriteLine("{0} * {1} = {2}", number, 5, answer);
			answer = number * 6;
			Console.WriteLine("{0} * {1} = {2}", number, 6, answer);
			answer = number * 7;
			Console.WriteLine("{0} * {1} = {2}", number, 7, answer);
			answer = number * 8;
			Console.WriteLine("{0} * {1} = {2}", number, 8, answer);
			answer = number * 9;
			Console.WriteLine("{0} * {1} = {2}", number, 9, answer);
			answer = number * 10;
			Console.WriteLine("{0} * {1} = {2}", number, 10, answer);
			answer = number * 11;
			Console.WriteLine("{0} * {1} = {2}", number, 11, answer);
			answer = number * 12;
			Console.WriteLine("{0} * {1} = {2}", number, 12, answer);
		
        }
    }
}
