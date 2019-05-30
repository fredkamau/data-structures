using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a sorted list represents a collection of key value pairs.which are sorted by the key
            //its a combination of both the array and hashtable
            SortedList ws = new SortedList();
            ws.Add("200","Black Coffee");
            ws.Add("250", "Milk Coffee");
            ws.Add("300", "Latte");
            ws.Add("350", "Espresso");
            ws.Add("380", "Capuccino");

            //if (ws.ContainsValue("Yoghurt"))
            //{
            //    Console.WriteLine("This drink does not exist");
            //}
            //else
            //{
            //    ws.Add("120", "Yoghurt");
            //}

            ICollection k = ws.Keys;
            foreach ( string m in ws)
            {
                Console.WriteLine(k + ":" + ws[k]);
            }
        }
    }
}
