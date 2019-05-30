using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface I1
    {
        void name();
    }
    interface I2
    {
        void name();
    }
    class Program : I1, I2
    {
        void I1.name()
        {
            Console.WriteLine("My name is fred");
        }
        void I2.name()
        {
            Console.WriteLine("My name is kamau");
        }
        public static void Main()
        {
            Program p = new Program();
            ((I1)p).name();
            ((I2)p).name();
        }
    }
}
