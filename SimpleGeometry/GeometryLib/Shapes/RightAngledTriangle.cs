﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Прямоугольный треугольник
    /// </summary>
    public class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle(double side1, double side2) 
            : base(side1, side2, Math.Sqrt(side1 * side1 + side2 * side2))
        {

        }
        public override string Print(Shape shape)
        {
            return base.Print(shape);
        }
    }
}
