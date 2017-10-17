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
        public void PrintS(Iprint Shape)
        {
            Console.WriteLine(Shape.Print());
        }
    }
}
