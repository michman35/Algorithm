using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
    }
    public class DLinkedList : ILinkedList
    {
        Node head;
        Node tail;
        int _count;

       
       
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            Node temp = head;
            node.Next = temp;
            head = node;
            if(_count == 0)
                tail = head;
            else
                temp.Previous = node;
            _count++;
        }           
        public void Clear()
        {
            head = null;
            tail = null;
            _count = 0;
        }    
        public IEnumerable<Node> HeatEnumerator()
        {
            Node current = head;
            while(current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        public IEnumerable<Node> BackEnumerator()
        {
            Node current = tail;
            while(current != null)
            {
                yield return current;
                current = current.Previous;
            }
        }

		public int GetCount() // возвращает количество элементов в списке
        {
           
            return _count;
                
		}
        public void AddNode(int data) // добавляет новый элемент списка
        {
            Node node = new Node(data);

            if(head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            _count++;
        }
        public void AddNodeAfter(Node node, int value) // добавляет новый элемент списка после определённого элемента
        {        
            var count = 0;
            foreach(var item in HeatEnumerator())
            {
                if(count== value)
                {
					if(item.Previous == null) 
                    {
                        head = node;
                        item.Previous = node;
                        _count++;
                        break;
                    }

					if(item.Next == null) 
                    {
                        tail = node;
                        item.Next = node;
                        _count++;
                        break;
                    }
					
                    node.Previous = item;
                    node.Next = item.Next;
                    item.Next = node;
                    _count++;
                    break;
                }
                count++;
            }
        }

		public void RemoveNode(int index) // удаляет элемент по порядковому номеру
        {
            Node current = null;

            var count = 0;
            foreach(var item in HeatEnumerator())
            {
                if(count == index)
				{
                    current = item;
                    break;
				}
                count++;
            }
            if(current != null)
            {
                if(current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }
                if(current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                count--;
               
            }
           
        }

		public void RemoveNode(Node node) // удаляет указанный элемент
        {
            Node current = head;

            while(current != null)
            {
                if(current.Data.Equals(node.Data))
                {
                    break;
                }
                current = current.Next;
            }
            if(current != null)
            {
                if(current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    tail = current.Previous;
                }
                if(current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                _count--;
                
            }
           
        }

		public Node FindNode(int searchValue)// ищет элемент по его значению
        {

            foreach(var item in HeatEnumerator())
            {
                if(item.Data == searchValue)
                {
                    return item;
                }
            }

            return null;
        }
    }
	
	public interface ILinkedList
	{
		int GetCount(); // возвращает количество элементов в списке
		void AddNode(int value);  // добавляет новый элемент списка
		void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
		void RemoveNode(int index); // удаляет элемент по порядковому номеру
		void RemoveNode(Node node); // удаляет указанный элемент
		Node FindNode(int searchValue); // ищет элемент по его значению
	}

}
