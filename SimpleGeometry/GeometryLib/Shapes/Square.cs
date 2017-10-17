using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
     public class Square: Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            if (side <= 0)
                throw new ArgumentOutOfRangeException();
            Side = side;
        }

        public override string Print()
        {
            double area = Side * Side;
            return String.Format($"Square: Side = {Side}  Area = {area}");
        }
    }
}
