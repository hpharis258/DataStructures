namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable Test = new HashTable(10);
            Test.insert(123, "Some String");
            Test.insert(321, "Another String");
            Console.WriteLine(Test.getValue(123));
            Console.WriteLine(Test.getValue(321));
        }
    }
}