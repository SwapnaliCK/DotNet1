using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    abstract class Payments
    {
        public abstract void Pay();
        //extra logic
    }

    class CreditCard : Payments
    {
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
    
     
       
    
        static void Main()
        {


            Payments payment1 = new CreditCard();
            payment1.Pay();
            Payments payment2 = new UPI();
            payment2.Pay();


        }






    }
}













