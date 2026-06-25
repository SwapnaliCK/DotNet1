using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    interface IEating
    {
        public void Eat();
    }
    interface IDancing
    {
        public void Dance();
    }

    interface ISleeping
    {
        public void Sleep();
    }

    class Animal : IEating,IDancing, ISleeping
    {
       public void Eat()
        {
            Console.WriteLine("Animals are eating.");
        }
        public void Dance()
        {
            Console.WriteLine("Animals are Dancing");
        }
         
        public void Sleep()
        {
            Console.WriteLine("Animals are sleeping.");
        }

        // n number of methds, n number of interfaces,
    }

    internal class InterfaceTest
    {
        static void Main()
        {
            Animal animal = new Animal();
            animal.Dance();
            animal.Eat();
            animal.Sleep();
            Console.ReadLine();
        }
    }
}
