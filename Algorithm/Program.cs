using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Algorithm
{
class Program
    {
        static void Main(string[] args)
        {
            Square way = new Square();
            way.SquareWalk();
        }
    }
}