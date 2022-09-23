using System;
using System.Collections.Generic;
using System.Text;

namespace _02.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double radianiKumGradusi = radians * 180 / Math.PI;
            Console.WriteLine(radianiKumGradusi);
        }
    }
}
