using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Coffee
    {
        private int _price;
        private string _coffeeName;

        public int Price { get => _price; set => _price = value; }
        public string CoffeeName { get => _coffeeName; set => _coffeeName = value; }
    }
    class Program
    {
        //A dictionary is a collection of key value pairs
        //operations include add(), remove(), clear()-remove all
        static void Main(string[] args)
        {
            //coffee dictionary
            Dictionary<int, Coffee> coffeeDict = new Dictionary<int, Coffee>();
            Coffee c1 = new Coffee { Price = 300, CoffeeName = "Capuccinno" };
            Coffee c2 = new Coffee { Price = 250, CoffeeName = "Espresso" };
            Coffee c3 = new Coffee { Price = 200, CoffeeName = "Latte" };
            Coffee c4 = new Coffee { Price = 150, CoffeeName = "Milk Coffee" };
            Coffee c5 = new Coffee { Price = 100, CoffeeName = "White Coffee" };
            //greetings and coffee selection
            Console.WriteLine("Whats your Name?");
            string Name = Console.ReadLine();
            Console.WriteLine($"Welcome {Name}");
            Start:
            Console.WriteLine("Which Coffee would you want today?");
            Console.WriteLine("1-Capuccinno 2- Espresso, 3- Latte, 4- milk Coffee, 5-White Coffee?");
            //adding to cart
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                coffeeDict.Add(c1.Price, c1);
            }
            else if (selection == 2)
            {
                coffeeDict.Add(c2.Price, c2);
            }
            else if (selection == 3)
            {
                coffeeDict.Add(c3.Price, c3);
            }
            else if (selection == 4)
            {
                coffeeDict.Add(c4.Price, c4);
            }
            else if(selection == 5)
            {
                coffeeDict.Add(c5.Price, c5);
            }
            Console.WriteLine("Would you like to add another coffee? - Yes or No");
            string selection2 = Console.ReadLine();

            if (selection2.ToUpper() == "YES")
            {
                goto Start;
            }
            else if(selection2.ToUpper() == "NO")
            {
                int totalBill = 0;
                foreach (KeyValuePair<int, Coffee> coffeeList in coffeeDict)
                {
                    totalBill = totalBill + coffeeList.Value.Price;
                    Console.WriteLine($"Coffee selected:{coffeeList.Value.CoffeeName}");
                    Console.WriteLine($"Price:{coffeeList.Value.Price}");
                    Console.WriteLine($"Total Bill: {totalBill}");
                }
            }
            

        }
    }
}
