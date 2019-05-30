using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue line = new Queue();
            line.Enqueue(3);
            line.Enqueue(5);
            line.Enqueue(2);
            line.Enqueue(1);
            line.Enqueue("Four");          
            foreach (var laini in line)
            {
                Console.WriteLine(laini);
            }
        }
    }
}
