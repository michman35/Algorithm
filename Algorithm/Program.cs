using System;

namespace Algorithm
{
	class Program
	{
		static void Main(string[] args)
		{ //задание 1
            DLinkedList list = new DLinkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNodeAfter(new Node(22), 2);
            list.RemoveNode(new Node(4));
            foreach(var item in list.HeatEnumerator()) 
            {
                Console.WriteLine(item.Data);
            }
            //задание 2
            BinarySearch binarySearch = new BinarySearch();
            binarySearch.Array();
        }
    }

}

