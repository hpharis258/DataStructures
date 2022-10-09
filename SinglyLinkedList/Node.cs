using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        // Data and pointer to the next node.
        public string data;
        public Node? linkToNextNode;
        // Constructor Method
        public Node(string data)
        {
            this.data = data;
        }
    }
}
