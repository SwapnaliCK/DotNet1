using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    internal class ReverseString

    { 
        static void Main()
        {
            string str = "CODEMIND";
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            Console.WriteLine(rev);
        }
        
    }
}
  
