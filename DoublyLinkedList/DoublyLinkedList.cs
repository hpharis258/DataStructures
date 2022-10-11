using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node? head;
        public Node? tail;
        int length = 0;
        // Constructor
        public DoublyLinkedList()
        {
            //this.head = null;
            //this.tail = null;
        }
        // traverse 
        public void traverse()
        {
            Node? current = this.head;
            int counter = 0;
            while (counter != length - 1)
            {
                Console.WriteLine(current.data);
                current = current.NextNode;
                
                counter++;
            }
            Console.WriteLine("Counter is" + counter.ToString());
            Console.WriteLine("Data is " + current.data);
            Console.WriteLine("PREVIOUS NODE IS: " + current.PreviousNode.ToString());
            //Console.WriteLine("Backwards: ");
            //counter = -1;
            //while (counter != 0)
            //{
            //    current = current.PreviousNode;
            //    Console.WriteLine(current.data);
            //    counter--;
            //}
            Console.WriteLine("DONE");
        }
        // Insert at Head
        public void insertAtHead(string data)
        {
            // new node
            Node newNode = new Node(data);
            // If null make head and tail new node
            if(this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                // Add the new node
                //this.head.PreviousNode = newNode;
                newNode.NextNode = this.head;
                this.head.PreviousNode = newNode;
                this.head = newNode;

                
            }
            this.length++;
        }

    }
}
