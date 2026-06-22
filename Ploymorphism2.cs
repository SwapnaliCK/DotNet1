using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    //method overriding: same method name and parameters in base and derived class
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }


    internal class Ploymorphism2
    {
        static void Main()
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Rectangle();
            shape1.Draw(); // Output: Drawing a circle.
            shape2.Draw(); // Output: Drawing a rectangle.
        }
    }
}
