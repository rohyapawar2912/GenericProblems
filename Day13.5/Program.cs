namespace practice5
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 6, 2, 8, 1 };
            PrintMax(Maximum(numbers));

            string[] words = { "apple", "banana", "orange", "pear" };
            PrintMax(Maximum(words));
        }

        static T Maximum<T>(T[] arr) where T : IComparable<T>
        {
            if (arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }

            T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static void PrintMax<T>(T max)
        {
            Console.WriteLine($"Maximum value: {max}");
        }
    }

}