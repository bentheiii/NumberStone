using System.Collections.Generic;

namespace NumberStone
{
    public static class @base
    {
        public static long ConvertFromBase(IEnumerable<int> x, int originalbase)
        {
            long ret = 0;
            int p = 1;
            foreach (int t in x)
            {
                ret += t * p;
                p *= originalbase;
            }
            return ret;
        }
        public static IEnumerable<int> ConvertToBase(int x, int tobase)
        {
            return ConvertToBase((long)x, tobase);
        }
        public static IEnumerable<int> ConvertToBase(long x, int tobase)
        {
            while (x > 0)
            {
                yield return (int)(x % tobase);
                x /= tobase;
            }
        }
    }
}
