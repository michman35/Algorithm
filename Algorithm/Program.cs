using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Algorithm
{
	class Program
	{


		static void Main(string[] args)
		{//Задание 1 
			BenchMark benchMark = new BenchMark();
			benchMark.Load();
			benchMark.TestArrayContains();
			benchMark.TestHashSetContains();
	
		}
		
		/* Задание 2 . не смог прикрутить методы копирования  и т.д. Пользовался вашим вариантом
		 написания дерева из вебинара . Мозг отказывается воспринимать информацию  ,в основном гуглю и 
		такое ощущение что понимаю все меньше.*/ 
	}
}


	
