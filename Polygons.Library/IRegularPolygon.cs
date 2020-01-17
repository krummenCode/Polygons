using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    public interface IRegularPolygon
    {
        // Declarations
        // No access modifiers, all members of an interface are automatically public
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
