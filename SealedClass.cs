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
  
        static void Main()
        {
            Sizes s = new Sizes();

            s.Drawing();
        }

    }
}
