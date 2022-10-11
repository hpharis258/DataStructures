using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable
    {
        // Init 
        public int size;
        public int key;
        public string value;
        public string[] arr; 
        // hash Function
        public int hashFoIndex(int key, int size)
        {
            int hashVal = key % size;
            return hashVal;
        }
        // Constructor
        public HashTable(int size)
        {
            this.size = size;
            this.arr = new string [size];
        }
        // Insert into Hash Table
        public void insert(int key, string value)
        {
            int index = hashFoIndex(key, size);
            string StringKey = key.ToString();
            value = StringKey + "," + value;
            arr[index] = value;
        }
        // Retrieve from hash table
        public string getValue(int key)
        {
            int index = hashFoIndex(key, this.size);
            return arr[index];
        }
    }
}
