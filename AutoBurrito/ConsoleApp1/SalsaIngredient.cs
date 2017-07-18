using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SalsaIngredient
    {

        public string salsaType { get; set; }

        public SalsaIngredient()
        {

        }

        public void salsaSelect()
        {
            Console.WriteLine("Choose your salsa");
            Console.WriteLine("Enter 1 red Salsa, 2 for green Salsa, 3 for queso");
            string salsaTypeSelect = Console.ReadLine();
            switch (salsaTypeSelect)
            {
                case "1":
                    salsaType = "red salsa";
                    break;
                case "2":
                    salsaType = "green salsa";
                    break;
                case "3":
                    salsaType = "queso";
                    break;
                default:
                    salsaType = "invalid";
                    Console.WriteLine("Invalid salsa selection!");
                    salsaSelect();
                    break;
            }
        }

    }
}
