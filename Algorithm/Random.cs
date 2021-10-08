using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class Randoms
	{
		public void ArrayRandom()
        {
            Random rnd = new Random();
            // заполняем массив случайными данными
            for(int i = 0; i <= razmer; i++)
            {
                masF[i].X = (float)rnd.NextDouble();
                masF[i].Y = (float)rnd.NextDouble();
                masD[i].X = rnd.NextDouble();
                masD[i].Y = rnd.NextDouble();
                masC[i] = new PointClass
                {
                    X = masF[i].X,
                    Y = masF[i].Y
                };
            }
		}		
	}
}
