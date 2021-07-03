using System;
using GameSpace;
using Calculations;

namespace MainSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BlingBlong.Game();
            
            Sum newSum = new Sum(8);
            newSum.Calculate();
        }
    }
}
