using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    //Abstract class is blueprint to other classses.
    abstract class Payments
    {
        public abstract void Pay();
        //n number of abstarct methods in a single abstract class
        //abstarct class can have abstarct and non abstarct methods
    }

    class CreditCard : Payments
    {
        // the n number of abstarct methods that we created that we have to implement here in child class using "override" keyword
        public override void Pay()
        {
            Console.WriteLine("Payment through Credit Card");
        }



    }
    class UPI : Payments
    {

        public override void Pay()
        {
            Console.WriteLine("Payment through UPI");
        }


    }
    internal class Abstraction2
    {
        static void Main(string[] args)
        {
            Payments payment1 = new CreditCard();
            payment1.Pay();
            Payments payment2 = new UPI();
            payment2.Pay();
        }





    }
}