using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithm.PointClass;

namespace Algorithm
{
    class PointCalc
    {
        public static float PointDistance1(PointClas one, PointClas two)
        {
            float x = one.X - two.X;
            float y = one.Y - two.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static float PointDistance2(PointStructF one, PointStructF two) // вариант теста 2
        {
            float x = one.X - two.X;
            float y = one.Y - two.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static double PointDistance3(PointStructD one, PointStructD two) // вариант теста 3
        {
            double x = one.X - two.X;
            double y = one.Y - two.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

    }
}
