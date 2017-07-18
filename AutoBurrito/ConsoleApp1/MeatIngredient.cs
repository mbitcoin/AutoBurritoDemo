using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MeatIngredient
    {
        public string meatType { get; set; }

        public MeatIngredient()
        {

        }

        public void meatSelect()
        {
            Console.WriteLine("Choose your Meat");
            Console.WriteLine("Enter 1 chicken, 2 for steak");
            string meatTypeSelect = Console.ReadLine();
            switch (meatTypeSelect)
            {
                case "1":
                    meatType = "chicken";
                    break;
                case "2":
                    meatType = "steak";
                    break;
                default:
                    Console.WriteLine("Invalid meat selection!");
                    meatType = "invalid";
                    meatSelect();
                    break;
            }
        }


    }
}
