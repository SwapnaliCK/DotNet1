using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    sealed class Sizes
    {
        public void Drawing()
        {
            Console.WriteLine("Drawing Sizes");
        }
        public void Painting()
        {
            Console.WriteLine("Painting Shapes");
        }

        static void Main()
        {
            Sizes s = new Sizes();

            s.Drawing();
            s.Painting();   
        }

    }
}
