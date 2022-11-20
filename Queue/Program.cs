namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue demoQueue = new Queue();

            Console.WriteLine("Is Queue Empty? " + demoQueue.isEmpty());
            demoQueue.Enqueue(10);
            demoQueue.Enqueue(16);
            demoQueue.Enqueue(20);
            demoQueue.Enqueue(60);
            Console.WriteLine("Is Queue Empty? " + demoQueue.isEmpty());
            while(!demoQueue.isEmpty())
            {
                Console.WriteLine(demoQueue.Dequeue());
            }
            Console.WriteLine("Is Queue Empty? " + demoQueue.isEmpty());
        }
    }
}