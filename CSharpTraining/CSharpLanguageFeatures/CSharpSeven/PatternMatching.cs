using CSharpLanguageFeatures.Shape;
using System;

namespace CSharpLanguageFeatures.CSharpSeven
{
    public class PatternMatching
    {
        public static double CalculateArea(object shape)
        {
            switch (shape)
            {
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                    return 0;

                case Square s:
                    return s.Side * s.Side;

                case Circle c:
                    return c.Radius * c.Radius * Math.PI;

                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }
    }
}
