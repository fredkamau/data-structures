using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My name is Kyle Kamau";
            int len = name.Length;
            int pos = name.IndexOf(" ");
            string firstWord = name.Substring(0, pos);
            string secondWord = name.Substring(pos + 1, (len - 1) - (pos + 1));
            string s = "Now is the time";
            int sub = s.Length;
            Console.WriteLine(sub);
            Console.WriteLine("First word: " + firstWord);
            Console.WriteLine("Second word: " + secondWord);
           // Console.Read();
            //Methods for comparing strings.ASCII- American Standard codes for information interchange
            //is how we encode characters(text) in computers
            //compare using Equals
            string s1 = "foobar";
            string s2 = "foobar";
            if (s1.Equals(s2))
            {
                Console.WriteLine("They are the same.");
            }
            else
            {
                Console.WriteLine("They are not the same.");
            }
            //compare using compareTo
            string string1 = "foobar";
            string string2 = "foobar";
            Console.WriteLine(string1.CompareTo(string2)); // returns 0 - strings are equal
            string2 = "foofoo";
            Console.WriteLine(string1.CompareTo(string2)); // returns -1 - below
            string2 = "fooaar";
            Console.WriteLine(string1.CompareTo(string2)); // returns 1 - above
        }
    }
}
