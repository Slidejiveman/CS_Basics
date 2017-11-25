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
    class Unary
    {
        // Main begins program execution
        public static void Main()
        {
            // Variables
            int unary = 0;
            int preIncrement;
            int preDecrement;
            int postIncrement;
            int postDecrement;
            int positive;
            int negative;
            sbyte bitNot;
            bool logNot;

            // Operations
            preIncrement = ++unary;
            Console.WriteLine("pre-increment: {0}", preIncrement);

            preDecrement = --unary;
            Console.WriteLine("pre-decrement: {0}", preDecrement);

            postDecrement = unary--;
            Console.WriteLine("post-decrement: {0}", postDecrement);

            postIncrement = unary++;
            Console.WriteLine("post-increment: {0}", postIncrement);

            Console.WriteLine("Final Value of Unary: {0}", unary);

            positive = -postIncrement;
            Console.WriteLine("Positive: {0}", positive);

            negative = +postIncrement;
            Console.WriteLine("Negative: {0}", negative);

            bitNot = 0;
            bitNot = (sbyte)(~bitNot);
            Console.WriteLine("Bitwise Not: {0}", bitNot);

            logNot = false;
            logNot = !logNot;
            Console.WriteLine("Logical Not: {0}", logNot);
        }
    }
}
