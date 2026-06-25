using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    internal class EnuminC_
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
        static void Main()
        {
           Year Month = Year.January;
            //Year Month = Year.December;
            //string MontName = " January";
            switch (Month)
            {
                case Year.January:
                    Console.WriteLine(" January Starting Month of Year");
                    break;
                case Year.December:
                    Console.WriteLine(" December End Month of Year");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }







        }
    }
}