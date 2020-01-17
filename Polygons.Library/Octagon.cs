using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    // Octagon implements IRegularPolygon, it does NOT inherent from IRegularPolygon
    // When implementing an interface we promise to have all members provided
    public class Octagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
