using System;
using System.Collections.Generic;
using System.Text;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int cenaZaGodina = int.Parse(Console.ReadLine());
            // Calculations
            double cenaNaTrenirovkiteGodina = cenaZaGodina;
            double cenaNaKecove = cenaZaGodina * 0.60;
            double basketballEkip = cenaNaKecove * 0.80;
            double cenaNaBasketballTopka = basketballEkip / 4;
            double cenaNaBasketballAccsessoaries = cenaNaBasketballTopka / 5;
            double sumForEquipment = cenaNaTrenirovkiteGodina + cenaNaKecove + basketballEkip + cenaNaBasketballTopka + cenaNaBasketballAccsessoaries;
            // Output
            Console.WriteLine(sumForEquipment);

        }
    }
}
