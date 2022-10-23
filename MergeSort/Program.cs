
namespace Merge_sort
{
    class Program
    {
        // Main 
        static void Main(string[] args)
        {
            // Sorted and Unsorted Lists
            List<int> unsorted = new List<int>();
            List<int> sorted;

            string size;
            int sizeForComparison = 0;
            Console.WriteLine("Enter a size of list to be generated: ");
            // Making sure that the user enter a Number 
            while(sizeForComparison == 0)
            {
                size = Console.ReadLine();
                try
                {
                    sizeForComparison = Int32.Parse(size);
                }catch(Exception)
                {
                    Console.WriteLine("Please Enter a Number");
                }
            }

            Random random = new Random();
            // Generate a List each item between 0 - 100
            Console.WriteLine("Original List of generated elements:");
            for (int i = 0; i < sizeForComparison; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            // Start Stopwatch Before Calling the function
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            sorted = MergeSort(unsorted);
            // Stop Stopwatch after function returns
            stopWatch.Stop();
           
            Console.WriteLine("Sorted List of elements: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
            Console.WriteLine(" ");
            // Dsiplay Stopwatch
            Console.WriteLine("Total Elapsed Milisecods " + stopWatch.ElapsedMilliseconds);
        }


        // Merge Sort Method
        private static List<int> MergeSort(List<int> unsorted)
        {
            // Base Case 
            if (unsorted.Count <= 1)
                return unsorted;

            // Left and right lists 
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            // Get Middle
            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }
        // Merge Method
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}