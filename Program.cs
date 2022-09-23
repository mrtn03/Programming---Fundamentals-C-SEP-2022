using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // цени
            double predpazenNylon = 1.5;
            double pricepaint = 14.50;
            double razreditelZaBoq = 5;
            double bags = 0.4;
            
            // Input
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            //Calculations
            double sumForNylon = (nylon + 2) * predpazenNylon;
            double sumForPaint = (paint + paint * 0.1) * pricepaint;
            double sumForRazreditel = razreditel * razreditelZaBoq;
            double sumForBags = bags;
            double sumAll = sumForBags + sumForPaint + sumForNylon + sumForRazreditel;
            double sumForMaistori = sumAll * 0.30 * hours;
            double krainaSuma = sumAll + sumForMaistori;

            // Output
            Console.WriteLine(krainaSuma);


        }
    }
}
