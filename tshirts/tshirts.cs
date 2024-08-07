using System;
using Xunit;

namespace TshirtSpace {
    public static char TshirtSize(int cms)
    {
        char sizeName = '\0';

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
        Assert.Equal(TshirtSize(37), 'S');
        Assert.Equal(TshirtSize(38), 'S');
        Assert.Equal(TshirtSize(40), 'M');
        Assert.Equal(TshirtSize(42), 'L');
        Assert.Equal(TshirtSize(44), 'L');
        Console.WriteLine("All is well (maybe!)");
    }
}
