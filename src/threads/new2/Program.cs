using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace new2
{
    
    class Program
    {
        //a delagate is a type safe function pointer
        public delegate void printDelegate(string maneno);
        public static void print(string words)
        {
            Console.WriteLine(words);
        }
        static void Main(string[] args)
        {
            printDelegate pd = new printDelegate(print);
            pd("Mjanja");
            Console.WriteLine(words);
        }
    }
}
