using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        // init head and tail node
        private Node? head;
        private Node? tail;
        int length = 0;
        // Traverse list method
        public void traverse()
        {
            // Set Current Node as the head
            Node? current = this.head;
            int counter = 0;
            // 
            while (counter != length) 
            {
                Console.WriteLine(current.data);
                current = current.linkToNextNode;
                counter++;
            }
        }
        // Constructor
        public SinglyLinkedList()
        {
            // Init Empty List
        }
        // Add Item to Linked List
        public void addAtHead(string data)
        {
            // Create a new Node and pass the data to it.
            Node newNode = new Node(data);

            // Check if the List is empty
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                newNode.linkToNextNode = this.head;
                this.head = newNode;
            }
            length++;
        }
        // Return Length;
        public int Length()
        {
            return this.length;
        }
        // Add at tail
        public void addAtTail(string data)
        {
            // New Node
            Node? newNode = new Node(data);
            Node? current = this.head;
            int counter = 0;
            // 
            while(counter != length -1)
            {
                current = current.linkToNextNode;
                counter++;
            }
            current.linkToNextNode = newNode;
            this.tail = newNode;
            length++;
        }
        // Remove at Head
        public void removeAtHead()
        {
            // Check if head id null
            if(this.head.linkToNextNode == null)
            {
                throw new Exception("Can't remove the head List is empty");
            }
            else
            {
                // if not set head to head pointer to next element
                this.head = this.head.linkToNextNode;
                length--;
            }
        }
        // Remove at tail
        public void removeAtTail()
        {
            if(this.tail == null)
            {
                throw new Exception("The list is empty can't remove at tail");
            }
            else
            {
                Node? current = this.head;
                int counter = 0;
                // 
                while (counter != length -1)
                {                    
                    current = current.linkToNextNode;
                    counter++;
                }
                current.linkToNextNode = null;
                this.tail = current;
                length--;
            }
        }
        // Returns the index of the element if it was found
        public int search(string searcString)
        {
            Node? current = this.head;
            int counter = 0;
            // 
            while (counter != length)
            {
                if(current.data == searcString)
                {
                    return counter;
                }
                current = current.linkToNextNode;
                counter++;
            }
            return -1;
        }
        // Remove at index
        public void removeAtIndex(int index)
        {
            Node? current = this.head;
            int counter = 0;
            // 
            while (counter != index - 1)
            {
                current = current.linkToNextNode;
                counter++;
            }
            Node? nodeToDelete = current.linkToNextNode;
            current.linkToNextNode = nodeToDelete.linkToNextNode;
            length--;
        }
        // Add at a given index
        public void addAtGivenIndex(int index, string data)
        {
            // Check that given Index is valid
            if(index < 0 || index > length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            else
            {
                Node? oneBefore = this.head;
                Node? next;
                int counter = 0;
                // 
                while (counter != index - 1)
                {
                    oneBefore = oneBefore.linkToNextNode;
                    counter++;
                }
                next = oneBefore.linkToNextNode;
                Node nodeToAdd = new Node(data);
                oneBefore.linkToNextNode = nodeToAdd;
                nodeToAdd.linkToNextNode = next.linkToNextNode;
                length++;
            }
        }
    }
}
