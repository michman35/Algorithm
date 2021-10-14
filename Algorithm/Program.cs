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
		{
			var tree = new Tree<int>();
			tree.Add(5);
			tree.Add(3);
			tree.Add(7);
			tree.Add(1);
			tree.Add(2);
			tree.Add(8);
			tree.Add(6);
			tree.Add(9);
			foreach(var item in tree.Preorder()) // обход в ширину 
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
			foreach(var item in tree.Postorder())//обход в глубину 
			{
				Console.WriteLine(item);
			}
		}


	}
}


	
