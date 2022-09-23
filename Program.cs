using System;
using System.Collections.Generic;
using System.Text;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Депозирана сума – реално число в интервала[100.00 … 10000.00]
2.Срок на депозита(в месеци) – цяло число в интервала[1…12]
3.Годишен лихвен процент – реално число в интервала[0.00 …100.00]
            сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
*/
            // INPUT
            int depositSUM = int.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            // Calculations
            double lihva = depositSUM * percent / 100;
            double lihvaZaMesec = lihva / 12;
            double SUM = depositSUM + depositMonths * lihvaZaMesec;
            //Output
            Console.WriteLine(SUM);

        }
    }
}
