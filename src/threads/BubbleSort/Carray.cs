using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Carray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public Carray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public Carray() { }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            Console.Write(arr[i] + " ");
        }
        public void clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        static void Main()
        {
            Carray nums = new Carray();
            for (int i = 0; i <= 49; i++)
             nums.Insert(i);
            nums.DisplayElements();
        }
    }
}
