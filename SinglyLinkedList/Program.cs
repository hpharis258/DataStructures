namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList Test = new SinglyLinkedList();
            Test.addAtHead("Some data 0");
            Test.addAtHead("Some data 1");
            Test.addAtHead("Some data 2");
            Test.addAtHead("Some data 3");
            Test.addAtHead("Some data 4");
            Test.addAtHead("Some data 5");
            Test.traverse();
            Console.WriteLine(Test.Length().ToString());
            Test.addAtTail("Added at tail1");
            Test.addAtTail("added at tail2");
            Test.addAtTail("added at tail3");
            Test.traverse();
            Console.WriteLine(Test.Length().ToString());
            Test.removeAtHead();
            Test.traverse();
            Console.WriteLine(Test.Length().ToString());
            Console.WriteLine("Remove at tail");
            Test.removeAtTail();
            Test.traverse();
            Console.WriteLine(Test.Length().ToString());
            Console.WriteLine(Test.search("Some data 2").ToString());
            Test.removeAtIndex(4);
            Test.traverse();
            Console.WriteLine(Test.Length().ToString());
            Test.addAtGivenIndex(4, "Inserted at index 4");
            Test.traverse();
        }
    }
}