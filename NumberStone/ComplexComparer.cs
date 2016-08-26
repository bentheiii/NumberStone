using System.Collections.Generic;

namespace NumberStone.Complex
{
    public static class ComplexComparers
    {
        public static readonly IComparer<ComplexNumber> TotalOrder = new TotalOrderClass(), PartialOrder = new PartialOrderClass();
        private class TotalOrderClass : IComparer<ComplexNumber>
        {
            public int Compare(ComplexNumber x, ComplexNumber y)
            {
                var radii = x.Radius.CompareTo(y.Radius);
                return radii != 0 ? radii : x.Angle.Arbitrary.CompareTo(y.Angle.Arbitrary);
            }
        }
        private class PartialOrderClass : IComparer<ComplexNumber>
        {
            public int Compare(ComplexNumber x, ComplexNumber y)
            {
                return x.CompareTo(y);
            }
        }
    }
}
