using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new1
{
    class Program 
    {
  
        static void Main(string[] args)
        {

            var guestAges = new int[] {23, 45, 2, 12, 56 };
            foreach (var item in guestAges)
            {
                Console.WriteLine($"item is : {item}");
            }

            //enumerator
            var enumarators = guestAges.GetEnumerator();
            while (enumarators.MoveNext())
            {
                Console.WriteLine($"Enumerator is : {enumarators.Current}");
            }
            //another example
            var stringEnumerator = "Hello Fred".GetEnumerator();
            while (stringEnumerator.MoveNext())
            {
                Console.Write(stringEnumerator.Current);
            }
            Console.ReadKey();


        }
    }
}
