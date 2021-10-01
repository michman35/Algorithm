using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	public class  Сycle
	{
		public void Fibon()
		{
			int n = 1;
			int n1 = 0;
			int n2;

			for(int i = 1; i < 20; i++)
			{
				n2 = n;
				n = n + n1;
				n1 = n2;
				Console.WriteLine(n);

			}
		}
	}
}
