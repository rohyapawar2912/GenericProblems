static T FindMax<T>(params T[] values) where T : IComparable<T>
{
    if (values.Length == 0)
    {
        throw new ArgumentException("At least one value must be provided.");
    }
    Array.Sort(values);
    return values[values.Length - 1];
}
string maxString = FindMax("Apple", "Peach", "Banana", "Cherry", "Grape", "Watermelon", "Kiwi", "Orange", "Pineapple");
Console.WriteLine("Max string is: " + maxString); // Output: Max string is: Watermelon

int maxInt = FindMax(10, 20, 30, 40, 50);
Console.WriteLine("Max integer is: " + maxInt); // Output: Max integer is: 50

double maxDouble = FindMax(1.1, 2.2, 3.3, 4.4, 5.5, 6.6);
Console.WriteLine("Max double is: " + maxDouble); // Output: Max double is: 6.6