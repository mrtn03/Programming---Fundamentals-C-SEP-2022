using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodCount = int.Parse(Console.ReadLine());
            int catFoodCount = int.Parse(Console.ReadLine());
            double singleDogFoodPrice = 2.5;
            double singleCatFoodPrice = 4;

            double totalPriceForDogFood = dogFoodCount * singleDogFoodPrice;
            double totalPriceForCatFood = catFoodCount * singleCatFoodPrice;
            double totalPrice =  totalPriceForDogFood + totalPriceForCatFood;
            Console.WriteLine($" {totalPrice} lv.");
        }
    }
}
