using System;

namespace EPI_6_2
{
    public class MainProblem
    {
        public static void Solve(int[] D)
        {
            int i = D.Length - 1, carry = 1;

            do
            {
                var d = D[i] + carry;
                carry = d / 10;
                D[i--] = d % 10;
            }
            while (carry != 0 && i >= 0);
        }
    }
}
