using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input from user
            double size = double.Parse(Console.ReadLine());
            double priceWithoutDiscount = size * 7.61;
            double discount = priceWithoutDiscount * 0.18;

            Console.WriteLine($"The final price is: {priceWithoutDiscount - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv. ");

        }
    }
}
