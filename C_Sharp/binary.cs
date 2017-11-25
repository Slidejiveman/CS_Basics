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
    class Binary
    {
        // Main begins program execution
        public static void Main()
        {
            // Variables
            int x, y, result;
            float floatResult;

            // Operations
            x = 7;
            y = 5;

            result = x + y;
            Console.WriteLine("x + y: {0}", result);

            result = x - y;
            Console.WriteLine("x - y: {0}", result);

            result = x * y;
            Console.WriteLine("x * y: {0}", result);

            result = x / y;
            Console.WriteLine("x / y: {0}", result);

            floatResult = (float)x / (float)y;
            Console.WriteLine("Float: x / y: {0}", floatResult);

            result = x % y;
            Console.WriteLine("x % y: {0}", result);

            result += x;
            Console.WriteLine("result += x: {0}", result);
        }
    }
}
