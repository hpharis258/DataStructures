namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test List: ");
            DoublyLinkedList Test = new DoublyLinkedList();
            Test.insertAtHead("Some Data 1: ");
            Test.insertAtHead("Some Data 2: ");
            Test.insertAtHead("Some Data 3: ");
            //Test.insertAtHead("Some Data 4: ");
            //Test.insertAtHead("Some Data 5: ");
            Test.traverse();

        }
    }
}