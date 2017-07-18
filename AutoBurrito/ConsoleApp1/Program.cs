using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static List<BurritoBowl> burritoBowlList = new List<BurritoBowl>();
        public static List<BurritoTwo> burritoTwoList = new List<BurritoTwo>();
        public static List<BurritoThree> burritoThreeList = new List<BurritoThree>();

        static void Main(string[] args)
        {
            int moreBurritoEnterFlag = 1;
            while (moreBurritoEnterFlag == 1)
            {
                burritoEnter();

                moreBurritoEnterFlag = moreBurritoCheck();
            }

            burritoCost();


            string exitConsole = Console.ReadLine();
        }

        public static void burritoEnter()
        {
            MeatIngredient myMeat = new MeatIngredient();
            SalsaIngredient mySalsa = new SalsaIngredient();
            ToppingIngredient myTopping = new ToppingIngredient();
            int riceOption = 0; // 1 for yes 2 for no 3 for try again
            Console.WriteLine("Welcome to super burrito automatic machine");
            Console.WriteLine("Enter 1 for Burrito Bowl, 2 for Burrito with 2 Ingredients, 3 for Burrito with 3 Ingredients");
            string burritoType = Console.ReadLine();

            switch (burritoType)
            {
                case "1":
                    myMeat.meatSelect();
                    mySalsa.salsaSelect();
                    riceOption = riceCheck();
                    if (riceOption == 1)
                    {
                        BurritoBowl burritoBowl = new BurritoBowl(true, myMeat, mySalsa);
                        burritoBowlList.Add(burritoBowl);
                    }
                    else
                    {
                        BurritoBowl burritoBowl = new BurritoBowl(false, myMeat, mySalsa);
                        burritoBowlList.Add(burritoBowl);
                    }

                    break;
                case "2":
                    myMeat.meatSelect();
                    mySalsa.salsaSelect();
                    riceOption = riceCheck();
                    if (riceOption == 1)
                    {
                        BurritoTwo burritoTwo = new BurritoTwo(true, myMeat, mySalsa);
                        burritoTwoList.Add(burritoTwo);
                    }
                    else
                    {
                        BurritoTwo burritoTwo = new BurritoTwo(false, myMeat, mySalsa);
                        burritoTwoList.Add(burritoTwo);
                    }
                    break;
                case "3":
                    myMeat.meatSelect();
                    mySalsa.salsaSelect();
                    myTopping.toppingSelect();
                    riceOption = riceCheck();
                    if (riceOption == 1)
                    {
                        BurritoThree burritoThree = new BurritoThree(true, myMeat, mySalsa, myTopping);
                        burritoThreeList.Add(burritoThree);
                    }
                    else
                    {
                        BurritoThree burritoThree = new BurritoThree(false, myMeat, mySalsa, myTopping);
                        burritoThreeList.Add(burritoThree);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Burrito Selection!");
                    burritoEnter();
                    break;
            }

        }

        public static int riceCheck()
        {
            Console.WriteLine("Would you like rice? 1 for yes or 2 for no");
            string riceSelect = Console.ReadLine();
            switch (riceSelect)
            {
                case "1":
                    return 1;

                case "2":
                    return 2;

                default:
                    Console.WriteLine("Invalid rice Selection!");
                    riceCheck();
                    break;

                    //return 1;
            }
            return 3;

        }

        public static int moreBurritoCheck()
        {
            Console.WriteLine("Would you like to add another burrito? 1 for yes 2 for no");
            string burritoDecision = Console.ReadLine();
            switch (burritoDecision)
            {
                case "1":
                    return 1;

                case "2":
                    return 2;
                default:
                    Console.WriteLine("Invalid Selection!");
                    moreBurritoCheck();
                    break;
                    //return 1;
            }
            return 1;
        }

        public static void burritoCost()
        {
            double totalCost = 0;
            foreach (var item in burritoBowlList)
            {
                totalCost = totalCost + item.cost;
                Console.WriteLine("Burrito Bowl cost: " + item.cost);
            }

            foreach (var item in burritoTwoList)
            {
                totalCost = totalCost + item.cost;
                Console.WriteLine("Burrito Two Ingredient cost: " + item.cost);
            }

            foreach (var item in burritoThreeList)
            {
                totalCost = totalCost + item.cost;
                Console.WriteLine("Burrito Three Ingredient cost: " + item.cost);
            }

            Console.WriteLine("Total Burritos cost: " + totalCost);
        }
    }
}
