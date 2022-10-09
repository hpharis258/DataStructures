using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T>
    {
        // Initialise Array of the type that was given
        public T[] array;
        //
        int capacity = 0;
        //constructor
        public DynamicArray(int capacity)
        {
            // Check capacity
            if(capacity < 0)
            {
                throw new Exception("Capacity Must be more than 0");
            }
            this.capacity = capacity;
            this.array = new T[capacity];
        }
        // Set Data at a given Index
        public void set(int index, T data)
        {
            if(index == this.capacity - 1)
            {
                this.capacity = this.capacity * 2;
                T [] newArray = new T[this.capacity];
                this.array.CopyTo(newArray, 1);
                this.array = newArray;
            }
            this.array[index] = data;
        }
        // Get Data
        public T? get(int index)
        {
            return array[index];
        }
    }
}
