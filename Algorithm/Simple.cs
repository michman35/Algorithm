using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class Simple
	{
		public void simpes(int n)
		{
			
			int d = 0;
			for(int i = 2; i < n; i++)
			{
				if (n%i==0)
				{
					d++;
					
				}
				
			}
			if(d == 0)
			{
				Console.WriteLine("число простое");

			}
			else
			{
				Console.WriteLine("число не простое");
			}
		}
	}
}
