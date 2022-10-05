// Stack Implementation in C#
// Using Generics 
// Underlying Implementation is an Array
// By Haroldas Varanauskas
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Stack<string> testStack = new Stack<string>(size);
            testStack.push("Test String ");
            testStack.push("Second Item");
            testStack.push("Third Item");
            Console.WriteLine("Is this stack Full?");
            Console.WriteLine(testStack.isFull().ToString());
            Console.WriteLine("Peek On the Stack!");
            Console.WriteLine(testStack.peek().ToString());
            Console.WriteLine("Pop the Stack!!!");
            testStack.pop();
            Console.WriteLine("Peek On the Stack!");
            Console.WriteLine(testStack.peek().ToString());
            Console.WriteLine(testStack.isEmpty().ToString());
        }
    }
}