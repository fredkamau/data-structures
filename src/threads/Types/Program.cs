using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Student
    {
        public string StudentName { get; set; }
    }
    class Program
    {
        //value types - A data type is a value type if it holds a data value within its own memory space - bool, stucts, int , enum,float, double
        static void changeStatus(int x)
        {
            x = 200; 
            Console.WriteLine(x);
        }
        //reference types dont store its value directly, its stores the address where the value is being stored - strings, arrays, class, delegates
       
        static void Main(string[] args)
        {           
            ////////value type
            int i = 100;
            Console.WriteLine(i);
            changeStatus(i);
            Console.WriteLine(i);

            //////////reference
            void ChangeReferenceType(Student std2)
            {
                std2.StudentName = "Steve";
            }
            Student std1 = new Student();

            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);


        }
    }
}
