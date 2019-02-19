using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			int x;
			int y;
			Console.WriteLine("enter 2 numbers");
			do
			{
				x = Convert.ToInt32(Console.ReadLine());
				y = Convert.ToInt32(Console.ReadLine());
			}
			while (x + y != 100);
			Console.WriteLine("sum is 100!");
		
	        */

			int a, b, c;
			Console.WriteLine("enter 3 numbers until the first 2 multiplied equal the third");
			do
			{
				a = Convert.ToInt32(Console.ReadLine());
				b = Convert.ToInt32(Console.ReadLine());
				c = Convert.ToInt32(Console.ReadLine());
			}
			while (a * b != c);
			Console.WriteLine("finally!");
		}
	}
}
