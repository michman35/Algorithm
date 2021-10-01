using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class Fibonachi
	{
		public int Fib(int n)
		{
			if(n < 3)
				return 1;
			return Fib(n - 2) + Fib(n - 1);
		}
	}
	
}
