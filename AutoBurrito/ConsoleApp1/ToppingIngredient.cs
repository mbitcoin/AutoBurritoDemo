using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ToppingIngredient
    {
        public string toppingType { get; set; }

        public ToppingIngredient()
        {

        }

        public void toppingSelect()
        {
            Console.WriteLine("Choose your toppings");
            Console.WriteLine("Enter 1 for grated cheese, 2 for sour cream, 3 for guacamole");
            string toppingTypeSelect = Console.ReadLine();
            switch (toppingTypeSelect)
            {
                case "1":
                    toppingType = "grated cheese";
                    break;
                case "2":
                    toppingType = "sour cream";
                    break;
                case "3":
                    toppingType = "guacamole";
                    break;
                default:
                    toppingType = "invalid";
                    Console.WriteLine("Invalid topping selection!");
                    toppingSelect();
                    break;
            }
        }
    }
}
