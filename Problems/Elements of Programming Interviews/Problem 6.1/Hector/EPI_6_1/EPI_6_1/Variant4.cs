using System;
using System.Collections.Generic;
using System.Text;

namespace EPI_6_1
{
    public class Variant4
    {
        public class Entry
        {
            public Entry(bool k, int v)
            {
                Key = k;
                Value = v;
            }

            public bool Key;
            public int Value;
        }
        private static void Swap<T>(T[] arr, int a, int b)
        {
            T temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public static void Solve(Entry[] A)
        {
            int last = A.Length - 1;

            for(var i = A.Length - 1; i >= 0; i--)
            {
                if (A[i].Key)
                    Swap(A, i, last--);
            }
        }
    }
}
