using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;

namespace GeometryLib
{
    public  class ShapePrinter
    {
        public  void PrintS(Shape print)
        {
            double area = 0;

            if (print is Circle)
            {
                var circle = (Circle) print;
              Console.WriteLine(  circle.Print(print));
            }
            else if (print is RightAngledTriangle)
            {
                var rightTriangle = (RightAngledTriangle) print;
               Console.WriteLine( rightTriangle.Print(print));
            }
            else if (print is Triangle)
            {
                var triangle = (Triangle) print;


                Console.WriteLine(triangle.Print(print));
            }
        }
    }
}
