using System;
using System.Linq;
using WhetStone.Looping;

namespace NumberStone
{
    public static class name
    {
        public enum ScaleType { LongScale = 0, ShortScale = 1 };
        public static string Name(this long x, ScaleType scaletouse = ScaleType.ShortScale, int definitionlimit = 2)
        {
            string[][] unitsnames =
            {
                new[] {"", " Thousand", " Million", " Billion", " Trillion", " Quadrillion", " Quintillion"},
                new[] {"", " Thousand", " Million", " Milliard", " Billion", " Billiard", " Trillion"}
            };
            if (x < 0)
                return "Negative " + Name(-x, scaletouse);
            if (x < 1000)
                return x.ToString();
            string[] scale = unitsnames[(int)scaletouse];
            return @base.ConvertToBase(x, 1000)
                    .CountBind()
                    .Select(a => Tuple.Create(a.Item1, scale[a.Item2]))
                    .ToArray()
                    .Reverse()
                    .Take(definitionlimit)
                    .Select(a => $"{a.Item1} {a.Item2}")
                    .StrConcat();
        }
        public static string Name(this int x, ScaleType scaletouse = ScaleType.ShortScale, int definitionlimit = 2)
        {
            return Name((long)x, scaletouse, definitionlimit);
        }
    }
}
