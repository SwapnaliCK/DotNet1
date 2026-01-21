using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet1
{
    internal class HASHTABLEExapmple
    {
        static void Main()
        {
            Hashtable myHastable = new Hashtable();
            myHastable.Add(1, "C");
            myHastable.Add(2, "C++");
            myHastable.Add(3, "C#");
            myHastable.Add(4, "Cloud");
            myHastable.Add(5, "Java");
            myHastable.Add(6, "Python");
            myHastable.Add(7, "Google");
            Console.WriteLine(myHastable.ToString());
            Console.WriteLine("\nMyHastable");

            foreach (DictionaryEntry entry in myHastable)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");


            }
            //modification
            myHastable[4]= "AWS";

             //Remove
            myHastable.Remove(7);
            Console.WriteLine("\nModified myHashtable");
            foreach (DictionaryEntry entry in myHastable)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");


            }







        }


    }
}
