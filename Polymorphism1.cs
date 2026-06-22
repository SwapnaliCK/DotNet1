using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    class MathOperations
    {
        //Method overloading: same method name with different parameters
        public int  Add(int a, int b)
        {
            Console.WriteLine("Adding two integers:" + (a + b));
            return a + b;

        }
        public  void  Add(int a, int b, int c)
        {
            Console.WriteLine("Adding three integers:" +( a + b + c));
        }
    }

    internal class Polymorphism1

    {
        static void Main()
        {
            MathOperations math = new MathOperations();
            math.Add(10, 20);
            math.Add(10, 20, 30);
        }
    }
}
