using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {

        public int size;
        public int top = -1;
        public T[] stack;

        // Constructor
        public Stack(int size)
        {
            this.size = size;
            this.stack = new T[size];
        }

        // Is full method
        public bool isFull()
        {
            if(this.top == this.size - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // If Stack is Empty Return True else False
        public bool isEmpty()
        {
            if(this.top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void push(T data)
        {
            // Method To Push the DATA:
            if(isFull() == true)
            {
                Console.WriteLine("The stack is full ");
            }
            else
            {
                this.top++;
                this.stack[this.top] = data;
            }

        }
        // Pop Method 
        public T pop()
        {
            //
            if (isEmpty() == true)
            {
                Console.WriteLine("The Stack is Empty");
                return default;
            }
            else
            {
                T poppedItem = this.stack[this.top];
                this.top--;
                return poppedItem;
            }
        }
        // Peek Method
        public T peek()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("The Stack is Empty");
                return default;
            }
            else
            {
                T itemCopy = this.stack[this.top];
                return itemCopy;
            }
        }
    }
}
