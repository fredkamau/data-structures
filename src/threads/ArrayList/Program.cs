using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList2
{
    class Program
    {
        //represents collection of an object that can be indexed individually
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(3);//Adds an object to the ArrayList.
            al.Add("fred");
            al.Add(7);
            int position = al.Add("kamau");
            Console.WriteLine("The name kamau was added at position:" + position);
            al.Insert(4, "Gathegi");//Insert an element into the ArrayList at a specified index.
            al.RemoveAt(2);//Removes an element at the specified index
            Console.WriteLine($"Capacity:{al.Capacity}");//sets or gets the number of list that the arrayList can contain
            Console.WriteLine($"Capacity:{al.Count}");//Returns the number of elements currently in the ArrayList
            //al.Sort(); //Alphabetically sorts the elements in the ArrayList.

            foreach (object i in al)
            {
                Console.WriteLine($"content:{i}");
            }



        }
    }
}
