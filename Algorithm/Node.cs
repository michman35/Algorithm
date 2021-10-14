using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class Node<T> : IComparable<T>,IComparable
		where T:IComparable, IComparable<T>
    {
        public T Data { get;  set; }
		public Node<T> Left { get; set; }
		public Node<T> Right { get; set; }
		public Node(T data)
		{
			Data = data;
		}
		public Node(T data, Node<T> left, Node<T> right)
		{
			Data = data;
			Left = left;
			Right = right;
		}
		public void Add(T data)
		{
			var node = new Node<T>(data);
			if(node.Data.CompareTo(Data) == -1)
			{
				if(Left == null)
				{
					Left = node;
				}
				else
				{
					Left.Add(data);
				}
			}
			else
			{
				if(Right == null)
				{
					Right = node;
				}
				else
				{
					Right.Add(data);
				}
			}
		}
		public int CompareTo(object obj)
		{
			if(obj is Node<T> item)
			{
				return Data.CompareTo(obj);
			}
			else
			{
				throw new Exception("несовпадение типов ");
			}
		}
		public int CompareTo(T other)
		{
			return Data.CompareTo(other);
		}
	
	}			
}
