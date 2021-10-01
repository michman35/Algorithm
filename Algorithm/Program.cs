using System;

namespace Algorithm
{
	class Program
	{
		static void Main(string[] args)
		{   // Задание 1
			Console.WriteLine("введите число");
			int n = Convert.ToInt32(Console.ReadLine());
			Simple number = new Simple();
			number.simpes(n);

			
			/*Задание 2
			 В примере наблюдаем цикл в цикле , в котором запущен еще один цикл поэтому производительность 
			составит О(N3).Пренебригаем константами т.к их несколько и получаем кубическую сложность функции
			*/

			//Задание 3

			Console.WriteLine("рекурсивный способ ");
			for(int i = 1; i < 20; i++)
			{
				Fibonachi fibonachi = new Fibonachi();
				Console.WriteLine(fibonachi.Fib(i));
			}

			Console.WriteLine(" расчет через цикл");
			Сycle cycle = new Сycle();
			cycle.Fibon();
		
		}


	}
}
