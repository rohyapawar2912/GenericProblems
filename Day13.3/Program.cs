static string FindMax(string a, string b, string c)
{
    string max = "";
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
// Test case 1: Max string is at first position
string max1 = FindMax("Apple", "Peach", "Banana");
Console.WriteLine("Max string is: " + max1); // Output: Max string is: Peach

