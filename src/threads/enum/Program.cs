using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        //An enumeration is a set of named integer constants - value type
        public enum gender
        {
            male = 1,
            female,
            unknown
        }

        static void Main(string[] args)
        {
            //enums are datatypes so you can create variables
            gender casegender = gender.female;
            Console.WriteLine(casegender);
            Console.WriteLine(gender.male);
            Console.WriteLine((int)gender.male);
        }
        
    }
}
