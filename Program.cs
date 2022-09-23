using System;
using System.Collections.Generic;
using System.Text;

namespace _05.SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Пакет химикали - 5.80 лв. 
            // •	Пакет маркери -7.20 лв.
            // •	Препарат - 1.20 лв(за литър)

            double paketHimikali = 5.8;
            double paketMarkeri = 7.2;
            double preparat = 1.2;
            //•	Процент намаление -цяло число в интервала[0...100]

            //Input
            int cenaZaPaketiteHimikali = int.Parse(Console.ReadLine());
            int cenaZaPaketMarkeri = int.Parse(Console.ReadLine());
            int cenaZaPreparat = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            //Calculations
            double krainaCenaZaHimikali = paketHimikali * cenaZaPaketiteHimikali;
            double krainaCenaZaMarkeri = paketMarkeri * cenaZaPaketMarkeri;
            double krainaCenaZaPreparat = preparat * cenaZaPreparat;
            double sumForAllMaterials = krainaCenaZaHimikali + krainaCenaZaMarkeri + krainaCenaZaPreparat;
            double sumWithDiscount = sumForAllMaterials - (sumForAllMaterials * percent / 100);

            // Output
            Console.WriteLine(sumWithDiscount);


        }
    }
}
