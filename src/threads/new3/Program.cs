using System;
using System.Collections.Generic;

namespace new3
{
    class Program
    {
        class Coffee
        {
            private int _price;
            private string _name;     

            public int Price
            {
                get { return this._price; }
                set { this._price = value; }
            }

            public string Name
            {
                get => _name;
                set => _name = value;
            }
            
        }

        public static void Main(string[] args)
        {
            Coffee c1 = new Coffee
            {
                Price = 300,
                Name = "Capuccino"
            };
            Coffee c2 = new Coffee
            {
                Price = 250,
                Name = "Expresso"
            };
            Coffee c3 = new Coffee
            {
                Price = 200,
                Name = "Latte"
            };

            Dictionary<int, Coffee> dictionaryCoffee = new Dictionary<int, Coffee>();
            switch(Coffee)
                case 1:
            dictionaryCoffee.Add(c1.Price, c1);
            dictionaryCoffee.Add(c2.Price, c2);
            dictionaryCoffee.Add(c3.Price, c3);
            dictionaryCoffee.Add(c3.Price, c3);
        }

    }
}
       
       
   

