static int FindMax(int a, int b, int c)
{
    int max = int.MinValue;
    if (a.CompareTo(max) > 0)
    {
        max = a;
    }
    if (b.CompareTo(max) > 0)
    {
        max = b;
    }
    if (c.CompareTo(max) > 0)
    {
        max = c;
    }
    return max;
}
// Test case 1: Max number is at first position
int max1 = FindMax(10, 5, 3);
Console.WriteLine("Max number is: " + max1); // Output: Max number is: 10

// Test case 2: Max number is at second position
int max2 = FindMax(4, 8, 2);
Console.WriteLine("Max number is: " + max2); // Output: Max number is: 8

// Test case 3: Max number is at third position
int max3 = FindMax(1, 3, 7);
Console.WriteLine("Max number is: " + max3); // Output: Max number is: 7
