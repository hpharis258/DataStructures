// Dynamic Array Rewrite from Java Source code to C#.
// SRC code https://github.com/williamfiset/Algorithms/blob/master/src/main/java/com/williamfiset/algorithms/datastructures/dynamicarray/IntArray.java
using System;
using System.Collections;
using System.Collections.Generic;
//Console.WriteLine(1 << 3);

public class IntArray : IEnumerable<int>
{
    // Set Default Capacity to 8 Bits
    // I think the reason for this is because the int size in C# is 4Bytes
    // By doing the bit shifitng he can have Default Cpacity of 8Bits(1Byte) and Still Store it as an int.
    // Don't Know if this is Correct.
    private static readonly int DEFAULT_CAP = 1 << 3;
    // Init Array Lenght and Capacity:
    public int[] array;
    public int length = 0;
    public int capacity = 0;
    // Init Array with No Capacity Given
    public IntArray()
    {
        capacity = DEFAULT_CAP;
    }
    // Init Array with certain capacity
    public IntArray(int capacity)
    {
        // Check if capacity is valid
        if (capacity < 0) throw new Exception("Illegal Capacity" + capacity);
        // Set capacity 
        this.capacity = capacity;
        // Create new array with that capacity.
        array = new int[capacity];
    }
    // Given an array make it dynamic (Makes a copy of the array setting the Length and Capacity to the original arrays length)
    public IntArray(int[] arr)
    {
        if (array == null) throw new Exception("Array can't be null");
        arr.CopyTo(array, arr.Length);
        capacity = length = arr.Length;
    }
    // Return Size of the Array;
    public int size()
    {
        return length;
    }
    // Check if the array is empty
    public bool isEmptyArray()
    {
        return length == 0;
    }
    // Get value of a given index.
    public int getIndex(int index)
    {
        return array[index];
    }
    //Set Values of a given index.
    public void setIndex(int index, int value)
    {
        array[index] = value;
    }
    // Add an element to the dynamic Array
    public void add(int value)
    {
        if (length + 1 >= capacity)
        {
            if (capacity == 0) { capacity = 1; }
            else
            {
                capacity *= 2; // Double the Cap
            }
        }
        array[length++] = value;
    }
    // Removes the element at specified index.
    public void removeAt(int indexToRemove)
    {
        // Copy over the array removing the Index

        int[] copied = new int[array.Length - 1];
        for(int i =0; i< copied.Length-1; i++)
        {
            if(copied[i] != array[indexToRemove])
            {
                copied[i] = array[i];
            }
            array = copied;
        }
        
    }
    // Search and Remove element:
    public bool remove(int elem)
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] == elem)
            {
                removeAt(i);
                return true;
            }
        }
        return false;
    }
    // Reverse contents of the array:
    public void reverse()
    {
        for (int i = 0; i < length / 2; i++)
        {
            int temporary = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temporary;
        }
    }
    // Binary Search:
    public int binarySearch(int key)
    {
        int index = Array.BinarySearch(array, key);
        return index;
    }
    // Sort
    public void Sort()
    {
        Array.Sort(array);
    }
    // Enumerator Interface
    public IEnumerator GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }
    IEnumerator<int> IEnumerable<int>.GetEnumerator()
    {
        return (IEnumerator<int>)GetEnumerator();
    }
}

public class goThroughEnumerator : IEnumerator<int>
{
    public int[] array;
    int pos = -1;

    public goThroughEnumerator(int[] array)
    {
        this.array = array;
    }
    
    int IEnumerator<int>.Current
    {
        get { return array[pos]; }
    }

    public object Current => this;

    public void reset()
    {
        pos = -1;
    }

    public bool MoveNext()
    {
        pos++;
        return (pos < array.Length);
    }

    public void Reset()
    {
        pos = -1;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}

namespace TestIntArray
{
    class Program
    {
        static void Main()
        {
            IntArray testArray2 = new IntArray(10); 
            testArray2.add(1);
            testArray2.add(2);
            testArray2.add(5); // Add Element Works

            //Console.WriteLine("Current Number of Elements in the IntArray");
            //Console.WriteLine(testArray2.size()); // Size Works Returns the Current Number of Elements
            //Console.WriteLine("Is array Empty?");
            //Console.WriteLine(testArray2.isEmptyArray()); //Works Return True of array is empty false otherwise 
            //Console.WriteLine("Insert the Index you want to get: ");
            //string userDefinedInput = Console.ReadLine(); // Get Index Works
            //Console.WriteLine("Value at the index you have selected is: " + testArray2.getIndex(Int32.Parse(userDefinedInput)));
            //Console.WriteLine("Enter an index you want to set at: ");
            //string indexAt = Console.ReadLine();
            //Console.WriteLine("Enter the Value that you want to set: ");
            //string valueToSet = Console.ReadLine();
            //testArray2.setIndex(Int32.Parse(indexAt), Int32.Parse(valueToSet));
            //Console.WriteLine($"You have set {valueToSet} at INDEX: {indexAt}"); // Set Index Works:
            //Console.WriteLine("Enter the Index you want to Remove: ");
            testArray2.removeAt(2);
            Console.WriteLine(testArray2.getIndex(0));
            Console.WriteLine(testArray2.getIndex(1));
            Console.WriteLine(testArray2.getIndex(2));


            //for (int i = 0; i < testArray.Length; i++)
            //{
            //    Console.WriteLine(testArray[i]);
            //}

            //foreach (int item in testArray)
            //{
            //    Console.WriteLine(item);
            //}

            // IntArray Test2 = new IntArray(testArray);
            // Console.WriteLine(Test2.isEmptyArray());
        }
    }
}
