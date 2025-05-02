// Written by Holbrait
// 02/11/25

using System;
using System.Collections.Generic;

namespace FindMinMaxAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> aList = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Calculator aCalculator = new Calculator();

            int minimum = aCalculator.FindMin(aList);

            Console.WriteLine("The minimum is " + minimum);
        }
    }

    public class Calculator
    {
        public int FindMin(List<int> aList)
        {
            int min = aList[0];

            foreach (int i in aList)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }
    }
}
