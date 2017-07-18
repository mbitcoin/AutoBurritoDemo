using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseBurrito
    {
        public bool riceFlag; //optional rice or not, 0 is no 1 is yes
        public BaseBurrito(bool riceFlag)
        {
            
        }
    }

    class BurritoBowl : BaseBurrito
    {
        public double cost = 3.99;

        public BurritoBowl(bool riceFlag, MeatIngredient meat, SalsaIngredient salsa) : base(riceFlag)
        {
            if (salsa.salsaType == "queso") //more moneys
            {
                cost = cost + 1.50;
            }
            
        }
    }

      class BurritoTwo : BaseBurrito
      {
        public double cost = 4.99;

        public BurritoTwo(bool riceFlag, MeatIngredient meat, SalsaIngredient salsa) : base(riceFlag)
        {
            if (salsa.salsaType == "queso") //more moneys
            {
                cost = cost + 1.50;
            }
        }
      }

      class BurritoThree : BaseBurrito
    {
        public double cost = 5.99;

        public BurritoThree(bool riceFlag, MeatIngredient meat, SalsaIngredient salsa, ToppingIngredient topping) : base(riceFlag)
        {
            if (salsa.salsaType == "queso") //more moneys
            {
                cost = cost + 1.50;
            }

            if (topping.toppingType == "guacamole") //more moneys
            {
                cost = cost + 1.25;
            }
        }
    }

}
