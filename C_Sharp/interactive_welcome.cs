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
    class InteractiveWelcome
    {
        // Main begins program execution
        public static void Main()
        {
            // Write to console
            Console.Write("What is your name? ");
            Console.Write("Hello, {0}! ", Console.ReadLine());
            Console.WriteLine("Welcome to the C# Station Tutorial!");
        }
    }
}
