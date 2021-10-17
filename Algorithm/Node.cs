using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class Node
	{
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

        public void Tree()
        {
            Data = 1;
            Node node2 = new Node() { Data = 2 };
            Node node3 = new Node() { Data = 3 };
            Node node4 = new Node() { Data = 4 };
            Node node5 = new Node() { Data = 5 };
            Node node6 = new Node() { Data = 6 };
            Node node7 = new Node() { Data = 7 };
            Node node8 = new Node() { Data = 8 };
            Node node9 = new Node() { Data = 9 };

            Left = node2;
            Right = node7;
            node2.Parent = this;
            node7.Parent = this;

            node2.Left = node3;
            node2.Right = node4;
            node3.Parent = node2;
            node4.Parent = node2;

            node7.Left = node8;
            node7.Right = node9;
            node8.Parent = node7;
            node9.Parent = node7;

            node4.Left = node5;
            node4.Right = node6;
            node5.Parent = node4;
            node6.Parent = node4;
            
        }
        public void PreOrderTravers(Node root, string s = "")
        {
            if(root != null)
            {
                Console.Write(root.Data);
                if(root.Left != null || root.Right != null)
                {
                    Console.Write("(");
                    if(root.Left != null) PreOrderTravers(root.Left);
                    else Console.Write("NIL");
                    Console.Write(",");
                    if(root.Right != null) PreOrderTravers(root.Right);
                    else Console.Write("NIL");
                    Console.Write(")");
                }
            }
        }
        public void Queue(Node root) //  поиск в ширину
        {
            Queue<Node> PreOrderQueue = new Queue<Node>();
            PreOrderQueue.Enqueue(root);

            while(PreOrderQueue.Count != 0)
            {
                var node = PreOrderQueue.Dequeue();
                Console.Write(node.Data);
                Console.Write(" ");
                if(node.Left != null) PreOrderQueue.Enqueue(node.Left);
                if(node.Right != null) PreOrderQueue.Enqueue(node.Right);
            }
        }
        public void Stack(Node root) //поиск в глубину
        {
            Stack<Node> PreOrderStack = new Stack<Node>();
            PreOrderStack.Push(root);

            while(PreOrderStack.Count != 0)
            {
                var node = PreOrderStack.Pop();
                Console.Write(node.Data);
                Console.Write(" ");
                if(node.Left != null) PreOrderStack.Push(node.Left);
                if(node.Right != null) PreOrderStack.Push(node.Right);
            }
        }
    }
   

}			

