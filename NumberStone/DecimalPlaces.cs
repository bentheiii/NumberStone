﻿namespace NumberStone
{
    public static class decimalPlaces
    {
        //todo: binary search
        public static int Decimalplaces(this double a, int @base = 10)
        {
            double s = a % 1;
            int ret = 0;
            while (s != 0)
            {
                s = (s * @base) % 1;
                ret++;
            }
            return ret;
        }
    }
}
