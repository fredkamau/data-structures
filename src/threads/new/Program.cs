using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    public class Cow : IComparable<Cow>
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Cow(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public int CompareTo(Cow other)
        {
            // Alphabetic sort if weight is equal. [A to Z]
            if (this.Weight == other.Weight)
            {
                return this.Name.CompareTo(other.Name);
            }
            // Default to Weight sort. [High to low]
            return other.Weight.CompareTo(this.Weight);
        }

        public override string ToString()
        {
            // String representation.
            return this.Name.ToString() + "," + this.Weight;
        }
    }
    class Program 
    {
        public static void Main(string[] args)
        {
            List<Cow> mycows = new List<Cow>
            {
                new Cow("freshian", 120),
                new Cow("blacky", 120),
                new Cow("dairy", 90),
                new Cow("fatty", 80)
            };
            mycows.Sort();
            foreach (var item in mycows)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
