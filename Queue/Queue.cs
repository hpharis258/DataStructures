using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        ListNode front;
        ListNode back;

        public Queue()
        {
            front = null;
            back = null;
        }
        public ListNode GetNode(int data)
        {
            ListNode node = new ListNode(data);
            return node;
        }
        // Add to the Back of the Queue
        public void Enqueue(int data)
        {
            ListNode newNode = GetNode(data);
            if(front== null)
            {
                front = newNode;
                back = newNode;
                return;
            }
            back.next= newNode;
            back = newNode;
        }
        // Remove from the Front of the Queue
        public int Dequeue()
        {
            int check = -1;
            if(front !=null)
            {
                check = front.data;
                front = front.next;
            }
            return check;
        }
        // Return data of the First element
        public int Peek()
        {
            if(front.data != null)
            {
                return front.data;
            }
            return -1;
        }
        // Check if empty
        public bool isEmpty()
        {
            if(front == null)
            {
                return true;
            }
            return false;   
        }

    }
}
