using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class ArrayStaff
    {

        

    }
    
  
    class Program
    {
        static void Main(string[] args)
        {
            //return type of array
            string[] users = new string[3] {"fred", "Kamau", "Gathegi" };
            Type arrayType = users.GetType();
            if (arrayType.IsArray)
            {
                Console.WriteLine("The array type is: {0}", arrayType);
            }
            else
            {
                Console.WriteLine("Not an array");
            }
            //2-multimensional arrays
            // ... Create 2D array of strings.
            string[,] array = new string[,]
            {
            {"cat", "dog"},
            {"bird", "fish"},
            };
            // ... Print out values.
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);
            //GetUpperBound-This method receives the highest index of the specified rank (passed as an argument). It returns an int. 
            string[,] codes = new string[,]
            {
            {"AA", "BB"},
            {"CC", "DD"}
            };
            // Get the upper bound.
            // ... Use for-loop over rows.
            for (int i = 0; i <= codes.GetUpperBound(0); i++)
            {
                string s1 = codes[i, 0];
                string s2 = codes[i, 1];
                Console.WriteLine("{0}, {1}", s1, s2);
            }
            //jagged arrays - array of arrays where each row is made up of an array
            //however the number of elements in each row may be different
            int[,] sales = new int[12, 30];//there are different number of day in every month
            //This can be easily developed by a jagged arrays
            // Declare the Jagged Array of four elements: 
            int[][] jagged_arr = new int[4][];
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            //display array elements
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                //print row number
                System.Console.Write("Row({0}): ", i);
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    // Print the elements in the row 
                    System.Console.Write("{0} ", jagged_arr[i][j]);
                }
                System.Console.WriteLine();

            }
            //mix jagged arrays and multidimensional arrays
            int[][,] jagged_arr1 = new int[4][,]
             {
                new int[, ] { {1, 3}, {5, 7} },
                new int[, ] { {0, 2}, {4, 6}, {8, 10} },
                new int[, ] { {7, 8}, {3, 1}, {0, 6} },
                new int[, ] { {11, 22}, {99, 88}, {0, 9} }
             };
            Console.WriteLine("{0}", jagged_arr1[1][1, 0]);






        }
    }
}
