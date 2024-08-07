using System;
using Xunit;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Assert.Equal(Size(37), 'S');
Assert.Equal(Size(38), 'S');
Assert.Equal(Size(40), 'M');
Assert.Equal(Size(42), 'L');
Assert.Equal(Size(44), 'L');
Console.WriteLine("All is well (maybe!)");
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
