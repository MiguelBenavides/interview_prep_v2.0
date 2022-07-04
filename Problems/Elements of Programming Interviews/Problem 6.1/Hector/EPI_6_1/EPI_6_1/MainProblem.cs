using System;
using System.Collections;

namespace EPI_6_1
{
    public class MainProblem
    {
        private static void Swap<T>(T[] arr, int a, int b)
        {
            T temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public static void Solve(int[] A, int pivotIndex)
        {
            int pivot = A[pivotIndex];
            int i = 0, l = 0, t = A.Length - 1;

            while(i <= t)
            {
                if (A[i] < pivot)
                    Swap(A, i++, l++);
                else if (A[i] > pivot)
                    Swap(A, i, t--);
                else
                    i++;
            }
        }
    }
}
