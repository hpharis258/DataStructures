namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<String> Test = new DynamicArray<string>(5);
            Test.set(0, "ITEM 1");
            Test.set(1, "ITEM 2");
            Test.set(2, "ITEM 3");
            Test.set(3, "ITEM 4");
            Test.set(4, "ITEM 5");
            Test.set(5, "ITEM 6");
            Test.set(6, "ITEM 7");
            Console.WriteLine(Test.get(0));
            Console.WriteLine(Test.get(1));
            Console.WriteLine(Test.get(2));
            Console.WriteLine(Test.get(3));
            Console.WriteLine(Test.get(4));
            Console.WriteLine(Test.get(5));
            Console.WriteLine(Test.get(6));
        }
    }
}