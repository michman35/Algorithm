using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class PreOrder
	{
        public int PreOrders(Node root)
        {
            if(root != null)
            {
                Console.Write(root.Data);
                if(root.Left != null || root.Right != null)
                {
                    Console.Write("(");
                    if(root.Left != null) PreOrders(root.Left);
                    else Console.Write("NIL");
                    Console.Write("(");
                    if(root.Right != null) PreOrders(root.Right);
                    else Console.Write("NIL");
                    Console.Write(")");
                }
            }
            return 0;
        }
    }
}
