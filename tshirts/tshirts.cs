using System;
using System.Diagnostics;

namespace TshirtSpace {
    public static char TshirtSize(int cms)
    {
        char sizeName = '';

        if (cms < 38)
        {
            sizeName = 'S';
        }
        else if (cms > 38 && cms < 42)
        {
            sizeName = 'M';
        }
        else if (cms > 42)
        {
            sizeName = 'L';
        }

        return sizeName;
    }

    public static void Main()
{
    Debug.Assert(TshirtSize(37) == 'S');
    Debug.Assert(TshirtSize(38) == 'S');
    Debug.Assert(TshirtSize(40) == 'M');
    Debug.Assert(TshirtSize(42) == 'L');
    Debug.Assert(TshirtSize(44) == 'L');
    Console.WriteLine("All is well (maybe!)");
}
}
