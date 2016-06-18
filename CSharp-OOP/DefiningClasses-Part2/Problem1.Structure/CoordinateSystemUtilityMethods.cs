using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Structure
{
    public static class CoordinateSystemUtilityMethods
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            // Math formula source : http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php
            return
                Math.Sqrt(
                          Math.Pow(Math.Abs(point2.XCoodrinate - point1.XCoodrinate), 2)
                          + Math.Pow(Math.Abs(point2.YCoodrinate - point1.YCoodrinate), 2)
                          + Math.Pow(Math.Abs(point2.ZCoodrinate - point1.ZCoodrinate), 2));
        }
    }
}
