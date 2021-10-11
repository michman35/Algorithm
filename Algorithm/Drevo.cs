using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{


    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

        Node root = new Node()

        {
            Data = 6,
            Left = new Node
            {
                Data = 2,
                Right = new Node
                {
                    Data = 3,
                }

            },
            Right = new Node
            {
                Data = 11,
                Left = new Node
                {
                    Data = 9,
                },
                Right = new Node
                {
                    Data = 30,
                }
            }
        };
       
    }


	


}
