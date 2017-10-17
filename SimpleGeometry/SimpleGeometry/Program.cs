using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;

namespace SimpleGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Iprint> shapes = new List<Iprint>();
            shapes.Add(new Circle(1));
            shapes.Add(new Triangle(6, 5, 4));
            shapes.Add(new RightAngledTriangle(3, 4));
            shapes.Add(new Square(8));
            ShapePrinter st = new ShapePrinter();

            foreach (Shape shape in shapes)
                st.PrintS(shape);

            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
