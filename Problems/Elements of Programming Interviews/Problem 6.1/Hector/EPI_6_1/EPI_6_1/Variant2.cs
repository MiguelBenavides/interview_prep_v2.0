using System;
using System.Collections.Generic;
using System.Text;

namespace EPI_6_1
{
    public class Variant2
    {
        public static void Solve(int[] A)
        {
            var counts = new int[] { 0, 0, 0, 0 };

            foreach (var val in A)
                counts[val]++;

            var last = 0;
            for(var countIndex = 0; countIndex < counts.Length; countIndex++)
            {
                var count = counts[countIndex];
                for (var i = last; i < last + count; i++)
                    A[i] = countIndex;

                last += count;
            }
        }
    }
}
