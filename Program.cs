using System;
using System.Collections.Generic;
using System.Text;

namespace _07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            // danni
            double pileshkoMenu = 10.35;
            double menuRiba = 12.40;
            double vegetarianskoMenu = 8.15;
            double cenaZaDostavka = 2.5;

            // Input
            int broiPileshkiMenuta = int.Parse(Console.ReadLine());
            int broiMenutaRiba = int.Parse(Console.ReadLine());
            int vegetarianskiMenutabroi = int.Parse(Console.ReadLine());

            //Calculations
            double cenaZaPileshkiMenuta = broiPileshkiMenuta * pileshkoMenu;
            double cenaZaMenutaRiba = broiMenutaRiba * menuRiba;
            double cenaZaVegetarianskiMenuta = vegetarianskiMenutabroi * vegetarianskoMenu;
            double sumMenu = cenaZaMenutaRiba + cenaZaPileshkiMenuta + cenaZaVegetarianskiMenuta;
            double sumDesert = sumMenu * 0.20;
            double dostavkaCena = cenaZaDostavka;
            double obshtaCenaNaDostavkata = sumMenu + sumDesert + dostavkaCena;
            // Output
            Console.WriteLine(obshtaCenaNaDostavkata);
        }
    }
}
