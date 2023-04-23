namespace Practicer2
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumFinder<int> intMaxFinder = new MaximumFinder<int>(5, 2, 9);
            Console.WriteLine(intMaxFinder.FindMaximum());

            MaximumFinder<string> stringMaxFinder = new MaximumFinder<string>("apple", "banana", "orange");
            Console.WriteLine(stringMaxFinder.FindMaximum());
        }
    }
}