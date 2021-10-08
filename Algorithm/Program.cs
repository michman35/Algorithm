using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Algorithm
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<Bench>();
		}
	}
  }

	
