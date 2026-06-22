using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    static class Shapes
    {
        public static void Draw()
        {
            Console.WriteLine("Drawing a shape");

        }
    }

    internal class StaticClass
    {
        static void Main()
        {
            Shapes.Draw();
        }
    }
}
