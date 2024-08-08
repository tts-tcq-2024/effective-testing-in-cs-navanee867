using System;

using System.Diagnostics;

namespace MisalignedSpace
{
    class Misaligned
{
    static int printColorMap()
    {
        string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
        int i = 0, j = 0;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
            }
        }
        return i * j;
    }
    static void Main(string[] args)
    {
        StringWriter sw = new StringWriter();
        Console.SetOut(sw);
        int result = printColorMap();
        string expectedOutput = "0 | White | Blue\n1 | White | Orange\n2 | White | Green\n3 | White | Brown\n4 | White | Slate\n5 | Red | Blue\n6 | Red | Orange\n7 | Red | Green\n8 | Red | Brown\n9 | Red | Slate\n10 | Black | Blue\n11 | Black | Orange\n12 | Black | Green\n13 | Black | Brown\n14 | Black | Slate\n15 | Yellow | Blue\n16 | Yellow | Orange\n17 | Yellow | Green\n18 | Yellow | Brown\n19 | Yellow | Slate\n20 | Violet | Blue\n21 | Violet | Orange\n22 | Violet | Green\n23 | Violet | Brown\n24 | Violet | Slate\n";
        string actualOutput = sw.ToString().Replace("\r\n", "\n");
        
        // Assert
        Assert.Equals(expectedOutput, actualOutput);
        Console.WriteLine("All is well (maybe!)");
    }
}
}
