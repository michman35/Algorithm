using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Algorithm
{
    class Program
    {

        static void Main(string[] args)
        {
            Node nodee = new Node();

            nodee.Tree();
            nodee.PreOrderTravers(nodee);
            Console.WriteLine();

            Console.Write("Stack: ");
            nodee.Stack(nodee);
            Console.WriteLine();
            Console.Write("Queue: ");
            nodee.Queue(nodee);
        }
    }
}
    /* Сергей , понял что мой код к предыдщему задания , мягко сказать не очень , поэтому поьзуясь 
    вашим материалом переписал дерево с поиском в глубину и ширину используя очередь и стек . С графом засел 
     в тупик , данные обходы не подойдут для него как я понял из методички . И что бы описать граф , мне 
     нужно сначала описать его вершину и ребра . А затем написать класс описывающий граф с методами добавления вершин и ребер.
     Все правильно ? */




	
