using StringLibrary;  // Import the StringLibrary project
using System;

class Program
{
    static void Main()
    {
        // Test the extension method
        string test1 = "Hello World";
        string test2 = "hello World";

        Console.WriteLine(test1.StartsWithUpperCase());  // Expected: True
        Console.WriteLine(test2.StartsWithUpperCase());  // Expected: False
    }
}
