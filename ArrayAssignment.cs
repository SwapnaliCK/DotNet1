using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{ 
    internal class ArrayAssignment
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50, 60 };
        //alater
        Console.WriteLine("\nAlternate element  in Array:");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine(array[i]);

        }
        //number of array element
        Console.WriteLine("\nNumber of Element in Array:" + array.Length);
        //smallest element
        int minimum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
                minimum = (array[i]);
        }
        Console.WriteLine("\nSmallest Number in array:" + minimum);
        //largest element
        int maximum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
                maximum = (array[i]);
        }
        Console.WriteLine("\nLargest Number in array:" + maximum);


        }

    }

}
