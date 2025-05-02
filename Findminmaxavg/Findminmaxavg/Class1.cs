// Written by Holbrait
// 02/11/25

using System;
using System.Collections.Generic;

namespace FindMinMaxAvg
{
    public class Class1
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
