using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace Algorithm
{
	class BenchMark
	{
		public HashSet<string> HashSet { get; set; }
		public  string[] Array { get; set; }
		public void Load()
		{
			HashSet = new HashSet<string>();
			Array = new string[10000];
			for(int i = 0; i < 10000; i++)
			{
				var hash = Guid.NewGuid().ToString();
				Array[i] = hash;
				HashSet.Add(hash);
			}
		}
		public void TestArrayContains()
{
			var wath = Stopwatch.StartNew();
			var s = Array.Contains("G");
			wath.Stop();
			Console.WriteLine(wath.Elapsed);
		}
		public void TestHashSetContains()
		{
			var wath = Stopwatch.StartNew();
			var s = HashSet.Contains("G");
			wath.Stop();
			Console.WriteLine(wath.Elapsed);
		}
	}

}
