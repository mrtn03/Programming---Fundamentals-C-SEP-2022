using System;
using System.Collections.Generic;
using System.Text;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input from the user
            double number = double.Parse(Console.ReadLine());
            // Logical convertion
            double inches = 2.54;
            double centimeters = number * inches;
            Console.WriteLine(centimeters);

        }
    }
}
