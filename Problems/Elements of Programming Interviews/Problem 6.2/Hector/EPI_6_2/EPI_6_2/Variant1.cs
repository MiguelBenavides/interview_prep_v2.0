using System;
using System.Collections.Generic;
using System.Text;

namespace EPI_6_2
{
    public class Variant1
    {
        private static int ToInt(char c)
        {
            return c - '0';
        }

        private static char ToChar(int d)
        {
            return (char)('0' + d);
        }

        public static string Solve(string a, string b)
        {
            var ai = a.Length - 1;
            var bi = b.Length - 1;

            var resi = Math.Max(ai, bi);
            var res = new StringBuilder(ai > bi ? a : b, resi + 2);

            var carry = 0;
            while(ai >= 0 && bi >= 0)
            {
                var sum = ToInt(a[ai--]) + ToInt(b[bi--]) + carry;
                carry = sum / 10;
                res[resi--] = ToChar(sum % 10);
            }

            var rem = ai >= 0 ? a : b;
            var remi = ai >= 0 ? ai : bi;

            while(remi >= 0)
            {
                var sum = ToInt(rem[remi--]) + carry;
                carry = sum / 10;
                res[resi--] = ToChar(sum % 10);
            }

            if (carry != 0)
                res.Insert(0, '1');

            return res.ToString();
        }
    }
}
