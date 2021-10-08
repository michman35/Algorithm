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
	public class Bench
	{
        private Dictionary<PointClas, PointClas> _pointsClass;
        private Dictionary<PointStructF, PointStructF> _pointStructF;
        private Dictionary<PointStructD, PointStructD> _pointStructD;

        public Bench()
		{
            _pointsClass = new Dictionary<PointClas, PointClas>();
            FillPointsClass();
            _pointStructF = new Dictionary<PointStructF, PointStructF>();
            FillPointStructF();
            _pointStructD = new Dictionary<PointStructD, PointStructD>();
            FillPointStructD();

        }
        public void FillPointStructF()
		{
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                var one = new PointStructF(random.Next(100, 1000), random.Next(0, 100));
                var two = new PointStructF(random.Next(100, 1000), random.Next(0, 100));
                _pointStructF.Add(one, two);
            }
        }

        public void FillPointsClass()
		{
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                var one = new PointClas(random.Next(100, 1000), random.Next(0, 100));
                var two = new PointClas(random.Next(100, 1000), random.Next(0, 100));
                _pointsClass.Add(one, two);
            }

        }
        public void FillPointStructD()
		{
            var random = new Random();
            for(int i = 0; i < 100; i++)
            {
                var one = new PointStructD(random.Next(100, 1000), random.Next(0, 100));
                var two = new PointStructD(random.Next(100, 1000), random.Next(0, 100));
                _pointStructD.Add(one, two);
            }
        }



        [Benchmark]
        public void Test()
        {
            foreach(var item in _pointsClass) 
            {
                PointCalc.PointDistance1(item.Key, item.Value);
            }
            
        }
        [Benchmark]
        public void TestTwo()
        {
            foreach(var item in _pointStructF)
            {
                PointCalc.PointDistance2(item.Key, item.Value);
            }

        }
        [Benchmark]
        public void TestThree()
        {
            foreach(var item in _pointStructD)
            {
                PointCalc.PointDistance3(item.Key, item.Value);
            }

        }
       
    }
}

