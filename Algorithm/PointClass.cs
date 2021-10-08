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


        public readonly int razmer = 100; // размер массива данных

        public static PointStructF[] masF = new PointStructF[razmer + 1];
        public static PointStructD[] masD = new PointStructD[razmer + 1];
        public static PointClass[] masC = new PointClass[razmer + 1];
        public class PointClas // вариант для ссылочного типа
        {
            public float X;
            public float Y;
            public class PointClas // вариант для ссылочного типа
            public float PointDistance1(PointClas pointOne, PointClas pointTwo) // вариант теста 1
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }
        }
        public struct PointStructF // вариант для типа float
        {
            public float X;
            public float Y;
            public float PointDistance2(PointStructF pointOne, PointStructF pointTwo) // вариант теста 2
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }

        }
        public struct PointStructD // вариант для типа double
        {
            public double X;
            public double Y;
            public double PointDistance3(PointStructD pointOne, PointStructD pointTwo) // вариант теста 3
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
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


