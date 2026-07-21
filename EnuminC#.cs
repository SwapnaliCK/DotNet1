using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    enum Year
    {

        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,

    }
    internal class EnuminC_
    {

        static void Main()
        {

            Console.Write("Enter Month Name : ");

            string Month = Console.ReadLine();

            //Year Month = Year.January;
            ////Year Month = Year.December;

            switch (Month)
            {
                case "January":
                    Console.WriteLine(" January Starting Month of Year");
                    break;
                case "December":
                    Console.WriteLine(" December End Month of Year");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

                    Console.ReadKey();
                    //
            }







        }
    }
}