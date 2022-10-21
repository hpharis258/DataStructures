// Recursive C# program
// for insertion sort
using System;

class GFG
{

    // Recursive function to sort
    // an array using insertion sort
    static void insertionSortRecursive(int[] arr,
                                       int n)
    {
        // Base case
        if (n <= 1)
            return;

        // Sort first n-1 elements
        insertionSortRecursive(arr, n - 1);

        // Insert last element at
        // its correct position
        // in sorted array.
        int last = arr[n - 1];
        int j = n - 2;

        /* Move elements of arr[0..i-1],
        that are greater than key, to
        one position ahead of their
        current position */
        while (j >= 0 && arr[j] > last)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = last;
    }

    //Driver Code
    static void Main()
    {
        int[] arr = new int[200]; 
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 23; 
        }


        insertionSortRecursive(arr, arr.Length);

        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}