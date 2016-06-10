using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Structure
{
    public struct Point3D
    {
        public Point3D(double xCoodrinate, double yCoodrinate, double zCoodrinate)
        {
            this.XCoodrinate = xCoodrinate;
            this.YCoodrinate = yCoodrinate;
            this.ZCoodrinate = zCoodrinate;
        }

        public double XCoodrinate { get; set; }
        public double YCoodrinate { get; set; }
        public double ZCoodrinate { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.XCoodrinate, this.YCoodrinate, this.ZCoodrinate);
        }
    }
}
