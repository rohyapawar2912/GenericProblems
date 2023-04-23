static float FindMax(float a, float b, float c)
{
    float max = float.MinValue;
    if (a > max)
    {
        max = a;
    }
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;
}
// Test case 1: Max number is at first position
float max1 = FindMax(10.0f, 5.0f, 3.0f);
Console.WriteLine("Max number is: " + max1); // Output: Max number is: 10

// Test case 2: Max number is at second position
float max2 = FindMax(4.0f, 8.0f, 2.0f);
Console.WriteLine("Max number is: " + max2); // Output: Max number is: 8

// Test case 3: Max number is at third position
float max3 = FindMax(1.0f, 3.0f, 7.0f);
Console.WriteLine("Max number is: " + max3); // Output: Max number is: 7
