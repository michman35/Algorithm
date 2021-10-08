using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Algorithm
{
    class PointClass
    {
   

        public class PointClas // вариант для ссылочного типа
        {
            public float X { get; }
            public float Y { get; }

			public PointClas(float x, float y)
			{

			}

            public float PointDistance1(PointClas pointTwo) // вариант теста 1
            {
                float x = X - pointTwo.X;
                float y = Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }
        }
        public struct PointStructF // вариант для типа float
        {
            public float X;
            public float Y;

            public PointStructF(float x, float y) 
            {
                X = x;
                Y = y;
            }
            

        }
        public struct PointStructD // вариант для типа double
        {
            public double X;
            public double Y;
            public PointStructD(float x, float y)
            {
                X = x;
                Y = y;
            }
        }
        public float PointDistance4(PointStructF pointOne, PointStructF pointTwo) // вариант теста 4
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return Sqrt((x * x) + (y * y));
        }
        public float Sqrt(float x)
        {
            float s = ((x / 2) + x / (x / 2));
            for(int i = 0; i < 4; i++)
            {
                s = (s + x / s) / 2;
            }
            return s;



        }
    } 
}


