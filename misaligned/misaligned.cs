using System;

using System.Diagnostics;

namespace MisalignedSpace
{
    class Misaligned
    {
        private static readonly string[] _majorColor = { "White", "Red", "Black", "Yellow", "Violet" }; 
        private static readonly string[] _minorColor = { "Blue", "Orange", "Green", "Brown", "Slate" }; 

        private static void PrintColorMap()
        {
            for (int majorColorIndex = 0; majorColorIndex < _majorColor.Length; majorColorIndex++)
            {
                for (int minorColorIndex = 0; minorColorIndex < _minorColor.Length; minorColorIndex++)
                {
                    Console.WriteLine($"{((majorColorIndex * 5 + minorColorIndex) + 1),-3} | {_majorColor[majorColorIndex],-7} | {_minorColor[minorColorIndex]}");
                }
            }
        }

        private static void Main(string[] args)
        {
            PrintColorMap();

            Debug.Assert(_majorColor.Length == 7);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
