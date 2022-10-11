using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        public string data;
        public Node NextNode;
        public Node PreviousNode;

        public Node(string data)
        {
            this.data = data;
        }
    }
}
