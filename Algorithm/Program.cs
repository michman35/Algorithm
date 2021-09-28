using System;

namespace Algorithm
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("введите число");
			int n = Convert.ToInt32(Console.ReadLine());
			Simple number = new Simple();
			number.simpes(n);
		}
	}
}
