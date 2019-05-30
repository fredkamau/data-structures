using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Area(int length, int width)
        {
            return length * width;
        }
        static void Main(string[] args)
        {
            var area = Area( 12, 23);
            Console.WriteLine(area);
        }
    }
}
