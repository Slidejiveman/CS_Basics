// A Namespace Declaration
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is my first attempt to program in C#
/// </summary>
namespace cs_station_Lesson01
{
    class Booleans
    {
        // Main begins program execution
        public static void Main()
        {
            // Variables
            bool content = true;
            bool noContent = false;

            // Write to console
            Console.WriteLine("It is {0} that C# Station provides, C# programming language content.", content);
            Console.WriteLine("The statement above is not {0}.", noContent);
        }
    }
}
