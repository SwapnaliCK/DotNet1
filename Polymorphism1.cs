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
        //Method overloading/compile time: same method name with different parameters
        public int  Add(int a, int b)
        {
            Console.WriteLine("Adding two integers:" + (a + b));
            return a + b;

        }
        public  void  Add(int a, int b, int c)
        {
            Console.WriteLine("Adding three integers:" +( a + b + c));

        }
        public void Display(string FirstName, string LastName)//formal parameters
        {
            Console.WriteLine("FullName: " +( FirstName+ LastName ));

        }

    }

    internal class Polymorphism1

    {
        static void Main()
        {
            MathOperations math = new MathOperations();
            math.Add(10, 20);
            math.Add(10, 20, 30);
            math.Display("Swapnali", "Khandekar");//actual parameter
        }
    }
}
