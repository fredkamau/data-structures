 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace threads
{
   
    class Program
    {
        static void Main()
        {
            Stack mystack = new Stack();
            mystack.Push("Hello");
            mystack.Push("Fred");
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);

            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }
            Stack stack = new Stack();
            
            Console.WriteLine(mystack.Peek()); //returns 3
            Console.WriteLine(mystack.Pop()); //removes 3
            mystack.Contains(2); // returns true
            mystack.Clear(); // removes all elements 

        }
    } 
    
     
    
}
