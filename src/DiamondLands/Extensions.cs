using System;

namespace DiamondLands
{
    public static class Extensions
    {
        public static bool IsPower2(this ulong x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public static uint NextPower2(this uint x)
        {
            x--;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x++;
            return x;
        }

        public static double NextPower2(this double x)
        {
            return Math.Pow(2, Math.Ceiling(Math.Log(x) / Math.Log(2)));
        }
    }
}
