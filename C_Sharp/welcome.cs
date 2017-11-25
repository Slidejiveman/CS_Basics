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
    class NamedWelcome
    {
        // Main begins program execution
        static void Main(string[] args)
        {
            // Write to console
            Console.WriteLine("Hello, {0}!", args[0]);
            Console.WriteLine("Welcome to the C# Station Tutorial!");
        }
    }
}
