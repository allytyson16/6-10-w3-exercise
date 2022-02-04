using System;

namespace Udemyyyyy
{
    class Program
    {
        static void Main(string[] args)
        {
//10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z
			Console.Write("Enter first number - ");
			double x = double.Parse(Console.ReadLine());

			Console.Write("Enter second number - ");
			double y = double.Parse(Console.ReadLine());

			Console.Write("Enter third number - ");
			double z = double.Parse(Console.ReadLine());

			double output1 = (x + y) * z;
			double output2 = x * y + y * z;

			Console.WriteLine("The output of (first number ({0}) + second number ({1})) * third number ({2}) is ({3}).", x, y, z, output1);
			Console.WriteLine("The putput of first number ({0}) * second number ({1}) + second number ({2}) * third number ({3}) is {4}.", x, y, y, z, output2);
        }
    }
}
