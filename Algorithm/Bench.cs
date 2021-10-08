using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using static Algorithm.PointClass;

namespace Algorithm
{
	class Bench
	{
        [Benchmark]
        public void Test()
        {
            PointClas point = new PointClas();
            point.PointDistance1();
        }
        [Benchmark]
        public void TestTwo()
        {
            PointStructF point = new PointStructF();
            point.PointDistance2();
        }
        [Benchmark]
        public void TestThree()
        {
            PointStructD point = new PointStructD();
            point.PointDistance3();
        }
        [Benchmark]
        public void TestFour()
        {
            PointStructF point = new PointStructF();
            point.PointDistance4();
        }
    }
}
}
