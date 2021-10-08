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
			BenchMark benchMark = new BenchMark();
			benchMark.Load();

			benchMark.TestArrayContains();
			benchMark.TestHashSetContains();
		}

	}
}


	
